using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CompetitionApp.Pages.CompetitiorPages
{
    using Base;
  
    /// <summary>
    /// Логика взаимодействия для CompetitorProtocolsPage.xaml
    /// </summary>
    public partial class CompetitorProtocolsPage : Page
    {
        public CompetitorProtocolsPage()
        {
            InitializeComponent();

            string dayName = Helper.WhatDay();
            TextTitle.Text = $"Протоколы на сегодняшний день ({dayName})";

            DGridProtocols.ItemsSource = CompetitionDBEntities.GetContext().ProtocolAndUser.Where(p => p.UserID == CompetitionDBEntities.currentUser.ID && p.Protocols.Day.DayName == dayName).ToList();
        }

        private void BtnView_Click(object sender, RoutedEventArgs e)
        {
            Navigation.SubFrame.Navigate(new CompetitorProtocolInfoPage((sender as Button).DataContext as ProtocolAndUser));
        }

        private void DGridProtocols_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = $" {e.Row.GetIndex() + 1} ";
        }
    }
}
