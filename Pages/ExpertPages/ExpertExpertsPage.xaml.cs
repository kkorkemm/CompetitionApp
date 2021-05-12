using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompetitionApp.Pages.ExpertPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для ExpertExpertsPage.xaml
    /// </summary>
    public partial class ExpertExpertsPage : Page
    {
        public ExpertExpertsPage()
        {
            InitializeComponent();

            var users = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 2);
            int count = users.Where(p => p.UserStatusID != 1).Count();

            if (count > 0)
            {
                BtnFix.IsEnabled = false;
            }

            DGridUsers.ItemsSource = users.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertAddExpertPage(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertAddExpertPage((sender as Button).DataContext as User));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedUsers = DGridUsers.SelectedItems.Cast<User>().ToList();
            int count = selectedUsers.Count();

            if (count == 0)
            {
                MessageBox.Show("Выберите экспертов для удаления", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show($"Вы действительно хотите удалить следующие элементы ({count})?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    foreach(User user in selectedUsers)
                    {
                        user.UserStatusID = 4;
                    }

                    try
                    {
                        CompetitionDBEntities.GetContext().SaveChanges();

                        MessageBox.Show("Запрос на удаление данных был успешно отправлен! Ожидайте подтверждение от организатора", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                        DGridUsers.ItemsSource = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 2).ToList();

                        BtnFix.IsEnabled = false;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnFix_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
