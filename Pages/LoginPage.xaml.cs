using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages
{
    using Base;
    using System;
    using System.IO;

    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Авторизация пользователей
        /// </summary>
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            /// проверка на заполнение полей
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TextLogin.Text))
                errors.AppendLine("Введите логин");
            if (string.IsNullOrWhiteSpace(TextPass.Password))
                errors.AppendLine("Введите пароль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
            }
            else
            {
                var user = CompetitionDBEntities.GetContext().User.Where(p => p.Surname == TextLogin.Text && p.Password == TextPass.Password).FirstOrDefault();

                if (user != null)
                {
                    if (user.CompetiotionID != CompetitionDBEntities.currentCompettion.ID)
                    {
                        MessageBox.Show("Вы не были зарегистрированы на текущий чемпионат", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    CompetitionDBEntities.currentUser = user;

                    /// TODO: Запомнить меня
                    if (CheckRemember.IsChecked == true)
                    {
                        string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\CompetitionApp";
                        Directory.CreateDirectory(folder);

                        try
                        {
                            using (StreamWriter sw = new StreamWriter(folder + @"\login.txt", false, Encoding.Default))
                            {
                                sw.WriteLine(user.ID);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                    if (user.UserRoleID == 1)
                    {
                        Navigation.MainFrame.Navigate(new CompetitorPage());
                    }

                    if (user.UserRoleID == 3)
                    {
                        Navigation.MainFrame.Navigate(new ExpertPage());
                    }

                    if (user.UserRoleID == 6)
                    {
                        Navigation.MainFrame.Navigate(new OrgPage());
                    }
                }

                else
                {
                    MessageBox.Show("Неверное соответствие логина и пароля", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }
    }
}
