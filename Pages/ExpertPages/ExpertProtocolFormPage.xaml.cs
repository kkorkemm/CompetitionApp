using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public ExpertProtocolFormPage(Protocols protocol)
        {
            InitializeComponent();
            DataContext = protocol;

            DGridUsers.ItemsSource = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.ProtocolID == protocol.ProtocolID).ToList();

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

        }
    }
}
