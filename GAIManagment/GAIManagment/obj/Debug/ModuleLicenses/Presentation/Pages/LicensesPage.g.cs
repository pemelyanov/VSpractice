﻿#pragma checksum "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F0CAD62AECDE1B088B71DB41F83CAD21B513BE514307AF3268E0EC9D10CC432C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GAIManagment.ModuleLicenses.Presentation.Pages;
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


namespace GAIManagment.ModuleLicenses.Presentation.Pages {
    
    
    /// <summary>
    /// LicensesPage
    /// </summary>
    public partial class LicensesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvLicenses;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeStatus;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHistory;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrint;
        
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
            System.Uri resourceLocater = new System.Uri("/GAIManagment;component/modulelicenses/presentation/pages/licensespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
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
            
            #line 10 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
            ((GAIManagment.ModuleLicenses.Presentation.Pages.LicensesPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 21 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvLicenses = ((System.Windows.Controls.ListView)(target));
            
            #line 26 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
            this.lvLicenses.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvLicenses_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnReg_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnChangeStatus = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
            this.btnChangeStatus.Click += new System.Windows.RoutedEventHandler(this.btnChangeStatus_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnHistory = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
            this.btnHistory.Click += new System.Windows.RoutedEventHandler(this.btnHistory_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnPrint = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
            this.btnPrint.Click += new System.Windows.RoutedEventHandler(this.btnPrint_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 4:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 51 "..\..\..\..\..\ModuleLicenses\Presentation\Pages\LicensesPage.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ListView_MouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

