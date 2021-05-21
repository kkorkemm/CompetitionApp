using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.ExpertPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для ExpertUsersPage.xaml
    /// </summary>
    public partial class ExpertUsersPage : Page
    {
        public ExpertUsersPage()
        {
            InitializeComponent();

            var users = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 1);

            DGridUsers.ItemsSource = users.ToList();

            if (users.Where(p => p.UserStatusID != 1).Count() > 0)
            {
                BtnFix.IsEnabled = false;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertAddUsersPage(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertAddUsersPage((sender as Button).DataContext as User));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedUsers = DGridUsers.SelectedItems.Cast<User>().ToList();
            int count = selectedUsers.Count;

            if (count != 0)
            {
                MessageBoxResult result = MessageBox.Show($"Вы действительно хотите удалить следующие элементы ({selectedUsers.Count})?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        foreach(var user in selectedUsers)
                        {
                            user.UserStatusID = 4;
                        }
                        CompetitionDBEntities.GetContext().SaveChanges();

                        MessageBox.Show("Запрос на удаление данных был успешно отправлен! Ожидайте подтверждение от организатора", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                        DGridUsers.ItemsSource = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 1).ToList();

                        BtnFix.IsEnabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите элементы для удаления", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnFix_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGridUsers_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = $" {e.Row.GetIndex() + 1} ";
        }
    }
}
