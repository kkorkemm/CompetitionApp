using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgUsersPage.xaml
    /// </summary>
    public partial class OrgUsersPage : Page
    {
        public OrgUsersPage()
        {
            InitializeComponent();

            DGridUsers.ItemsSource = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID != 6).ToList();

            var roles = CompetitionDBEntities.GetContext().UserRole.Where(p => p.ID != 6).ToList();
            roles.Insert(0, new UserRole { RoleName = "Все роли" });
            ComboRole.ItemsSource = roles;
            ComboRole.SelectedIndex = 0;

            var skills = CompetitionDBEntities.GetContext().Skill.ToList();
            skills.Insert(0, new Skill { SkillName = "Все компетенции" });
            ComboSkill.ItemsSource = skills;
            ComboSkill.SelectedIndex = 0;
        }

        private void UpdateUsers()
        {
            var currentUsers = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID != 6).ToList();

            if (ComboRole.SelectedIndex > 0)
                currentUsers = currentUsers.Where(p => p.UserRole == (ComboRole.SelectedItem as UserRole)).ToList();
            if (ComboSkill.SelectedIndex > 0)
                currentUsers = currentUsers.Where(p => p.Skill == (ComboSkill.SelectedItem as Skill)).ToList();
            if (CheckStatus.IsChecked == true)
                currentUsers = currentUsers.Where(p => p.UserStatusID != 1).ToList();

            DGridUsers.ItemsSource = currentUsers.ToList();

        }

        private void BtnConfirm_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = (sender as Button).DataContext as User;

            if (selectedUser.UserStatusID != 4)
            {
                selectedUser.UserStatusID = 1;
            }
            else
            {
                CompetitionDBEntities.GetContext().User.Remove(selectedUser);
            }

            try
            {
                CompetitionDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Участник подтвержден!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                UpdateUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboSkill_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateUsers();
        }

        private void ComboRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateUsers();
        }

        private void CheckStatus_Checked(object sender, RoutedEventArgs e)
        {
            UpdateUsers();
        }

        private void CheckStatus_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateUsers();
        }

        private void DGridUsers_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = $" {e.Row.GetIndex() + 1} ";
        }
    }
}
