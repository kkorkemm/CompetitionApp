using System;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.CompetitiorPages
{
    using Base;
    using System.IO;

    /// <summary>
    /// Логика взаимодействия для CompetitorMainPage.xaml
    /// </summary>
    public partial class CompetitorMainPage : Page
    {
        public CompetitorMainPage()
        {
            InitializeComponent();
            TextHello.Text = Helper.WhatTimeOfDay();
            TextHello.Text += "\n" + CompetitionDBEntities.currentUser.FullName;
            TextDay.Text = $"День {Helper.WhatDay()}";
            TextCompName.Text = CompetitionDBEntities.currentCompettion.CompetitionName;
            TextSkillName.Text += CompetitionDBEntities.currentUser.Skill.SkillName;
        }

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
