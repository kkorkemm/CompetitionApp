using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.CompetitiorPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для CompetitorUsersProtocolsPage.xaml
    /// </summary>
    public partial class CompetitorUsersProtocolsPage : Page
    {
        public CompetitorUsersProtocolsPage(User user)
        {
            InitializeComponent();

            DataContext = user;

            var protocolFinished = CompetitionDBEntities.GetContext().ProtocolFinished.Where(p => p.Active == true).ToList();

            DGridProtocols.ItemsSource = user.ProtocolAndUser.Where(p => p.UserID == user.ID).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new CompetitorUsersPage());
        }
    }
}
