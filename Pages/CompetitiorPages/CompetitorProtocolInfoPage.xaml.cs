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

            var mainExpert = CompetitionDBEntities.GetContext().User.Where(p => p.SkillID == CompetitionDBEntities.currentUser.SkillID && p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 3).FirstOrDefault();
            TextMainExpertName.Text = $"Главный эксперт на площадке: {mainExpert.FullName}";

            UpdateProtocols();

            var textList = protocol.ProtocolExtraTextField.ToList();
            var dateList = protocol.ProtocolExtraDateField.ToList();
            var timeList = protocol.ProtocolExtraTimeStampField.ToList();

            if (textList.Count > 0)
            {
                foreach (var text in textList)
                {
                    StackPanel stackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal
                    };
                    TextBlock textBlock = new TextBlock()
                    {
                        Text = text.ExtraFieldName + ":"
                    };
                    TextBlock textBlock1 = new TextBlock()
                    {
                        Text = text.Content
                    };
                    stackPanel.Children.Add(textBlock);
                    stackPanel.Children.Add(textBlock1);
                    StackPanelAdded.Children.Add(stackPanel);
                }
            }

            if (dateList.Count > 0)
            {
                foreach (var date in dateList)
                {
                    StackPanel stackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal
                    };
                    TextBlock textBlock = new TextBlock()
                    {
                        Text = date.ExtraFieldName + ":"
                    };
                    TextBlock textBlock1 = new TextBlock()
                    {
                        Text = date.Content.ToString()
                    };
                    stackPanel.Children.Add(textBlock);
                    stackPanel.Children.Add(textBlock1);
                    StackPanelAdded.Children.Add(stackPanel);
                }
            }

            if (timeList.Count > 0)
            {
                foreach (var time in timeList)
                {
                    StackPanel stackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal
                    };
                    TextBlock textBlock = new TextBlock()
                    {
                        Text = time.ExtraFieldName + ":"
                    };
                    TextBlock textBlock1 = new TextBlock()
                    {
                        Text = time.Content.ToString()
                    };
                    stackPanel.Children.Add(textBlock);
                    stackPanel.Children.Add(textBlock1);
                    StackPanelAdded.Children.Add(stackPanel);
                }
            }
        }

        void UpdateProtocols()
        {
            DGridUsers.ItemsSource = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID && p.User.SkillID == CompetitionDBEntities.currentUser.SkillID).ToList();

            var prot = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID && p.UserID == CompetitionDBEntities.currentUser.ID).FirstOrDefault();

            if (prot.Signed)
            {
                TextPin.Text = "Вы подписали протокол!";
                TextPin.IsEnabled = false;
                BtnPin.IsEnabled = false;
                TextComment.Text = "";
                TextComment.IsEnabled = false;
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
                if (TextPin.Text != CompetitionDBEntities.currentUser.PIN)
                {
                    MessageBox.Show("Неправильный PIN-код", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                MessageBoxResult result = MessageBox.Show("Подписать протокол? Отменить это действие нельзя", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                {
                    return;
                }

                if (TextPin.Text == CompetitionDBEntities.currentUser.PIN)
                {
                    var prot = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID && p.UserID == CompetitionDBEntities.currentUser.ID).FirstOrDefault();
                    prot.Signed = true;

                    if (!string.IsNullOrWhiteSpace(TextComment.Text))
                        prot.Comment = TextComment.Text;

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
