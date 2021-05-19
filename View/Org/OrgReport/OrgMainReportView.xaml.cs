using System.Windows.Controls;

namespace CompetitionApp.View.Org.OrgReport
{
    using Pages.OrgPages;

    /// <summary>
    /// Логика взаимодействия для OrgMainReportView.xaml
    /// </summary>
    public partial class OrgMainReportView : UserControl
    {
        public OrgMainReportView()
        {
            InitializeComponent();
            ReportFrame.Navigate(new OrgMainReportPage());
            Navigation.SubFrame = ReportFrame;
        }
    }
}
