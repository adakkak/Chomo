﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0340D7874E07A4F9BEAED972A266F564"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
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


namespace Chomo {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox entSource;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btnDestination;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox entDestination;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btnSource;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btnConvert;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Chomo;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.entSource = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnDestination = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\Window1.xaml"
            this.btnDestination.Click += new System.Windows.RoutedEventHandler(this.btnDestination_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.entDestination = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnSource = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Window1.xaml"
            this.btnSource.Click += new System.Windows.RoutedEventHandler(this.btnSource_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btnConvert = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Window1.xaml"
            this.btnConvert.Click += new System.Windows.RoutedEventHandler(this.btnConvert_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Window1.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
