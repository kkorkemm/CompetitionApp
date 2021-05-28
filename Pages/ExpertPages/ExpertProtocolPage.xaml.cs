using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace CompetitionApp.Pages.ExpertPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для ExpertProtocolPage.xaml
    /// </summary>
    public partial class ExpertProtocolPage : Page
    {
        public ExpertProtocolPage()
        {
            InitializeComponent();

            ListProtocols.ItemsSource = CompetitionDBEntities.GetContext().Protocols.Where(p => p.Day.CompetitionID == CompetitionDBEntities.currentCompettion.ID).ToList();

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ListProtocols.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Day.DayName");
            PropertyGroupDescription groupDescription2 = new PropertyGroupDescription("UserRole.RoleName");
            view.GroupDescriptions.Add(groupDescription);
            view.GroupDescriptions.Add(groupDescription2);
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new ExpertProtocolReportPage());
        }

        private void ListProtocols_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem item = ItemsControl.ContainerFromElement(ListProtocols, e.OriginalSource as DependencyObject) as ListBoxItem;

            if (item != null)
            {
                Navigation.SubFrame.Navigate(new ExpertProtocolFormPage(item.DataContext as Protocols));
            }
        }
    }
}
