﻿#pragma checksum "..\..\..\..\View\Win.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1AF3C726424554A7E6AD5464B24DE98884EE6B3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using _4InRow.View;


namespace _4InRow.View {
    
    
    /// <summary>
    /// Win
    /// </summary>
    public partial class Win : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 99 "..\..\..\..\View\Win.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border txbText;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\View\Win.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGOBack;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\View\Win.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\..\View\Win.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize_Copy;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\..\View\Win.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMaximize;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/4InRow;component/view/win.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Win.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 67 "..\..\..\..\View\Win.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RadioButton_home_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 76 "..\..\..\..\View\Win.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RadioButton_game_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 85 "..\..\..\..\View\Win.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RadioButton_exclamation_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txbText = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.btnGOBack = ((System.Windows.Controls.Button)(target));
            
            #line 120 "..\..\..\..\View\Win.xaml"
            this.btnGOBack.Click += new System.Windows.RoutedEventHandler(this.btnGOBack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\..\View\Win.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnMinimize_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 190 "..\..\..\..\View\Win.xaml"
            this.btnMinimize_Copy.Click += new System.Windows.RoutedEventHandler(this.btnMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnMaximize = ((System.Windows.Controls.Button)(target));
            
            #line 221 "..\..\..\..\View\Win.xaml"
            this.btnMaximize.Click += new System.Windows.RoutedEventHandler(this.btnMaximize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

