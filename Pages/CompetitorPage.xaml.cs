using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages
{
    using Base;
    using Pages.CompetitiorPages;

    /// <summary>
    /// Логика взаимодействия для CompetitorPage.xaml
    /// </summary>
    public partial class CompetitorPage : Page
    {
        public CompetitorPage()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextPin.Text))
            {
                MessageBox.Show("Введите код доступа", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                string dayName = Helper.WhatDay();
                var day = CompetitionDBEntities.GetContext().Day.Where(p => p.CompetitionID == CompetitionDBEntities.currentCompettion.ID && p.DayName == dayName).FirstOrDefault();

                string code = day.AccessCode;

                if (code == TextPin.Text)
                {
                    Navigation.MainFrame.Navigate(new CompetitorMainPage());
                }
                else
                {
                    MessageBox.Show("Вы ввели неверный код!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }
    }
}
