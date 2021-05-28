using System.Windows.Controls;

namespace CompetitionApp.View.Competitor
{
    using Pages.CompetitiorPages;

    /// <summary>
    /// Логика взаимодействия для CompetitorProtocolsView.xaml
    /// </summary>
    public partial class CompetitorProtocolsView : UserControl
    {
        public CompetitorProtocolsView()
        {
            InitializeComponent();
            ProtocolsFrame.Navigate(new CompetitorProtocolsPage());
            Navigation.SubFrame = ProtocolsFrame;
        }
    }
}
