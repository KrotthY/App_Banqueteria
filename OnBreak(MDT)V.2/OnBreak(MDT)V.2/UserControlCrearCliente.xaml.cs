using OnBreak.Negocio;
using System.Windows;
using System.Windows.Controls;

namespace OnBreak_MDT_V._2
{
    /// <summary>
    /// Lógica de interacción para UserControlCrearCliente.xaml
    /// </summary>
    public partial class UserControlCrearCliente : UserControl
    {


        public UserControlCrearCliente()
        {
            InitializeComponent();
            LimpiarCliente();

        }

        // Limpia la vista de usuario, txt etc.
        private void LimpiarCliente()
        {
            txtRutCli.Text = string.Empty;
            txtRazonSocialCli.Text = string.Empty;
            txtNombreContactoCli.Text = string.Empty;
            txtMailContactoCli.Text = string.Empty;
            txtDireccionCli.Text = string.Empty;
            txtTelefonoCli.Text = string.Empty;


            CargarActividadEmpresa();
            CargarTipoEmpresa();
        }

        // Cargar Combobox cbo actividad
        private void CargarActividadEmpresa()
        {
            cboTipoActividad.ItemsSource = new ActividadEmpresa().ReadAll();
            cboTipoActividad.DisplayMemberPath = "Descripcion";
            cboTipoActividad.SelectedValuePath = "IdActividadEmpresa";
            cboTipoActividad.SelectedIndex = 0;

        }

        // Cargar Combobox cbotipo
        private void CargarTipoEmpresa()
        {
            cboTipoEmpresa.ItemsSource = new TipoEmpresa().ReadAll();
            cboTipoEmpresa.DisplayMemberPath = "Descripcion";
            cboTipoEmpresa.SelectedValuePath = "IdTipoEmpresa";
            cboTipoEmpresa.SelectedIndex = 0;

        }


        //Guardar los datos del cliente 
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Cliente guardarCliente = new Cliente()
            {
                RutCliente = txtRutCli.Text,
                RazonSocial = txtRazonSocialCli.Text,
                NombreContacto = txtNombreContactoCli.Text,
                MailContacto = txtMailContactoCli.Text,
                Direccion = txtDireccionCli.Text,
                Telefono = txtTelefonoCli.Text,
                IdActividadEmpresa = (int)cboTipoActividad.SelectedValue,
                IdTipoEmpresa = (int)cboTipoEmpresa.SelectedValue
            };

            if (txtRutCli.Text.Length >= 7 && txtRutCli.Text.Length <= 11)
            {



                if (!guardarCliente.Read())
                {
                    if (guardarCliente.Create())
                    {
                        MessageBox.Show("Cliente guardado correctamente", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimpiarCliente();
                    }
                    else
                    {
                        MessageBox.Show("No se puede ejecutar lo solicitado", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Error);
                        LimpiarCliente();
                    }
                }
                else
                {
                    MessageBox.Show("Error el cliente ya existe", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
                    LimpiarCliente();
                }

            }
            else
            {
                MessageBox.Show("Ingrese Rut Valido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                LimpiarCliente();
            }
        }



        // Buscar cliente por Rut
        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Cliente buscarCliente = new Cliente()
            {
                RutCliente = txtRutCli.Text
            };



            if (buscarCliente.Read() == true)
            {
                MessageBox.Show("Cliente encontratado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);

                txtRutCli.Text = buscarCliente.RutCliente;
                txtRazonSocialCli.Text = buscarCliente.RazonSocial;
                txtNombreContactoCli.Text = buscarCliente.NombreContacto;
                txtMailContactoCli.Text = buscarCliente.MailContacto;
                txtDireccionCli.Text = buscarCliente.Direccion;
                txtTelefonoCli.Text = buscarCliente.Telefono;
                cboTipoActividad.SelectedIndex = buscarCliente.IdActividadEmpresa;
                cboTipoEmpresa.SelectedIndex = buscarCliente.IdTipoEmpresa;

            }
            else
            {
                MessageBox.Show("Cliente no se encuentra registrado", "Atecion", MessageBoxButton.OK, MessageBoxImage.Warning);
                LimpiarCliente();
            }

        }

        //Edita un registro de un cliente 
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Cliente actualizar = new Cliente()
            {
                RutCliente = txtRutCli.Text
            };

            if (actualizar.Read())
            {

                actualizar.RutCliente = txtRutCli.Text;
                actualizar.RazonSocial = txtRazonSocialCli.Text;
                actualizar.NombreContacto = txtNombreContactoCli.Text;
                actualizar.MailContacto = txtMailContactoCli.Text;
                actualizar.Direccion = txtDireccionCli.Text;
                actualizar.Telefono = txtTelefonoCli.Text;
                actualizar.IdActividadEmpresa = cboTipoActividad.SelectedIndex;
                actualizar.IdTipoEmpresa = cboTipoEmpresa.SelectedIndex;
                actualizar.Update();
                MessageBox.Show("Cliente Actualizado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                LimpiarCliente();

            }
            else
            {
                MessageBox.Show("No existe cliente, al que desea actulizar", "Atecion", MessageBoxButton.OK, MessageBoxImage.Warning);
                LimpiarCliente();
            }



        }


        //instancia de clase global para comunicar diferentes vistas y clases
        public Cliente cliGlobal;

        // Encargada de listar los clientes guardados en la base de datos
        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente();
            Opcional opcional = new Opcional();
            opcional.SetUserControl(this);

            opcional.Show();

        }

        //Almacena y entrega los datos almacenados en variables globales y referencias
        public void MostrarDatosCliente()
        {
            if (cliGlobal != null)
            {
                txtRutCli.Text = cliGlobal.RutCliente;
                txtRazonSocialCli.Text = cliGlobal.RazonSocial;
                txtNombreContactoCli.Text = cliGlobal.NombreContacto;
                txtMailContactoCli.Text = cliGlobal.MailContacto;
                txtDireccionCli.Text = cliGlobal.Direccion;
                txtTelefonoCli.Text = cliGlobal.Telefono;
                cboTipoActividad.SelectedIndex = cliGlobal.IdActividadEmpresa;
                cboTipoEmpresa.SelectedIndex = cliGlobal.IdTipoEmpresa;
            }
        }

    }

}
