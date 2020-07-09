using OnBreak.Negocio;
using System;
using System.Windows;
using System.Windows.Input;

namespace OnBreak_MDT_V._2
{
    /// <summary>
    /// Lógica de interacción para OpcionalListarContratos.xaml
    /// </summary>
    public partial class OpcionalListarContratos : Window
    {
        public OpcionalListarContratos()
        {
            InitializeComponent();
            CargarListaClienteDg();
        }

        //Carga el datagrid
        private void CargarListaClienteDg()
        {
            dgListaContratos.ItemsSource = new Contrato().ReadAll();

        }


        // get y set clase global
        public Contrato contra { get; private set; }


        //metodo para poder extrar una fila desde el data grid
        private void dgListaContratos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Contrato contrato = dgListaContratos.SelectedItem as Contrato;
            if (contrato != null)
            {
                this.contra = contrato;
                reference.contraGlobal = contra;
            }

            reference.MostrarDatosContrato();

            this.Close();
        }

        // cerrar venta y referenciar datos
        private void Window_Closed(object sender, EventArgs e)
        {
            reference.MostrarDatosContrato();
            Close();
        }


        //referencia
        UserControlAgregarContratos reference;

        // realizar conexcion con otra vista
        internal void SetUserControl(UserControlAgregarContratos win)
        {
            this.reference = win;
        }


    }
}
