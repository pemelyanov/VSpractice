﻿#pragma checksum "..\..\..\..\..\ModuleLicenses\Presentation\Windows\ChangeStatusWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FE9847541569F71D21C0E2BE640FA0ADD84409D134FCFD5A90F303CAFAC93FD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GAIManagment.ModuleLicenses.Presentation.Windows;
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


namespace GAIManagment.ModuleLicenses.Presentation.Windows {
    
    
    /// <summary>
    /// ChangeStatusWindow
    /// </summary>
    public partial class ChangeStatusWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\ModuleLicenses\Presentation\Windows\ChangeStatusWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStatuses;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\ModuleLicenses\Presentation\Windows\ChangeStatusWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescription;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\ModuleLicenses\Presentation\Windows\ChangeStatusWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChange;
        
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
            System.Uri resourceLocater = new System.Uri("/GAIManagment;component/modulelicenses/presentation/windows/changestatuswindow.xa" +
                    "ml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ModuleLicenses\Presentation\Windows\ChangeStatusWindow.xaml"
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
            
            #line 10 "..\..\..\..\..\ModuleLicenses\Presentation\Windows\ChangeStatusWindow.xaml"
            ((GAIManagment.ModuleLicenses.Presentation.Windows.ChangeStatusWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbStatuses = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.tbDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnChange = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\..\ModuleLicenses\Presentation\Windows\ChangeStatusWindow.xaml"
            this.btnChange.Click += new System.Windows.RoutedEventHandler(this.btnChange_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

