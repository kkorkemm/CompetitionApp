using System.Windows.Controls;

namespace CompetitionApp.View.Org.OrgSettings
{
    using Pages.OrgPages;
    /// <summary>
    /// Логика взаимодействия для OrgSettingsMainView.xaml
    /// </summary>
    public partial class OrgSettingsMainView : UserControl
    {
        public OrgSettingsMainView()
        {
            InitializeComponent();
            MainSettingsFrame.Navigate(new OrgMainSettingsPage());
        }
    }
}
