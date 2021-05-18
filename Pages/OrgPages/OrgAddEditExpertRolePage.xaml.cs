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

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgAddEditExpertRolePage.xaml
    /// </summary>
    public partial class OrgAddEditExpertRolePage : Page
    {
        ExpertRole currentRole = new ExpertRole();

        public OrgAddEditExpertRolePage(ExpertRole expertRole)
        {
            InitializeComponent();

            if (expertRole != null)
                currentRole = expertRole;

            DataContext = currentRole;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(currentRole.ExpertRoleName))
                errors.AppendLine("Укажите название роли");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (currentRole.ID == 0)
                {
                    currentRole.CompetiotionID = CompetitionDBEntities.currentCompettion.ID;
                    CompetitionDBEntities.GetContext().ExpertRole.Add(currentRole);
                }

                try
                {
                    CompetitionDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Роль для эксперта успешно сохранена!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Navigation.SubFrame.Navigate(new OrgExpertRolesPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Изменения будут потеряны! Сохранить?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    CompetitionDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Изменения сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Navigation.SubFrame.Navigate(new OrgExpertRolesPage());
        }
    }
}
