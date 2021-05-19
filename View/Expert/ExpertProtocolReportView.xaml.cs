using System.Windows.Controls;

namespace CompetitionApp.View.Expert
{
    using Pages.ExpertPages;

    /// <summary>
    /// Логика взаимодействия для ExpertProtocolReportView.xaml
    /// </summary>
    public partial class ExpertProtocolReportView : UserControl
    {
        public ExpertProtocolReportView()
        {
            InitializeComponent();
            ProtocolReportFrame.Navigate(new ExpertProtocolReportPage());
            Navigation.SubFrame = ProtocolReportFrame;
        }
    }
}
