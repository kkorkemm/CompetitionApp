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

namespace CompetitionApp.Pages.ExpertPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для ExpertAddUsersPage.xaml
    /// </summary>
    public partial class ExpertAddUsersPage : Page
    {
        User currentUser = new User();

        public ExpertAddUsersPage(User user)
        {
            InitializeComponent();

            if (user != null)
            {
                TextTitle.Text = "Редактировать участника";
                currentUser = user;
            }

            DataContext = currentUser;

            ComboGender.ItemsSource = CompetitionDBEntities.GetContext().Gender.ToList();
            ComboSkill.ItemsSource = CompetitionDBEntities.GetContext().Skill.ToList();
            ComboRegion.ItemsSource = CompetitionDBEntities.GetContext().Region.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(currentUser.Surname))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(currentUser.Name))
                errors.AppendLine("Укажите имя");
            if (currentUser.Gender == null)
                errors.AppendLine("Укажите пол");
            if (currentUser.BirthDate == null)
                errors.AppendLine("Укажите дату рождения");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                if (currentUser.ID == 0)
                {
                    currentUser.CompetiotionID = CompetitionDBEntities.currentCompettion.ID;
                    currentUser.Password = Helper.GetRandomCode("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890", 8);
                    currentUser.PIN = Helper.GetRandomCode("1234567890", 5);
                    currentUser.UserRoleID = 1;
                    currentUser.UserStatusID = 2;

                    CompetitionDBEntities.GetContext().User.Add(currentUser);
                }
                else
                {
                    currentUser.UserStatusID = 3;
                }

                try
                {
                    CompetitionDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                    Navigation.SubFrame.Navigate(new ExpertUsersPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertUsersPage());
        }
    }
}
