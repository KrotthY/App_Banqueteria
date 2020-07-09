using OnBreak.Negocio;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace OnBreak_MDT_V._2
{
    /// <summary>
    /// Lógica de interacción para UserControlListarCliente.xaml
    /// </summary>
    public partial class UserControlListarCliente : UserControl
    {
        public UserControlListarCliente()
        {
            InitializeComponent();

            LimpiarListar();


        }

        // limpia la vista del usuario al equivocarse o al iniciar o lo que desee el programador
        private void LimpiarListar()
        {
            CargarActividadEmpresa();
            CargarTipoEmpresa();
            CargarDataGridList();

        }

        // Carga el combobox actividad
        private void CargarActividadEmpresa()
        {
            cboTipoActividad.ItemsSource = new ActividadEmpresa().ReadAll();
            cboTipoActividad.DisplayMemberPath = "Descripcion";
            cboTipoActividad.SelectedValuePath = "IdActividadEmpresa";
            cboTipoActividad.SelectedIndex = 0;

        }

        //Carga el combobox tipo
        private void CargarTipoEmpresa()
        {
            cboTipoEmpresa.ItemsSource = new TipoEmpresa().ReadAll();
            cboTipoEmpresa.DisplayMemberPath = "Descripcion";
            cboTipoEmpresa.SelectedValuePath = "IdTipoEmpresa";
            cboTipoEmpresa.SelectedIndex = 0;
        }


        // cargar datagrid
        private void CargarDataGridList()

        {
            dgListaClienteLcli.ItemsSource = new Cliente().ReadAll();

        }


        // Solo se entrega un mensaje pero no tiene funciones incorporadas
        private void btnImprimir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Debe conectarse a una impresora", "Atencion", MessageBoxButton.OK, MessageBoxImage.Error);

        }



        // metodo para eliminar un cliente a seleccion del usuario
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Contrato checkContrato = new Contrato()
            {
                RutCliente = MyGlobals._rut,
            };
            Cliente cliente = new Cliente()
            {
                RutCliente = MyGlobals._rut,

            };

            if (txtRutLcli.Text != "")
            {
                cliente.RutCliente = txtRutLcli.Text;
                checkContrato.RutCliente = txtRutLcli.Text;
            }


            if (cliente.Read())
            {
                if (!checkContrato.ReadRutCliente())
                {


                    if (cliente.Delete())
                    {
                        MessageBox.Show("Cliente fue Borrado correctamente", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Information);
                        LimpiarListar();
                    }
                    else
                    {
                        MessageBox.Show("No se puede ejecutar lo solicitado", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Error);
                        LimpiarListar();
                    }

                }
                else
                {
                    MessageBox.Show("No se puede eliminar Cliente ya que posee un contrato !!!vigente!!!", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Warning);
                    LimpiarListar();
                }

            }
            else
            {
                MessageBox.Show("Error, revise si ingreso el Rut correctamente", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
                LimpiarListar();
            }
        }


        //Obtiene la informacion selecciona por el usuario
        private void dgListaClienteLcli_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Cliente cliente = dgListaClienteLcli.SelectedItem as Cliente;

            MyGlobals._rut = cliente.RutCliente;
            MyGlobals._actividad = cliente.IdActividadEmpresa;
            MyGlobals._empresa = cliente.IdTipoEmpresa;


            txtRutLcli.Text = MyGlobals._rut;
            cboTipoActividad.SelectedIndex = MyGlobals._actividad;
            cboTipoEmpresa.SelectedIndex = MyGlobals._empresa;

        }


        // busca un cliente segun estime el usuario
        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente()
            {
                RutCliente = txtRutLcli.Text
            };


            if (cliente.Read())
            {
                txtRutLcli.Text = cliente.RutCliente;
                cboTipoActividad.SelectedIndex = cliente.IdActividadEmpresa;
                cboTipoEmpresa.SelectedIndex = cliente.IdTipoEmpresa;

                MessageBox.Show("Cliente fue Encontrado", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Cliente NO fue Encontrado", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Warning);
                LimpiarListar();
            }
        }


        // al cambiar de pestaña se actuliza el datagrid
        private void Grid_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            dgListaClienteLcli.ItemsSource = null;
            dgListaClienteLcli.ItemsSource = new Cliente().ReadAll();
        }


    }
}
