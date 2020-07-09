using OnBreak.Negocio;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace OnBreak_MDT_V._2
{
    /// <summary>
    /// Lógica de interacción para UserControlListarContratos.xaml
    /// </summary>
    public partial class UserControlListarContratos : UserControl
    {
        public UserControlListarContratos()
        {
            InitializeComponent();
            LimpiarListarContrato();
        }

        // limpiar vista de usuario y controles
        private void LimpiarListarContrato()
        {

            CargarTipoEvento();
            CargarDataGridListContrato();

        }

        // cargar datagrid
        private void CargarDataGridListContrato()

        {
            dgListaContratoLc.ItemsSource = new Contrato().ReadAll();

        }


        //carga combobox tipo evento
        private void CargarTipoEvento()
        {

            cboTipoEvento.ItemsSource = new TipoEvento().ReadAll();
            cboTipoEvento.DisplayMemberPath = "Descripcion";
            cboTipoEvento.SelectedValuePath = "IdTipoEvento";
            cboTipoEvento.SelectedIndex = 0;


        }


        //Funciona correctamente, solo emite un mensaje
        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Debe conectarse a una impresora", "Atencion", MessageBoxButton.OK, MessageBoxImage.Error);
            LimpiarListarContrato();
        }



        //Elimina un cliente a seleccion del usuario 

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Contrato contrato = new Contrato()
            {
                Numero = MyGlobalContrato._numero
            };

            if (txtNroContrato.Text != "")
            {
                contrato.Numero = txtNroContrato.Text;
            }


            if (contrato.Read())
            {
                if (contrato.Delete())
                {
                    MessageBox.Show("Contrato fue Borrado correctamente", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Information);
                    LimpiarListarContrato();
                }
                else
                {
                    MessageBox.Show("No se puede ejecutar lo solicitado", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Error);
                    LimpiarListarContrato();
                }
            }
            else
            {
                MessageBox.Show("Error, revise si ingreso el Numero de contrato correctamente", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
                LimpiarListarContrato();
            }
        }


        // obtiene la informacion a seleccion del usuario
        private void dgListaContratoLc_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Contrato contrato = dgListaContratoLc.SelectedItem as Contrato;

            MyGlobalContrato._numero = contrato.Numero;
            MyGlobalContrato._rutCliente = contrato.RutCliente;
            MyGlobalContrato._idTipoEvento = contrato.IdTipoEvento;

            txtRutLc.Text = MyGlobalContrato._rutCliente;
            cboTipoEvento.SelectedIndex = MyGlobalContrato._idTipoEvento;
            txtNroContrato.Text = MyGlobalContrato._numero;


        }


        // buscar un contrato 
        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Contrato contrato = new Contrato()
            {
                Numero = txtNroContrato.Text
            };


            if (contrato.Read())
            {
                txtNroContrato.Text = contrato.Numero;
                txtRutLc.Text = contrato.Numero;
                cboTipoEvento.SelectedIndex = contrato.IdTipoEvento;

                MessageBox.Show("Contrato fue Encontrado", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Contrato NO fue Encontrado", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Warning);
                LimpiarListarContrato();
            }


        }


        // carga los datagrid
        private void Grid_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            dgListaContratoLc.ItemsSource = null;
            dgListaContratoLc.ItemsSource = new Contrato().ReadAll();

        }
    }
}
