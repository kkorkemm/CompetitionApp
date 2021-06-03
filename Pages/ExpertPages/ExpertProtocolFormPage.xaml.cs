using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.ExpertPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для ExpertProtocolFormPage.xaml
    /// </summary>
    public partial class ExpertProtocolFormPage : Page
    {
        Protocols protocol = new Protocols();

        public ExpertProtocolFormPage(Protocols newProtocol)
        {
            InitializeComponent();
            protocol = newProtocol;

            DataContext = protocol;

            var protocolFinished = CompetitionDBEntities.GetContext().ProtocolFinished.Where(p => p.ProtocolID == protocol.ProtocolID && p.SkillID == CompetitionDBEntities.currentUser.SkillID).FirstOrDefault();

            if (protocolFinished != null)
            {
                BtnSign.IsEnabled = false;
                ComboDays.IsEnabled = false;
            }

            ComboDays.ItemsSource = CompetitionDBEntities.GetContext().Day.Where(p => p.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList(); 

            DGridUsers.ItemsSource = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID && p.User.SkillID == CompetitionDBEntities.currentUser.SkillID).ToList();

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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertProtocolPage());
        }

        private void BtnSign_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Использовать электронное подписание для протокола? Дальнейшее редактирование и удаление невозможно", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                var users = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.SkillID == CompetitionDBEntities.currentUser.SkillID).ToList();

                string role = "";

                if (protocol.UserRoleID == 1)
                {
                    users = users.Where(p => p.UserRoleID == 1).ToList();
                    role = "участников";
                }

                if (protocol.UserRoleID == 2)
                {
                    users = users.Where(p => p.UserRoleID == 2).ToList();
                    role = "экспертов";
                }

                int count = users.Where(p => p.UserStatusID == 5).Count();

                if (count != users.Count())
                {
                    MessageBox.Show($"Зафиксируйте список {role} перед использованием электронного подписания!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                ProtocolFinished protocolFinished = new ProtocolFinished()
                {
                    ProtocolID = protocol.ProtocolID,
                    SkillID = CompetitionDBEntities.currentUser.SkillID,
                    Active = true
                };

                CompetitionDBEntities.GetContext().ProtocolFinished.Add(protocolFinished);
            }

            try
            {
                CompetitionDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Протокол доступен для подписания!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                BtnSign.IsEnabled = false;
                ComboDays.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
