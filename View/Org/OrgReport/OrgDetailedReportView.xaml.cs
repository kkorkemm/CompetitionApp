using System.Windows.Controls;

namespace CompetitionApp.View.Org.OrgReport
{
    using Pages.OrgPages;

    /// <summary>
    /// Логика взаимодействия для OrgDetailedReportView.xaml
    /// </summary>
    public partial class OrgDetailedReportView : UserControl
    {
        public OrgDetailedReportView()
        {
            InitializeComponent();
            DetailedReportFrame.Navigate(new OrgDetailedReportPage());
            Navigation.SubFrame = DetailedReportFrame;
        }
    }
}
