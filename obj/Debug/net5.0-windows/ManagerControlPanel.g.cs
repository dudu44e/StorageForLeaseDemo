﻿#pragma checksum "..\..\..\ManagerControlPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3E2B5CEA006ECAD831E06EBA9A9976DF3FE0B2C6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StorageForLease;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace StorageForLease {
    
    
    /// <summary>
    /// ManagerControlPanel
    /// </summary>
    public partial class ManagerControlPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 71 "..\..\..\ManagerControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchByCustomerId;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\ManagerControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowSummary;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\ManagerControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserManagementWindow;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\ManagerControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid general_info;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\..\ManagerControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchOrderByUserId;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\..\ManagerControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchOrderByProductId;
        
        #line default
        #line hidden
        
        
        #line 240 "..\..\..\ManagerControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrderManagementWindow;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/StorageForLease;component/managercontrolpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ManagerControlPanel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 17 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_All_customer);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 45 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Search_Customer_By_ID);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchByCustomerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ShowSummary = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\ManagerControlPanel.xaml"
            this.ShowSummary.Click += new System.Windows.RoutedEventHandler(this.ShowSummary_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UserManagementWindow = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.general_info = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            
            #line 154 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Show_All_Orders);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 181 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Search_Order_By_UserId);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SearchOrderByUserId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 210 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Search_Order_By_ProductID);
            
            #line default
            #line hidden
            return;
            case 13:
            this.SearchOrderByProductId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.OrderManagementWindow = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 128 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_User);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 129 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_User);
            
            #line default
            #line hidden
            break;
            case 15:
            
            #line 262 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Order);
            
            #line default
            #line hidden
            break;
            case 16:
            
            #line 263 "..\..\..\ManagerControlPanel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Update_Order);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

