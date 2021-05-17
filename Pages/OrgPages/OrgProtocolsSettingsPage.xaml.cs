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
    /// Логика взаимодействия для OrgProtocolsSettingsPage.xaml
    /// </summary>
    public partial class OrgProtocolsSettingsPage : Page
    {
        public OrgProtocolsSettingsPage()
        {
            InitializeComponent();

            var days = CompetitionDBEntities.GetContext().Day.Where(p => p.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();
            days.Insert(0, new Day { DayName = "Все дни" });
            ComboDays.ItemsSource = days.ToList();

            ComboDays.SelectedIndex = 0;
            ComboRoles.SelectedIndex = 0;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
