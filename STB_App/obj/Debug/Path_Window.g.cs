﻿#pragma checksum "..\..\Path_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5AE0C53BE47E8054C93D3B869C4AEA69F8EB188791BD92D05C4CF1F1198976C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using STB_App;
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


namespace STB_App {
    
    
    /// <summary>
    /// Path_Window
    /// </summary>
    public partial class Path_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Path_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderImg;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Path_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox path;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Path_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimize;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Path_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Path_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Inapoi;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\Path_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
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
            System.Uri resourceLocater = new System.Uri("/STB_App;component/path_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Path_Window.xaml"
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
            
            #line 12 "..\..\Path_Window.xaml"
            ((STB_App.Path_Window)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BorderImg = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.path = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.minimize = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Path_Window.xaml"
            this.minimize.Click += new System.Windows.RoutedEventHandler(this.minimize_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.close = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\Path_Window.xaml"
            this.close.Click += new System.Windows.RoutedEventHandler(this.close_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Inapoi = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\Path_Window.xaml"
            this.Inapoi.Click += new System.Windows.RoutedEventHandler(this.previous_Click);
            
            #line default
            #line hidden
            
            #line 75 "..\..\Path_Window.xaml"
            this.Inapoi.MouseEnter += new System.Windows.Input.MouseEventHandler(this.previous_MouseEnter);
            
            #line default
            #line hidden
            
            #line 75 "..\..\Path_Window.xaml"
            this.Inapoi.MouseLeave += new System.Windows.Input.MouseEventHandler(this.previous_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.save = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\Path_Window.xaml"
            this.save.Click += new System.Windows.RoutedEventHandler(this.save_Click);
            
            #line default
            #line hidden
            
            #line 92 "..\..\Path_Window.xaml"
            this.save.MouseEnter += new System.Windows.Input.MouseEventHandler(this.save_MouseEnter);
            
            #line default
            #line hidden
            
            #line 92 "..\..\Path_Window.xaml"
            this.save.MouseLeave += new System.Windows.Input.MouseEventHandler(this.save_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

