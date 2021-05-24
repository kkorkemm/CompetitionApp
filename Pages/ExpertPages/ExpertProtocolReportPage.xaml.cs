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
    /// Логика взаимодействия для ExpertProtocolReportPage.xaml
    /// </summary>
    public partial class ExpertProtocolReportPage : Page
    {
        public ExpertProtocolReportPage()
        {
            InitializeComponent();

            ComboProtocols.ItemsSource = CompetitionDBEntities.GetContext().Protocols.Where(p => p.Day.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertProtocolPage());
        }

        void UpdateProtocols()
        {

        }

        private void ComboProtocols_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
