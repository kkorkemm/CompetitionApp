using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CompetitionApp.Base;

namespace CompetitionApp.View.Expert
{
    /// <summary>
    /// Логика взаимодействия для ExpertUsersView.xaml
    /// </summary>
    public partial class ExpertUsersView : UserControl
    {
        public ExpertUsersView()
        {
            InitializeComponent();
            var competitors = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 1);

            DGridUsers.ItemsSource = competitors.ToList();

            int confirmedUsers = competitors.Where(p => p.UserStatus.ID != 1).Count();
            if (confirmedUsers != 0)
            {
                BtnFix.IsEnabled = false;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Сохранить изменения в базу?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    CompetitionDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Изменения успешно были внесены в базу!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    DGridUsers.ItemsSource = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnFix_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedCompetitors = DGridUsers.SelectedItems.Cast<User>().ToList();

            if (selectedCompetitors.Count == 0)
            {
                MessageBox.Show("Выберите участников для удаления!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    CompetitionDBEntities.GetContext().User.RemoveRange(selectedCompetitors);

                    MessageBox.Show("Данные удалены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
