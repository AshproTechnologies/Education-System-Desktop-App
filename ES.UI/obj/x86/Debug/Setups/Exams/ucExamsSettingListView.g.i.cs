﻿#pragma checksum "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "546129C713AEE5A3E0A273CF74384C80"
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
    /// ucExamsSettingListView
    /// </summary>
    public partial class ucExamsSettingListView : ES.UI.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ES.UI.Setups.ucExamsSettingListView CustomUserControl;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ShellHeader;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveExams;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid gvExamsSettingListView;
        
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
            System.Uri resourceLocater = new System.Uri("/ES.UI;component/setups/exams/ucexamssettinglistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml"
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
            this.CustomUserControl = ((ES.UI.Setups.ucExamsSettingListView)(target));
            return;
            case 2:
            this.ShellHeader = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.btnSaveExams = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml"
            this.btnSaveExams.Click += new System.Windows.RoutedEventHandler(this.btnSaveExams_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gvExamsSettingListView = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            return;
            case 5:
            
            #line 68 "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCMEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 73 "..\..\..\..\..\Setups\Exams\ucExamsSettingListView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCMDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

