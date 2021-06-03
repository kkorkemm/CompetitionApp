using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms.DataVisualization.Charting;

namespace CompetitionApp.Pages.OrgPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для OrgMainReportPage.xaml
    /// </summary>
    public partial class OrgMainReportPage : Page
    {
        public OrgMainReportPage()
        {
            InitializeComponent();

            DayChart.ChartAreas.Add(new ChartArea("Main"));

            var currentSeries = new Series("Protocols")
            {
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Column
            };
            DayChart.Series.Add(currentSeries);

            var days = CompetitionDBEntities.GetContext().Day.Where(p => p.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();
            ComboDays.ItemsSource = days;
            ComboDays.SelectedIndex = 0;
        }

        private void ComboDays_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Series currentSeries = DayChart.Series.FirstOrDefault();
            currentSeries.Points.Clear();

            var day = ComboDays.SelectedItem as Day;

            var skills = CompetitionDBEntities.GetContext().Skill.ToList();

            foreach (var skill in skills)
            {
                //currentSeries.Points.AddXY(skill.SkillName, CompetitionDBEntities.GetContext().ProtocolFinished.Where(p => p.SkillID == skill.ID && p.Protocols.Day == day));
            }

        }
    }
}
