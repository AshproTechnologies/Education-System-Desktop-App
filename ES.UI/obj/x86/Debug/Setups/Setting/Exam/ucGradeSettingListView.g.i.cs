﻿#pragma checksum "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8F054B4470E54F3739F9657CFA761438"
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


namespace ES.UI.Setups {
    
    
    /// <summary>
    /// ucGradeSettingListView
    /// </summary>
    public partial class ucGradeSettingListView : ES.UI.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ES.UI.Setups.ucGradeSettingListView CustomUserControl;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddGrade;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveGrade;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid gvGradeSettingListView;
        
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
            System.Uri resourceLocater = new System.Uri("/ES.UI;component/setups/setting/exam/ucgradesettinglistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml"
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
            this.CustomUserControl = ((ES.UI.Setups.ucGradeSettingListView)(target));
            return;
            case 2:
            this.btnAddGrade = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml"
            this.btnAddGrade.Click += new System.Windows.RoutedEventHandler(this.btnAddGrade_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSaveGrade = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml"
            this.btnSaveGrade.Click += new System.Windows.RoutedEventHandler(this.btnSaveGrade_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gvGradeSettingListView = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            return;
            case 5:
            
            #line 72 "..\..\..\..\..\..\Setups\Setting\Exam\ucGradeSettingListView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCMDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

