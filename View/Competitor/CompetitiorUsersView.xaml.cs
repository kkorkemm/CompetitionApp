using System.Windows.Controls;

namespace CompetitionApp.View.Competitor
{
    using Pages.CompetitiorPages;

    /// <summary>
    /// Логика взаимодействия для CompetitiorUsersView.xaml
    /// </summary>
    public partial class CompetitiorUsersView : UserControl
    {
        public CompetitiorUsersView()
        {
            InitializeComponent();
            UsersFrame.Navigate(new CompetitorUsersPage());
            Navigation.SubFrame = UsersFrame;
        }
    }
}
