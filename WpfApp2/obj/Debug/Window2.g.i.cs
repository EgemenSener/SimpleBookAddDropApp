﻿#pragma checksum "..\..\Window2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F13B5C34C7A5182AAC83FEE871909640F382A12F5F276BB2DA01D8634B780621"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// Window2
    /// </summary>
    public partial class Window2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Adventure;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Classics;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Science_Fiction;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo_2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button book;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Confirm;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Window2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button next;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/window2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window2.xaml"
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
            
            #line 9 "..\..\Window2.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.combo_1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Adventure = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 18 "..\..\Window2.xaml"
            this.Adventure.Selected += new System.Windows.RoutedEventHandler(this.Adventure_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Classics = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 19 "..\..\Window2.xaml"
            this.Classics.Selected += new System.Windows.RoutedEventHandler(this.Classics_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Science_Fiction = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 20 "..\..\Window2.xaml"
            this.Science_Fiction.Selected += new System.Windows.RoutedEventHandler(this.Science_Fiction_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.combo_2 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.book = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Window2.xaml"
            this.book.Click += new System.Windows.RoutedEventHandler(this.book_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Confirm = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\Window2.xaml"
            this.Confirm.Checked += new System.Windows.RoutedEventHandler(this.Confirm_Checked);
            
            #line default
            #line hidden
            
            #line 26 "..\..\Window2.xaml"
            this.Confirm.Unchecked += new System.Windows.RoutedEventHandler(this.Confirm_Unchecked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.next = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Window2.xaml"
            this.next.Click += new System.Windows.RoutedEventHandler(this.next_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

