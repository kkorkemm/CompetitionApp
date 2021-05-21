using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgExpertRolesPage.xaml
    /// </summary>
    public partial class OrgExpertRolesPage : Page
    {
        public OrgExpertRolesPage()
        {
            InitializeComponent();

            DGridExperts.ItemsSource = CompetitionDBEntities.GetContext().ExpertRole.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID).ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgAddEditExpertRolePage((sender as Button).DataContext as ExpertRole));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgAddEditExpertRolePage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedRoles = DGridExperts.SelectedItems.Cast<ExpertRole>().ToList();

            if (selectedRoles.Count == 0)
            {
                MessageBox.Show("Выберите роли для удаления", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show($"Вы действительно хотите удалить следующие роли эксперта ({selectedRoles.Count})?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    CompetitionDBEntities.GetContext().ExpertRole.RemoveRange(selectedRoles);

                    try
                    {
                        CompetitionDBEntities.GetContext().SaveChanges();
                        MessageBox.Show("Роли успешно удалены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                        DGridExperts.ItemsSource = CompetitionDBEntities.GetContext().ExpertRole.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID).ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            } 
        }

        private void BtnView_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgViewExpertRolePage((sender as Button).DataContext as ExpertRole));
        }

        private void DGridExperts_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = $" {e.Row.GetIndex() + 1} ";
        }
    }
}
