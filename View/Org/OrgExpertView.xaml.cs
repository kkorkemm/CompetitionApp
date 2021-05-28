using System.Windows.Controls;

namespace CompetitionApp.View.Org
{
    using Pages.OrgPages;

    /// <summary>
    /// Логика взаимодействия для OrgExpertView.xaml
    /// </summary>
    public partial class OrgExpertView : UserControl
    {
        public OrgExpertView()
        {
            InitializeComponent();
            ExpertFrame.Navigate(new OrgMainExpertsPage());
        }
    }
}
