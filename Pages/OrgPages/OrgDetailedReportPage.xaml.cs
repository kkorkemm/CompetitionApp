using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgDetailedReportPage.xaml
    /// </summary>
    public partial class OrgDetailedReportPage : Page
    {
        public OrgDetailedReportPage()
        {
            InitializeComponent();

            ComboSkills.ItemsSource = CompetitionDBEntities.GetContext().Skill.ToList();
            ComboSkills.SelectedIndex = 0;

            UpdateProtocols();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListProtocols.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Day.DayName");
            view.GroupDescriptions.Add(groupDescription);
        }

        void UpdateProtocols()
        {
            var protocols = CompetitionDBEntities.GetContext().Protocols.Where(p => p.Day.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();

            ListProtocols.ItemsSource = protocols;
        }

        private void ComboSkills_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProtocols();
        }
    }
}
