using System;
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

            var protocolFinished = CompetitionDBEntities.GetContext().ProtocolFinished.Where(p => p.SkillID == CompetitionDBEntities.currentUser.SkillID).ToList();

            ComboProtocols.ItemsSource = protocolFinished.ToList();

            UpdateProtocols();
            CheckFinished();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertProtocolPage());
        }

        void UpdateProtocols()
        {
            var protocol = ComboProtocols.SelectedItem as ProtocolFinished;
            var protocolList = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID && p.User.SkillID == CompetitionDBEntities.currentUser.SkillID).ToList();

            DGridUsers.ItemsSource = protocolList;

            int usersCount = protocolList.Count();
            int signedCount = protocolList.Count(p => p.Signed == true);

            string role = "";
            if (protocol.Protocols.UserRoleID == 1)
                role = "участников";
            else if (protocol.Protocols.UserRoleID == 2)
                role = "экспертов";

            TextCount.Text = $"Протокол подписан {signedCount} из {usersCount} {role}";

            if (signedCount != usersCount)
            {
                BtnPin.IsEnabled = false;
            }
            else
            {
                BtnPin.IsEnabled = true;
            }
       
        }

        void CheckFinished()
        {
            var protocol = ComboProtocols.SelectedItem as ProtocolFinished;
            var protocolFinished = CompetitionDBEntities.GetContext().ProtocolFinished.Where(p => p.ProtocolID == protocol.ProtocolID && p.SkillID == CompetitionDBEntities.currentUser.SkillID).FirstOrDefault();

            if (protocolFinished.Finished == true)
            {
                BtnPin.Content = "Протокол оформлен и подписан!";
                BtnPin.IsEnabled = false;
                TextPin.Text = "";
                TextPin.IsEnabled = false;
            }
            else
            {
                BtnPin.Content = "Использовать итоговое подписание";
                TextPin.IsEnabled = true;
            }
        }

        private void ComboProtocols_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProtocols();
            CheckFinished();
        }

        private void BtnPin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextPin.Text))
            {
                MessageBox.Show("Введите свой PIN код", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else
            {
                if (TextPin.Text != CompetitionDBEntities.currentUser.PIN)
                {
                    MessageBox.Show("Неправильный PIN код", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    var protocol = ComboProtocols.SelectedItem as ProtocolFinished;
                    var protocolFinished = CompetitionDBEntities.GetContext().ProtocolFinished.Where(p => p.ProtocolID == protocol.ProtocolID && p.SkillID == CompetitionDBEntities.currentUser.SkillID).FirstOrDefault();
                    protocolFinished.Finished = true;

                    try
                    {
                        CompetitionDBEntities.GetContext().SaveChanges();
                        MessageBox.Show("Протокол оформлен и подписан!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                        CheckFinished();
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
