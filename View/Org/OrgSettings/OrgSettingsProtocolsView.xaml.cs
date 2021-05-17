using System.Windows.Controls;

namespace CompetitionApp.View.Org.OrgSettings
{
    using Pages.OrgPages;

    /// <summary>
    /// Логика взаимодействия для OrgSettingsProtocolsView.xaml
    /// </summary>
    public partial class OrgSettingsProtocolsView : UserControl
    {
        public OrgSettingsProtocolsView()
        {
            InitializeComponent();
            ProtocolsFrame.Navigate(new OrgProtocolsSettingsPage());
            Navigation.SubFrame = ProtocolsFrame;
        }
    }
}
