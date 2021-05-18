using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgProtocolsSettingsPage.xaml
    /// </summary>
    public partial class OrgProtocolsSettingsPage : Page
    {
        public OrgProtocolsSettingsPage()
        {
            InitializeComponent();

            var days = CompetitionDBEntities.GetContext().Day.Where(p => p.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();
            days.Insert(0, new Day { DayName = "Все дни" });
            ComboDays.ItemsSource = days.ToList();

            var roles = CompetitionDBEntities.GetContext().UserRole.Where(p => p.ID == 1 || p.ID == 2).ToList();
            roles.Insert(0, new UserRole { RoleName = "Все роли" });
            ComboRoles.ItemsSource = roles;

            ComboDays.SelectedIndex = 0;
            ComboRoles.SelectedIndex = 0;

            var protocols = CompetitionDBEntities.GetContext().Protocols.Where(p => p.Day.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();
            DGridProtocols.ItemsSource = protocols;
        }

        void UpdateProtocols()
        {
            var protocols = CompetitionDBEntities.GetContext().Protocols.Where(p => p.Day.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();

            if (ComboDays.SelectedIndex > 0)
                protocols = protocols.Where(p => p.Day == ComboDays.SelectedItem as Day).ToList();
            if (ComboRoles.SelectedIndex > 0)
                protocols = protocols.Where(p => p.UserRole == ComboRoles.SelectedItem as UserRole).ToList();

            DGridProtocols.ItemsSource = protocols;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedProtocols = DGridProtocols.SelectedItems.Cast<Protocols>().ToList();

            if (selectedProtocols.Count == 0)
            {
                MessageBox.Show("Выберите протоколы для удаления", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show($"Вы действительно хотите удалить следующие протоколы ({selectedProtocols.Count})?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    CompetitionDBEntities.GetContext().Protocols.RemoveRange(selectedProtocols);

                    try
                    {
                        CompetitionDBEntities.GetContext().SaveChanges();
                        MessageBox.Show("Список протоколов успешно обновлен!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                        UpdateProtocols();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgAddEditProtocolPage(null));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgAddEditProtocolPage((sender as Button).DataContext as Protocols));
        }

        private void ComboRoles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProtocols();
        }

        private void ComboDays_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProtocols();
        }
    }
}
