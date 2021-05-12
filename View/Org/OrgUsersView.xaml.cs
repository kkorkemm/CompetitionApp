using System.Windows.Controls;

namespace CompetitionApp.View.Org
{
    using Pages.OrgPages;

    /// <summary>
    /// Логика взаимодействия для OrgUsersView.xaml
    /// </summary>
    public partial class OrgUsersView : UserControl
    {
        public OrgUsersView()
        {
            InitializeComponent();
            OrgUsersFrame.Navigate(new OrgUsersPage());
            Navigation.SubFrame = OrgUsersFrame;
        }
    }
}
