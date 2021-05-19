using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgViewExpertRolePage.xaml
    /// </summary>
    public partial class OrgViewExpertRolePage : Page
    {
        public OrgViewExpertRolePage(ExpertRole expertRole)
        {
            InitializeComponent();
            DataContext = expertRole;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgExpertRolesPage());
        }
    }
}
