﻿#pragma checksum "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDDAA646632FB0AD0CB20343E83C0A323F85BED7441587BC9E81BD02177D3B96"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CompetitionApp.Pages.ExpertPages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CompetitionApp.Pages.ExpertPages {
    
    
    /// <summary>
    /// ExpertProtocolReportPage
    /// </summary>
    public partial class ExpertProtocolReportPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboProtocols;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGridUsers;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextCount;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextPin;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CompetitionApp;component/pages/expertpages/expertprotocolreportpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ComboProtocols = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml"
            this.ComboProtocols.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboProtocols_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGridUsers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.TextCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TextPin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\Pages\ExpertPages\ExpertProtocolReportPage.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

