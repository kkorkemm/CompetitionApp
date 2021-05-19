using System.Windows.Controls;

namespace CompetitionApp.View.Expert
{
    using Pages.ExpertPages;

    /// <summary>
    /// Логика взаимодействия для ExpertProtocolFormView.xaml
    /// </summary>
    public partial class ExpertProtocolFormView : UserControl
    {
        public ExpertProtocolFormView()
        {
            InitializeComponent();
            ProtocolFormFrame.Navigate(new ExpertProtocolFormPage());
            Navigation.SubFrame = ProtocolFormFrame;
        }
    }
}
