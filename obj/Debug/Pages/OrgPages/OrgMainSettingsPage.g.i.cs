﻿#pragma checksum "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D9E67002FE3FA9AF6621B9B8761AE29DD229608690957A182DBDFFC7097BB5B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CompetitionApp.Pages.OrgPages;
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


namespace CompetitionApp.Pages.OrgPages {
    
    
    /// <summary>
    /// OrgMainSettingsPage
    /// </summary>
    public partial class OrgMainSettingsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageLogo;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogo;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckChief;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckDeputyExpert;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/CompetitionApp;component/pages/orgpages/orgmainsettingspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml"
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
            this.ImageLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.BtnLogo = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml"
            this.BtnLogo.Click += new System.Windows.RoutedEventHandler(this.BtnLogo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CheckChief = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.CheckDeputyExpert = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\Pages\OrgPages\OrgMainSettingsPage.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

