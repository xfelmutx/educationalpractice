﻿#pragma checksum "..\..\..\Pages\ClientPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "992F31598E72B0D331511FF191430648D5BEDB86F7DA3A95A17EDAA5BE3ADBF0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfUPractika.Pages;


namespace WpfUPractika.Pages {
    
    
    /// <summary>
    /// ClientPage
    /// </summary>
    public partial class ClientPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textFirstName;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboGender;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioA;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioYA;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listClient;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addButton;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Pages\ClientPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfUPractika;component/pages/clientpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ClientPage.xaml"
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
            this.textFirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\Pages\ClientPage.xaml"
            this.textFirstName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textFirstName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboGender = ((System.Windows.Controls.ComboBox)(target));
            
            #line 62 "..\..\..\Pages\ClientPage.xaml"
            this.comboGender.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboGender_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.radioA = ((System.Windows.Controls.RadioButton)(target));
            
            #line 68 "..\..\..\Pages\ClientPage.xaml"
            this.radioA.Checked += new System.Windows.RoutedEventHandler(this.radioA_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.radioYA = ((System.Windows.Controls.RadioButton)(target));
            
            #line 75 "..\..\..\Pages\ClientPage.xaml"
            this.radioYA.Checked += new System.Windows.RoutedEventHandler(this.radioA_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.listClient = ((System.Windows.Controls.ListView)(target));
            
            #line 85 "..\..\..\Pages\ClientPage.xaml"
            this.listClient.Loaded += new System.Windows.RoutedEventHandler(this.listClient_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addButton = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\..\Pages\ClientPage.xaml"
            this.addButton.Click += new System.Windows.RoutedEventHandler(this.addButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 141 "..\..\..\Pages\ClientPage.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\..\Pages\ClientPage.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

