using System.Windows.Controls;

namespace CompetitionApp.View.Expert
{
    using Pages.ExpertPages;

    /// <summary>
    /// Логика взаимодействия для ExpertUsersView.xaml
    /// </summary>
    public partial class ExpertUsersView : UserControl
    {
        public ExpertUsersView()
        {
            InitializeComponent();
            ExpertUserFrame.Navigate(new ExpertUsersPage());
            Navigation.SubFrame = ExpertUserFrame;
        }
    }
}
