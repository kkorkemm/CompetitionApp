using System;
using System.Windows;
using System.Linq;
using System.IO;
using System.Text;

namespace CompetitionApp
{
    using Pages;
    using Base;

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        void AddDay(string dayName)
        {
            try
            {
                
                Day newDay = new Day
                {
                    CompetitionID = CompetitionDBEntities.currentCompettion.ID,
                    DayName = dayName,
                    AccessCode = Helper.GetRandomCode("ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890", 7)
                };

                CompetitionDBEntities.GetContext().Day.Add(newDay);
                CompetitionDBEntities.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MainWindow()
        {

            InitializeComponent();

            var competitions = CompetitionDBEntities.GetContext().Competition.ToList();
            var currentDate = DateTime.Now;
            var orderedDates = competitions.OrderBy(p => p.BeginDate).ToList();

            foreach(var date in orderedDates)
            {
                if (currentDate <= date.BeginDate.AddDays(date.DaysCount + 1))
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
                if (CompetitionDBEntities.currentCompettion.Day.Count == 0)
                {
                    TimeSpan prevDays = CompetitionDBEntities.currentCompettion.BeginDate.AddDays(2) - DateTime.Now;

                    for (int i = 0; i < prevDays.Days; i++)
                    {
                        AddDay($"C-{i+1}");
                    }

                    for (int i = 0; i < CompetitionDBEntities.currentCompettion.DaysCount; i++)
                    {
                        AddDay($"C{i + 1}");
                    }

                    AddDay("C+1");
                }


                //ЗАПОМНИТЬ МЕНЯ
                string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CompetitionApp\login.txt";
                if (File.Exists(file))
                {
                    string login;
                    using (StreamReader sr = new StreamReader(file, Encoding.Default))
                    {
                        login = sr.ReadLine();
                        sr.Close();
                    }

                    var user = CompetitionDBEntities.GetContext().User.Where(p => p.Surname == login && p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID).FirstOrDefault();

                    CompetitionDBEntities.currentUser = user;

                    if (user.UserRoleID == 1)
                    {
                        mainFrame.Navigate(new CompetitorPage());
                    }

                    if (user.UserRoleID == 3)
                    {
                        mainFrame.Navigate(new ExpertPage());
                    }

                    if (user.UserRoleID == 6)
                    {
                        mainFrame.Navigate(new OrgPage());
                    }
                }
                else
                {
                    mainFrame.Navigate(new LoginPage());
                }
                
                Navigation.MainFrame = mainFrame;
            }
        }
    }
}
