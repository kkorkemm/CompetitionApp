using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace CompetitionApp.Pages.CompetitiorPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для CompetitorProtocolInfoPage.xaml
    /// </summary>
    public partial class CompetitorProtocolInfoPage : Page
    {
        Protocols protocol = new Protocols();
        public CompetitorProtocolInfoPage(ProtocolAndUser currentProtocol)
        {
            InitializeComponent();
            protocol = currentProtocol.Protocols;

            DataContext = protocol;

            UpdateProtocols();
        }

        void UpdateProtocols()
        {
            DGridUsers.ItemsSource = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID).ToList();

            var prot = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID && p.UserID == CompetitionDBEntities.currentUser.ID).FirstOrDefault();

            if (prot.Signed)
            {
                TextPin.Text = "Вы подписали протокол!";
                TextPin.IsEnabled = false;
                BtnPin.IsEnabled = false;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new CompetitorProtocolsPage());
        }

        private void BtnPin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextPin.Text))
            {
                MessageBox.Show("Введите свой PIN-код для подписания протокола", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (TextPin.Text == CompetitionDBEntities.currentUser.PIN)
                {
                    var prot = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID && p.UserID == CompetitionDBEntities.currentUser.ID).FirstOrDefault();
                    prot.Signed = true;

                    try
                    {
                        CompetitionDBEntities.GetContext().SaveChanges();
                        MessageBox.Show("Протокол успешно подписан!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                        UpdateProtocols();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
