﻿#pragma checksum "..\..\UserControlListarCliente.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C16839CC5CC28658BDDA8182B7927971BF5A3D381385B4293C9514C8809BF01"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using OnBreak_MDT_V._2;
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


namespace OnBreak_MDT_V._2 {
    
    
    /// <summary>
    /// UserControlListarCliente
    /// </summary>
    public partial class UserControlListarCliente : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRutLcli;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboTipoEmpresa;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboTipoActividad;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush imgLogoTipo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgListaClienteLcli;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnImprimir;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnActualizar;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\UserControlListarCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
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
            System.Uri resourceLocater = new System.Uri("/OnBreak(MDT)V.2;component/usercontrollistarcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControlListarCliente.xaml"
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
            this.txtRutLcli = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cboTipoEmpresa = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cboTipoActividad = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.imgLogoTipo = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 5:
            this.dgListaClienteLcli = ((System.Windows.Controls.DataGrid)(target));
            
            #line 22 "..\..\UserControlListarCliente.xaml"
            this.dgListaClienteLcli.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgListaClienteLcli_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnImprimir = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\UserControlListarCliente.xaml"
            this.btnImprimir.Click += new System.Windows.RoutedEventHandler(this.btnImprimir_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnActualizar = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\UserControlListarCliente.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.btnActualizar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\UserControlListarCliente.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\UserControlListarCliente.xaml"
            this.btnBuscar.Click += new System.Windows.RoutedEventHandler(this.btnBuscar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

