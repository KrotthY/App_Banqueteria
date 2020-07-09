using OnBreak.Negocio;
using System;
using System.Windows;
using System.Windows.Input;

namespace OnBreak_MDT_V._2
{
    /// <summary>
    /// Lógica de interacción para Opcional.xaml
    /// </summary>
    public partial class Opcional : Window
    {
        public Opcional()
        {
            InitializeComponent();
            CargarListaClienteDg();
        }

        // Cargar el dataGrid
        private void CargarListaClienteDg()
        {
            dgListarCliente.ItemsSource = new Cliente().ReadAll();

        }


        // get y set de clase instancia global
        public Cliente cli { get; private set; }


        //  metodo para poder extrar una fila desde el data grid
        public void dgListarCliente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Cliente cliente = dgListarCliente.SelectedItem as Cliente;
            if (cliente != null)
            {
                this.cli = cliente;
                reference.cliGlobal = cli;
            }

            reference.MostrarDatosCliente();

            this.Close();

        }


        // Cierra y refencia la informacion de la ventana
        private void Window_Closed(object sender, EventArgs e)
        {
            reference.MostrarDatosCliente();
            Close();
        }


        // referencia 
        UserControlCrearCliente reference;

        // realizar conexcion
        internal void SetUserControl(UserControlCrearCliente win)
        {
            this.reference = win;
        }
    }



}