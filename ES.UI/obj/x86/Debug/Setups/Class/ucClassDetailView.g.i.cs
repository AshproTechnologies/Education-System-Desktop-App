﻿#pragma checksum "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6F380090E8A8AF04AC24E782DD336BAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ES.UI;
using ExtendedGrid.ExtendedColumn;
using ExtendedGrid.ExtendedGridControl;
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


namespace ES.UI.Setups {
    
    
    /// <summary>
    /// ucClassDetailView
    /// </summary>
    public partial class ucClassDetailView : ES.UI.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ES.UI.Setups.ucClassDetailView ClassDetailUserControl;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid gvClassSubjectListed;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSelectedSignleSubject;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveSelectedSingleSubject;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddAllSubject;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemoveAllSubject;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid gvClassSubjectSelected;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClassSave;
        
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
            System.Uri resourceLocater = new System.Uri("/ES.UI;component/setups/class/ucclassdetailview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.ClassDetailUserControl = ((ES.UI.Setups.ucClassDetailView)(target));
            return;
            case 2:
            this.gvClassSubjectListed = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            return;
            case 3:
            this.btnAddSelectedSignleSubject = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
            this.btnAddSelectedSignleSubject.Click += new System.Windows.RoutedEventHandler(this.btnAddSelectedSignleSubject_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRemoveSelectedSingleSubject = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
            this.btnRemoveSelectedSingleSubject.Click += new System.Windows.RoutedEventHandler(this.btnRemoveSelectedSingleSubject_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAddAllSubject = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
            this.btnAddAllSubject.Click += new System.Windows.RoutedEventHandler(this.btnAddAllSubject_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRemoveAllSubject = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
            this.btnRemoveAllSubject.Click += new System.Windows.RoutedEventHandler(this.btnRemoveAllSubject_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.gvClassSubjectSelected = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            return;
            case 8:
            this.btnClassSave = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\..\..\Setups\Class\ucClassDetailView.xaml"
            this.btnClassSave.Click += new System.Windows.RoutedEventHandler(this.btnClassSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

