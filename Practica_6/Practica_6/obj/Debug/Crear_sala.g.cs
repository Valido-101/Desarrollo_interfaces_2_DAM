﻿#pragma checksum "..\..\Crear_sala.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB075DBC9BAC56625708BBBDF845111AF39BFC350745BCED09CBDAB4FE60E24A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica_6;
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


namespace Practica_6 {
    
    
    /// <summary>
    /// Crear_sala
    /// </summary>
    public partial class Crear_sala : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\Crear_sala.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_nombre_evento;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Crear_sala.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_fecha;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Crear_sala.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_hora;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Crear_sala.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_filas;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Crear_sala.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_columnas;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Crear_sala.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_crear;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Crear_sala.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_cartelEvento;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Crear_sala.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_elegirArchivo;
        
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
            System.Uri resourceLocater = new System.Uri("/Practica_6;component/crear_sala.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Crear_sala.xaml"
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
            
            #line 8 "..\..\Crear_sala.xaml"
            ((Practica_6.Crear_sala)(target)).Closed += new System.EventHandler(this.Window_Closed_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtbox_nombre_evento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtbox_fecha = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\Crear_sala.xaml"
            this.txtbox_fecha.GotFocus += new System.Windows.RoutedEventHandler(this.txtbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 13 "..\..\Crear_sala.xaml"
            this.txtbox_fecha.LostFocus += new System.Windows.RoutedEventHandler(this.txtbox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtbox_hora = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\Crear_sala.xaml"
            this.txtbox_hora.GotFocus += new System.Windows.RoutedEventHandler(this.txtbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 15 "..\..\Crear_sala.xaml"
            this.txtbox_hora.LostFocus += new System.Windows.RoutedEventHandler(this.txtbox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtbox_filas = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\Crear_sala.xaml"
            this.txtbox_filas.GotFocus += new System.Windows.RoutedEventHandler(this.txtbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 17 "..\..\Crear_sala.xaml"
            this.txtbox_filas.LostFocus += new System.Windows.RoutedEventHandler(this.txtbox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtbox_columnas = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\Crear_sala.xaml"
            this.txtbox_columnas.GotFocus += new System.Windows.RoutedEventHandler(this.txtbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 19 "..\..\Crear_sala.xaml"
            this.txtbox_columnas.LostFocus += new System.Windows.RoutedEventHandler(this.txtbox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_crear = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Crear_sala.xaml"
            this.btn_crear.Click += new System.Windows.RoutedEventHandler(this.btn_crear_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtbox_cartelEvento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btn_elegirArchivo = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Crear_sala.xaml"
            this.btn_elegirArchivo.Click += new System.Windows.RoutedEventHandler(this.btn_elegirArchivo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

