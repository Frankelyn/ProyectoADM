#pragma checksum "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A0FDF3EE79A2EF775DB0F0C5309995AD85985946"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CondominioADM.UI.Consultas;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace CondominioADM.UI.Consultas {
    
    
    /// <summary>
    /// cArriendaParqueos
    /// </summary>
    public partial class cArriendaParqueos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Desde_DataPicker;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filtro_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Hasta_DatePicker;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Criterio_TextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buscar_Button;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DatosDataGrid;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConteoTextbox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AgregarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CondominioADM;component/ui/consultas/carriendaparqueos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Desde_DataPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.Filtro_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Hasta_DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.Criterio_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Buscar_Button = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
            this.Buscar_Button.Click += new System.Windows.RoutedEventHandler(this.Buscar_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DatosDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.ConteoTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.AgregarButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\..\..\UI\Consultas\cArriendaParqueos.xaml"
            this.AgregarButton.Click += new System.Windows.RoutedEventHandler(this.AgregarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

