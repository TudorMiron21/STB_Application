﻿#pragma checksum "..\..\CentralWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8D1EE4482076FC6AC29D41924F1AA7F111968FD21CEE8C97A55D45BC10AE98E7"
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
    /// CentralWindow
    /// </summary>
    public partial class CentralWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BorderImg;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuyTicket;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuySubscription;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TicketHistory;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubscriptionHistory;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MyProfile;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertCardData;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewRoutes;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimize;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\CentralWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;
        
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
            System.Uri resourceLocater = new System.Uri("/STB_App;component/centralwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CentralWindow.xaml"
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
            
            #line 12 "..\..\CentralWindow.xaml"
            ((STB_App.CentralWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BorderImg = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.BuyTicket = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\CentralWindow.xaml"
            this.BuyTicket.Click += new System.Windows.RoutedEventHandler(this.buy_ticket_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BuySubscription = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\CentralWindow.xaml"
            this.BuySubscription.Click += new System.Windows.RoutedEventHandler(this.buy_subscription_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TicketHistory = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\CentralWindow.xaml"
            this.TicketHistory.Click += new System.Windows.RoutedEventHandler(this.ticket_history_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SubscriptionHistory = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\CentralWindow.xaml"
            this.SubscriptionHistory.Click += new System.Windows.RoutedEventHandler(this.subscription_history_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MyProfile = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\CentralWindow.xaml"
            this.MyProfile.Click += new System.Windows.RoutedEventHandler(this.my_profile_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.InsertCardData = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\CentralWindow.xaml"
            this.InsertCardData.Click += new System.Windows.RoutedEventHandler(this.insert_card_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ViewRoutes = ((System.Windows.Controls.Button)(target));
            
            #line 139 "..\..\CentralWindow.xaml"
            this.ViewRoutes.Click += new System.Windows.RoutedEventHandler(this.view_routes_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.minimize = ((System.Windows.Controls.Button)(target));
            
            #line 160 "..\..\CentralWindow.xaml"
            this.minimize.Click += new System.Windows.RoutedEventHandler(this.minimize_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.close = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\CentralWindow.xaml"
            this.close.Click += new System.Windows.RoutedEventHandler(this.close_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

