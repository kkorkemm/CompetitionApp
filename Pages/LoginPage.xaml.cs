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

namespace CompetitionApp.Pages
{
    using Base;

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
                /// TODO: пользователи текущего чемпионата
                var userName = CompetitionDBEntities.GetContext().User.Where(p => p.Surname == TextLogin.Text).ToList();

                if (userName.Count > 0)
                {
                    foreach(var user in userName)
                    {
                        if (user.Password == TextPass.Password)
                        {
                            CompetitionDBEntities.currentUser = user;

                            /// TODO: Запомнить меня
                            if (CheckRemember.IsChecked == true)
                            {

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
                            MessageBox.Show("Неверный пароль!");
                            return;
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Такого пользователя в базе нет");
                }
            }
        }
    }
}
