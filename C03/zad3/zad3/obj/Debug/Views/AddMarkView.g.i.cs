﻿#pragma checksum "..\..\..\Views\AddMarkView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7DB2E25E6232E27B13AFFE41C7FEE215"
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
using zad3.Views;


namespace zad3.Views {
    
    
    /// <summary>
    /// AddMarkMenu
    /// </summary>
    public partial class AddMarkMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\AddMarkView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gAddMark;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\AddMarkView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbStudent;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\AddMarkView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStudent;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\AddMarkView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbCourse;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\AddMarkView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCourse;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\AddMarkView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbValue;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\AddMarkView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbValue;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\AddMarkView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn;
        
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
            System.Uri resourceLocater = new System.Uri("/zad3;component/views/addmarkview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddMarkView.xaml"
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
            this.gAddMark = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.lbStudent = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.cbStudent = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.lbCourse = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.cbCourse = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.lbValue = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cbValue = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\AddMarkView.xaml"
            this.btn.Click += new System.Windows.RoutedEventHandler(this.btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

