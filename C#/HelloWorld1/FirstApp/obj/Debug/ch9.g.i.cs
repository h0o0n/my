﻿#pragma checksum "..\..\ch9.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7EAC7EC772D490520872001AD72BE7CD8E516832AAE4339668B307CB8853AB01"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstApp;
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


namespace FirstApp {
    
    
    /// <summary>
    /// ch9
    /// </summary>
    public partial class ch9 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ch9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ch9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb2;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ch9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb3;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ch9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txt;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ch9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb4;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ch9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAll;
        
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
            System.Uri resourceLocater = new System.Uri("/FirstApp;component/ch9.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ch9.xaml"
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
            this.cb1 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.cb2 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.cb3 = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\ch9.xaml"
            this.cb3.Checked += new System.Windows.RoutedEventHandler(this.Ch3_Checked);
            
            #line default
            #line hidden
            
            #line 12 "..\..\ch9.xaml"
            this.cb3.Unchecked += new System.Windows.RoutedEventHandler(this.Ch3_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.cb4 = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.cbAll = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\ch9.xaml"
            this.cbAll.Checked += new System.Windows.RoutedEventHandler(this.chAll_Checked);
            
            #line default
            #line hidden
            
            #line 27 "..\..\ch9.xaml"
            this.cbAll.Unchecked += new System.Windows.RoutedEventHandler(this.chAll_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

