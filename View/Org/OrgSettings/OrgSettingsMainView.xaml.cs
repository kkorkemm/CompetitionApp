﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
