using System;
using System.Windows;
using System.Linq;

namespace CompetitionApp
{
    using Pages;
    using Base;
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            var competitions = CompetitionDBEntities.GetContext().Competition.ToList();
            var currentDate = DateTime.Now;
            var orderedDates = competitions.OrderBy(p => p.BeginDate).ToList();

            foreach(var date in orderedDates)
            {
                if (currentDate < date.BeginDate)
                {
                    currentDate = date.BeginDate;
                    break;
                }
            }

            CompetitionDBEntities.currentCompettion = CompetitionDBEntities.GetContext().Competition.Where(p => p.BeginDate == currentDate).FirstOrDefault();

            if (CompetitionDBEntities.currentCompettion == null)
            {
                MessageBox.Show("Чемпионатов не запланировано");
            }

            else
            {
                MessageBox.Show($"Следующий чемпионат: {CompetitionDBEntities.currentCompettion.CompetitionName}");

                if (CompetitionDBEntities.currentCompettion.Day.Count == 0)
                {
                    TimeSpan prevDays = CompetitionDBEntities.currentCompettion.BeginDate - DateTime.Now;

                    for (int i = 0; i < prevDays.Days; i++)
                    {
                        try
                        {
                            Day newDay = new Day
                            {
                                CompetitionID = CompetitionDBEntities.currentCompettion.ID,
                                DayName = $"C-{i + 1}"
                            };

                            CompetitionDBEntities.GetContext().Day.Add(newDay);
                            CompetitionDBEntities.GetContext().SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    for (int i = 0; i < CompetitionDBEntities.currentCompettion.DaysCount; i++)
                    {
                        try
                        {
                            Day newDay = new Day
                            {
                                CompetitionID = CompetitionDBEntities.currentCompettion.ID,
                                DayName = $"C{i + 1}"
                            };

                            CompetitionDBEntities.GetContext().Day.Add(newDay);
                            CompetitionDBEntities.GetContext().SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                    try
                    {
                        Day newDay = new Day
                        {
                            CompetitionID = CompetitionDBEntities.currentCompettion.ID,
                            DayName = "C+1"
                        };

                        CompetitionDBEntities.GetContext().Day.Add(newDay);
                        CompetitionDBEntities.GetContext().SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                mainFrame.Navigate(new LoginPage());
                Navigation.MainFrame = mainFrame;
            }
        }
    }
}
