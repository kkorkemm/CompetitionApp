using System;
using System.IO;
using System.Windows.Controls;

namespace CompetitionApp.Pages
{
    using Base;
    using System.Windows;

    /// <summary>
    /// Логика взаимодействия для ExpertPage.xaml
    /// </summary>
    public partial class ExpertPage : Page
    {
        public ExpertPage()
        {
            InitializeComponent();

            TextHello.Text = Helper.WhatTimeOfDay();
            TextHello.Text += "\n" + CompetitionDBEntities.currentUser.FullName;
            TextDay.Text = $"День {Helper.WhatDay()}";
            TextCompName.Text = CompetitionDBEntities.currentCompettion.CompetitionName;
            TextSkillName.Text += CompetitionDBEntities.currentUser.Skill.SkillName;
            TextCode.Text = CompetitionDBEntities.currentDay.AccessCode;
        }

        /// <summary>
        /// Выход из системы (разлогониться)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, System.Windows.RoutedEventArgs e)
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
