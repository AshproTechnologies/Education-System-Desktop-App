﻿#pragma checksum "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "021890CBC94B4C392546952B200F0987"
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
    /// ucStudentAttendanceDetailView
    /// </summary>
    public partial class ucStudentAttendanceDetailView : ES.UI.BaseUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ES.UI.Setups.ucStudentAttendanceDetailView CustomeUserControl;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker radDatePicker;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAttendanceView;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAttendanceMark;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ExtendedGrid.ExtendedGridControl.ExtendedDataGrid gvMarkClassAttendanceView;
        
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
            System.Uri resourceLocater = new System.Uri("/ES.UI;component/setups/attendance/ucstudentattendancedetailview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
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
            this.CustomeUserControl = ((ES.UI.Setups.ucStudentAttendanceDetailView)(target));
            return;
            case 2:
            this.radDatePicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 36 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
            this.radDatePicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.radDatePicker_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 48 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxClass_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 61 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxStudent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAttendanceView = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
            this.btnAttendanceView.Click += new System.Windows.RoutedEventHandler(this.btnAttendanceView_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAttendanceMark = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\..\Setups\Attendance\ucStudentAttendanceDetailView.xaml"
            this.btnAttendanceMark.Click += new System.Windows.RoutedEventHandler(this.btnAttendanceMark_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.gvMarkClassAttendanceView = ((ExtendedGrid.ExtendedGridControl.ExtendedDataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

