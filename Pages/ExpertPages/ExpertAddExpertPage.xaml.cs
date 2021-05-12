using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.ExpertPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для ExpertAddExpertPage.xaml
    /// </summary>
    public partial class ExpertAddExpertPage : Page
    {
        User currentUser = new User();

        public ExpertAddExpertPage(User user)
        {
            InitializeComponent();

            if (user != null)
            {
                TextTitle.Text = "Редактирование эксперта";
                currentUser = user;
            }

            DataContext = currentUser;
            ComboCompetitor.ItemsSource = CompetitionDBEntities.GetContext().User.Where(p => p.CompetiotionID == CompetitionDBEntities.currentCompettion.ID && p.UserRoleID == 1).ToList();
            ComboGender.ItemsSource = CompetitionDBEntities.GetContext().Gender.ToList();
            ComboRegion.ItemsSource = CompetitionDBEntities.GetContext().Region.ToList();
            ComboSkill.ItemsSource = CompetitionDBEntities.GetContext().Skill.ToList();
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
                    currentUser.UserRoleID = 2;
                    currentUser.UserStatusID = 2;

                    CompetitionDBEntities.GetContext().User.Add(currentUser);
                }
                else
                {
                    currentUser.UserStatusID = 3;
                }

                if (ComboCompetitor.SelectedItem != null)
                {
                    User competitor = ComboCompetitor.SelectedItem as User;

                    Expert expert = new Expert
                    {
                        ExpertID = currentUser.ID,
                        CompetitorID = competitor.ID
                    };

                    CompetitionDBEntities.GetContext().Expert.Add(expert);
                }

                try
                {
                    CompetitionDBEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

                    Navigation.SubFrame.Navigate(new ExpertExpertsPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertExpertsPage());
        }
    }
}
