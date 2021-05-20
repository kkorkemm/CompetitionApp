using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgPage.xaml
    /// </summary>
    public partial class OrgPage : Page
    {
        public OrgPage()
        {
            InitializeComponent();

            TextHello.Text = Helper.WhatTimeOfDay();
            TextHello.Text += "\n"+ CompetitionDBEntities.currentUser.FullName;
            TextDay.Text = $"День {Helper.WhatDay()}";
            TextCompName.Text = CompetitionDBEntities.currentCompettion.CompetitionName;
        }

        /// <summary>
        /// Выход из системы (разлогиниться)
        /// </summary>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult question = MessageBox.Show("Вы точно хотите выйти из системы?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (question == MessageBoxResult.Yes)
            {
                string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CompetitionApp\login.txt";
                File.Delete(file);
                Navigation.MainFrame.Navigate(new LoginPage());
            }
        }
    }
}
