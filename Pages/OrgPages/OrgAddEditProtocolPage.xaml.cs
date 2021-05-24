using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgAddEditProtocolPage.xaml
    /// </summary>
    public partial class OrgAddEditProtocolPage : Page
    {
        Protocols currentProtocol = new Protocols();

        public OrgAddEditProtocolPage(Protocols protocol)
        {
            InitializeComponent();

            if (protocol != null)
            {
                currentProtocol = protocol;
                TextTitle.Text = "Редактировать протокол";
            }

            DataContext = currentProtocol;

            string day = Helper.WhatDay();
            ComboDays.ItemsSource = CompetitionDBEntities.GetContext().Day.Where(p => p.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();
            ComboDays.SelectedItem = CompetitionDBEntities.GetContext().Day.Where(p => p.DayName == day).FirstOrDefault();

            var roles = CompetitionDBEntities.GetContext().UserRole.Where(p => p.ID == 1 || p.ID == 2).ToList();
            ComboRoles.ItemsSource = roles;
            ComboRoles.SelectedIndex = 0;

            if (currentProtocol.ProtocolExtraTextField.Count > 0)
            {
                var textList = currentProtocol.ProtocolExtraTextField.ToList();
                foreach (var text in textList)
                {
                    StackPanel stackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal,
                        Margin = new Thickness(0, 0, 0, 10)
                    };
                    TextBlock textBlock = new TextBlock()
                    {
                        Text = text.ExtraFieldName + ":"
                    };
                    TextBox textBox = new TextBox()
                    {
                        Text = text.Content
                    };
                    stackPanel.Children.Add(textBlock);
                    stackPanel.Children.Add(textBox);

                    StackPanelAdded.Children.Add(stackPanel);
                }
            }

            if (currentProtocol.ProtocolExtraDateField.Count > 0)
            {
                var dateList = currentProtocol.ProtocolExtraDateField.ToList();
                foreach (var date in dateList)
                {
                    StackPanel stackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal,
                        Margin = new Thickness(0, 0, 0, 10)
                    };
                    TextBlock textBox = new TextBlock()
                    {
                        Text = date.ExtraFieldName + ":"
                    };
                    DatePicker datePicker = new DatePicker()
                    {
                        SelectedDate = date.Content
                    };

                    stackPanel.Children.Add(textBox);
                    stackPanel.Children.Add(datePicker);

                    StackPanelAdded.Children.Add(stackPanel);
                }
            }

            if (currentProtocol.ProtocolExtraTimeStampField.Count > 0)
            {
                var timeList = currentProtocol.ProtocolExtraTimeStampField.ToList();
                foreach (var time in timeList)
                {
                    StackPanel stackPanel = new StackPanel()
                    {
                        Orientation = Orientation.Horizontal,
                        Margin = new Thickness(0, 0, 0, 10)
                    };

                    TextBlock textBlock = new TextBlock()
                    {
                        Text = time.ExtraFieldName + ":"
                    };

                    TimeSpan timeSpan = new TimeSpan();
                    TextBox textBox = new TextBox()
                    {
                        Text = timeSpan.ToString()
                    };

                    stackPanel.Children.Add(textBlock);
                    stackPanel.Children.Add(textBox);

                    StackPanelAdded.Children.Add(stackPanel);
                }
            }
        }

        void SaveChanges()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(currentProtocol.ProtocolName))
                errors.AppendLine("Укажите название протокола");
            if (currentProtocol.UserRole == null)
                errors.AppendLine("Укажите, для кого составлен протокол");
            if (currentProtocol.Day == null)
                errors.AppendLine("Укажите день чемпионата");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (currentProtocol.ProtocolID == 0)
                {
                    currentProtocol.Finished = false;
                    CompetitionDBEntities.GetContext().Protocols.Add(currentProtocol);

                    var users = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == currentProtocol.UserRoleID).ToList();

                    foreach(var user in users)
                    {
                        ProtocolAndUser protocolAndUser = new ProtocolAndUser()
                        {
                            ProtocolID = currentProtocol.ProtocolID,
                            UserID = user.ID
                        };
                        CompetitionDBEntities.GetContext().ProtocolAndUser.Add(protocolAndUser);
                    }
                }

                try
                {
                    CompetitionDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Протокол успешно сохранен!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Navigation.SubFrame.Navigate(new OrgProtocolsSettingsPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveChanges();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Изменения будут потеряны! Сохранить?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                SaveChanges();
            }
            else
            {
                Navigation.SubFrame.Navigate(new OrgProtocolsSettingsPage());
            }
        }

        private void BtnAddField_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgAddProtocolFieldPage(currentProtocol));
        }

        private void BtnAddColumn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgAddProtocolColumnPage(currentProtocol));
        }
    }
}
