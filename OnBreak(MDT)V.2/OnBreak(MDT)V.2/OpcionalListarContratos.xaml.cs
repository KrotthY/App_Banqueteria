using OnBreak.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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

        //funciona correctamente
        private void CargarListaClienteDg()
        {
            dgListaContratos.ItemsSource = new Contrato().ReadAll();

        }
        public Contrato contra { get; private set; }
        // Funciona correctamente el metodo para poder extrar una fila desde el data grid
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
        private void Window_Closed(object sender, EventArgs e)
        {
            reference.MostrarDatosContrato();
            Close();
        }

        UserControlAgregarContratos reference;

        internal void SetUserControl(UserControlAgregarContratos win)
        {
            this.reference = win;
        }


    }
}
