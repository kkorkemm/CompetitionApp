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
    /// Логика взаимодействия для OrgMainExpertsPage.xaml
    /// </summary>
    public partial class OrgMainExpertsPage : Page
    {
        public OrgMainExpertsPage()
        {
            InitializeComponent();

            var skills = CompetitionDBEntities.GetContext().Skill.ToList();
            skills.Insert(0, new Skill { SkillName = "Все компетенции" });
            ComboSkills.ItemsSource = skills;

            var roles = CompetitionDBEntities.GetContext().UserRole.Where(p => p.ID == 3 || p.ID == 4 || p.ID == 5).ToList();
            roles.Insert(0, new UserRole { RoleName = "Все роли" });
            ComboRoles.ItemsSource = roles;

            ComboSkills.SelectedIndex = 0;
            ComboRoles.SelectedIndex = 0;

            UpdateUsers();
        }

        void UpdateUsers()
        {
            var users = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && (p.UserRoleID == 3 || p.UserRoleID == 4 || p.UserRoleID == 5)).ToList();

            if (ComboSkills.SelectedIndex > 0)
            {
                users = users.Where(p => p.Skill == ComboSkills.SelectedItem as Skill).ToList();
            }
            if (ComboRoles.SelectedIndex > 0)
            {
                users = users.Where(p => p.UserRole == ComboRoles.SelectedItem as UserRole).ToList();
            }

            DGridUsers.ItemsSource = users;
        }
        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            UpdateUsers();
        }

        private void DGridUsers_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = $" {e.Row.GetIndex() + 1} ";
        }
    }
}
