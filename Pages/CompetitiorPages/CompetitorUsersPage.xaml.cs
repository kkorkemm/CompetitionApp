using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CompetitionApp.Pages.CompetitiorPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для CompetitorUsersPage.xaml
    /// </summary>
    public partial class CompetitorUsersPage : Page
    {
        public CompetitorUsersPage()
        {
            InitializeComponent();
            ListUsers.ItemsSource = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 1 && p.ID != CompetitionDBEntities.currentUser.ID && p.SkillID == CompetitionDBEntities.currentUser.SkillID).ToList();
        }

        private void ListUsers_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //ListBoxItem item = ItemsControl.ContainerFromElement(ListUsers, e.OriginalSource as DependencyObject) as ListBoxItem;

            //if (item != null)
            //{
            //    Navigation.SubFrame.Navigate(new CompetitorUsersProtocolsPage((item).DataContext as User));
            //}

            ListBoxItem item = ItemsControl.ContainerFromElement(ListUsers, e.OriginalSource as DependencyObject) as ListBoxItem;

            if (item != null)
            {
                DGridProtocols.ItemsSource = ((item).DataContext as User).ProtocolAndUser.Where(p => p.UserID == ((item).DataContext as User).ID).ToList();
            }

        }
    }
}
