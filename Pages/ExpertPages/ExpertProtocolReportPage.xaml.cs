using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.ExpertPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для ExpertProtocolReportPage.xaml
    /// </summary>
    public partial class ExpertProtocolReportPage : Page
    {
        public ExpertProtocolReportPage()
        {
            InitializeComponent();

            ComboProtocols.ItemsSource = CompetitionDBEntities.GetContext().Protocols.Where(p => p.Day.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();

            UpdateProtocols();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertProtocolPage());
        }

        void UpdateProtocols()
        {
            var protocol = ComboProtocols.SelectedItem as Protocols;
            var protocolList = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID && p.User.UserStatusID == 1).ToList();

            DGridUsers.ItemsSource = protocolList;

            int usersCount = protocolList.Count();
            int signedCount = protocolList.Count(p => p.Signed == true);

            string role = "";
            if (protocol.UserRoleID == 1)
                role = "участников";
            else if (protocol.UserRoleID == 2)
                role = "экспертов";

            TextCount.Text = $"Протокол подписан {signedCount} из {usersCount} {role}";

            if (signedCount != usersCount)
            {
                TextPin.IsEnabled = false;
            }
            else
            {
                TextPin.IsEnabled = true;
            }

        }

        private void ComboProtocols_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProtocols();
        }
    }
}
