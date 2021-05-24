using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgProtocolViewPage.xaml
    /// </summary>
    public partial class OrgProtocolViewPage : Page
    {
        public OrgProtocolViewPage(Protocols protocol)
        {
            InitializeComponent();
            DataContext = protocol;

            var textList = protocol.ProtocolExtraTextField.ToList();
            var dateList = protocol.ProtocolExtraDateField.ToList();
            var timeList = protocol.ProtocolExtraTimeStampField.ToList();

            if (textList.Count > 0 )
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
                        Text = date.ExtraFieldName + ": "
                    };

                    TextBlock textBlock1 = new TextBlock()
                    {
                        Text = date.Content.ToString()
                    };

                    stackPanel.Children.Add(textBlock);
                    stackPanel.Children.Add(textBlock1);
                    StackPanelAdded.Children.Add(stackPanel);
                }
            };

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
            Navigation.SubFrame.Navigate(new OrgProtocolsSettingsPage());
        }
    }
}
