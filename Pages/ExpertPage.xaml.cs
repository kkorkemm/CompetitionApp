using System;
using System.Linq;
using System.Windows.Controls;

namespace CompetitionApp.Pages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для ExpertPage.xaml
    /// </summary>
    public partial class ExpertPage : Page
    {
        public ExpertPage()
        {
            InitializeComponent();

            TextHello.Text = Helper.WhatTimeOfDay();
            TextHello.Text += "\n" + CompetitionDBEntities.currentUser.FullName;

            TextDay.Text = $"День {Helper.WhatDay()}";
        }
    }
}
