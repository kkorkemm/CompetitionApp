using System.Windows.Controls;

namespace CompetitionApp.View.Expert
{
    using Pages.ExpertPages;

    /// <summary>
    /// Логика взаимодействия для ExpertProtocolsView.xaml
    /// </summary>
    public partial class ExpertProtocolsView : UserControl
    {
        public ExpertProtocolsView()
        {
            InitializeComponent();
            ProtocolFrame.Navigate(new ExpertProtocolPage());
            Navigation.SubFrame = ProtocolFrame;
        }
    }
}
