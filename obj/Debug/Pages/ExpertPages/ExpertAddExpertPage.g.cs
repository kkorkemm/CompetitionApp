﻿#pragma checksum "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE7FD47086195927386CFAF10133007F609F7D601BA4FEBAE497493620FC43EE"
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
using System.Windows.Forms.Integration;
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
    /// ExpertAddExpertPage
    /// </summary>
    public partial class ExpertAddExpertPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextTitle;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboGender;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboCompetitor;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboRegion;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/CompetitionApp;component/pages/expertpages/expertaddexpertpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
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
            this.TextTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ComboGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ComboCompetitor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ComboRegion = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\..\Pages\ExpertPages\ExpertAddExpertPage.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

