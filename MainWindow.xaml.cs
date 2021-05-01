using System.Windows;

namespace CompetitionApp
{
    using Pages;

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new LoginPage());
            Navigation.MainFrame = mainFrame;
        }
    }
}
