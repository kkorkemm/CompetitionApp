using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.IO;
using System.Windows.Media.Imaging;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;
    /// <summary>
    /// Логика взаимодействия для OrgMainSettingsPage.xaml
    /// </summary>
    public partial class OrgMainSettingsPage : Page
    {
        Competition currentCompetition = new Competition();

        public OrgMainSettingsPage()
        {
            InitializeComponent();

            currentCompetition = CompetitionDBEntities.currentCompettion;
            DataContext = currentCompetition;
        }

        private void BtnLogo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Image Files(*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg"
            };

            if (fileDialog.ShowDialog() == true)
            {
                byte[] imageData;

                using (FileStream file = new FileStream(fileDialog.FileName, FileMode.Open))
                {
                    imageData = new byte[file.Length];
                    file.Read(imageData, 0, imageData.Length);
                }

                ImageLogo.Source = new BitmapImage(new Uri(fileDialog.FileName));
                currentCompetition.Logo = imageData;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CompetitionDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Настройки чемпионата сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
