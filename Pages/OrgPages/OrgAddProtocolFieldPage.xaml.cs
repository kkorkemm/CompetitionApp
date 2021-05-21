using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgAddProtocolFieldPage.xaml
    /// </summary>
    public partial class OrgAddProtocolFieldPage : Page
    {
        Protocols currentProtocol;

        public OrgAddProtocolFieldPage(Protocols protocol)
        {
            InitializeComponent();
            currentProtocol = protocol;
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // текстовое поле
            if (ComboType.SelectedIndex == 0)
            {
                TextBox textBox = new TextBox();
                GridAdded.Children.Add(textBox);
                Grid.SetColumn(textBox, 1);
            }

            // временной штамп
            if (ComboType.SelectedIndex == 1)
            {
                TimeSpan timeSpan = new TimeSpan();
                TextBox textBox = new TextBox
                {
                    Name = "TextField",
                    Text = timeSpan.ToString()
                };
                
                GridAdded.Children.Add(textBox);
                Grid.SetColumn(textBox, 1);
            }

            // дата
            if (ComboType.SelectedIndex == 2)
            {
                DatePicker datePicker = new DatePicker();
                GridAdded.Children.Add(datePicker);
                Grid.SetColumn(datePicker, 1);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TextName.Text))
                errors.AppendLine("Введите название поля");
            if (ComboType.SelectedItem == null)
                errors.AppendLine("Выберите тип поля");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (ComboType.SelectedIndex == 0)
                {
                    ProtocolExtraTextField textField = new ProtocolExtraTextField
                    {
                        ProtocolID = currentProtocol.ID,
                        ExtraFieldName = TextName.Text,
                        Content = (GridAdded.Children.Count - 1).ToString()
                    };

                    if (textField.ExtraFieldID == 0)
                        CompetitionDBEntities.GetContext().ProtocolExtraTextField.Add(textField);
                }

                if (ComboType.SelectedIndex == 1)
                {
                    ProtocolExtraTimeStampField timeStampField = new ProtocolExtraTimeStampField
                    {
                        ProtocolID = currentProtocol.ID,
                        ExtraFieldName = TextName.Text
                    };

                    if (timeStampField.ExtraFielsID == 0)
                        CompetitionDBEntities.GetContext().ProtocolExtraTimeStampField.Add(timeStampField);
                }

                if (ComboType.SelectedIndex == 2)
                {
                    ProtocolExtraDateField dateField = new ProtocolExtraDateField
                    {
                        ProtocolID = currentProtocol.ID,
                        ExtraFieldName = TextName.Text
                    };

                    if (dateField.ExtraFieldID == 0)
                    {
                        CompetitionDBEntities.GetContext().ProtocolExtraDateField.Add(dateField);
                    }
                }

                try
                {
                    CompetitionDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Поле успешно добавлено!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Navigation.SubFrame.Navigate(new OrgAddEditProtocolPage(currentProtocol));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new OrgAddEditProtocolPage(currentProtocol));
        }
    }
}
