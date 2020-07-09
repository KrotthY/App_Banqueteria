using OnBreak.Negocio;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;



namespace OnBreak_MDT_V._2
{
    /// <summary>
    /// Lógica de interacción para UserControlAgregarContratos.xaml
    /// </summary>
    public partial class UserControlAgregarContratos : UserControl
    {
        public UserControlAgregarContratos()
        {
            InitializeComponent();
            LimpiarContratos();
            Inicio = true;


        }

        // Encargado de limpiar comtroles de la vista
        private void LimpiarContratos()
        {
            txtRut.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtNumeroContrato.Text = string.Empty;
            dtpFechaInicio.DisplayDateEnd = DateTime.Today;
            dtpFechaTermino.DisplayDateStart = DateTime.Today;
            txtAsistentes.Text = string.Empty;
            txtPersonalAdicional.Text = string.Empty;
            dtpHoraInicio.Text = DateTime.Now.ToString("MM / dd / aaaa");
            dtpHoraTermino.Text = DateTime.Now.ToString("MM / dd / aaaa");
            txbTotal.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
            rbtRealizado.IsChecked = false;


            //CargarModalidadServicio();
            CargarTipoEvento();


        }


        //bool para controlar la carga y muestra de informacion del combobox modalidad, no es necesario pero
        // tiene buen efecto visual.
        public bool Inicio = false;


        // Carga los tipo de evento al combobox cbotipo
        private void CargarTipoEvento()
        {
            cboTipoEvento.ItemsSource = new TipoEvento().ReadAll();
            cboTipoEvento.DisplayMemberPath = "Descripcion";
            cboTipoEvento.SelectedValuePath = "IdTipoEvento";
            cboTipoEvento.SelectedIndex = 0;


        }




        // Guarda los datos ingresados por el cliente
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                bool realizado1 = false;

                if (rbtRealizado.IsChecked == true)
                {
                    realizado1 = true;

                }
                else
                {
                    realizado1 = false;
                }

                Cliente checkCliente = new Cliente()
                {
                    RutCliente = txtRut.Text
                };
                Contrato guardarContrato = new Contrato()
                {

                    Numero = txtNumeroContrato.Text,
                    Creacion = Convert.ToDateTime(dtpFechaInicio.SelectedDate),
                    Termino = Convert.ToDateTime(dtpFechaTermino.SelectedDate),
                    RutCliente = txtRut.Text,
                    IdModalidad = (string)cboModalidad.SelectedValue,
                    IdTipoEvento = (int)cboTipoEvento.SelectedValue,
                    FechaHoraInicio = Convert.ToDateTime(dtpHoraInicio.Value),
                    FechaHoraTermino = Convert.ToDateTime(dtpHoraTermino.Value),
                    Asistentes = int.Parse(txtAsistentes.Text),
                    PersonalAdicional = int.Parse(txtPersonalAdicional.Text),
                    Realizado = realizado1,
                    ValorTotalContrato = MyGlobals._total,
                    Observaciones = txtObservaciones.Text

                };

                if (checkCliente.Read())
                {
                    if (!guardarContrato.Read())
                    {
                        if (guardarContrato.Create())
                        {
                            MessageBox.Show("Contrato guardado correctamente", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Information);
                            LimpiarContratos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el contrato, revise si la informacion esta ingresada correctamente", "Notificacion", MessageBoxButton.OK, MessageBoxImage.Error);
                            LimpiarContratos();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error este contrato ya existe", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
                        LimpiarContratos();
                    }
                }
                else
                {
                    MessageBox.Show("Error, el cliente no registrado y no es posible realizar la accion", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
                    LimpiarContratos();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error tiene que Ingresar todos los datos", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);

            }


        }


        // Busca el rut ingresado por el usuario
        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Cliente buscarCliente = new Cliente()
            {
                RutCliente = txtRut.Text
            };



            if (buscarCliente.Read())
            {
                MessageBox.Show("Cliente encontratado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);

                txtRut.Text = buscarCliente.RutCliente;
                txtRazonSocial.Text = buscarCliente.RazonSocial;

            }
            else
            {
                MessageBox.Show("Cliente no se encuentra registrado, revise el Rut ingresado", "Atecion", MessageBoxButton.OK, MessageBoxImage.Warning);
                LimpiarContratos();
            }
        }



        //Instancia publica para almacenar valores globales y interconectar las vistas 
        public Contrato contraGlobal;



        //Encargado de cargar los contratos ingresados por el usuario /paso 1
        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            Contrato contra = new Contrato();
            OpcionalListarContratos opcionalContratos = new OpcionalListarContratos();
            opcionalContratos.SetUserControl(this);

            opcionalContratos.Show();

        }


        // Encargado de editar los datos del cliente y luego actualizarlos
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

            Contrato actualizarContrato = new Contrato()
            {
                RutCliente = txtRut.Text
            };

            if (actualizarContrato.Update() == true)
            {

                bool realizado1 = false;

                if (rbtRealizado.IsChecked == true)
                {
                    realizado1 = true;

                }
                else
                {
                    realizado1 = false;
                }


                actualizarContrato.Numero = txtNumeroContrato.Text;
                actualizarContrato.Creacion = Convert.ToDateTime(dtpFechaInicio.SelectedDate);
                actualizarContrato.Termino = Convert.ToDateTime(dtpFechaTermino.SelectedDate);
                actualizarContrato.RutCliente = txtRut.Text;
                actualizarContrato.IdModalidad = (string)cboModalidad.SelectedValue;
                actualizarContrato.IdTipoEvento = (int)cboTipoEvento.SelectedValue;
                actualizarContrato.FechaHoraInicio = Convert.ToDateTime(dtpHoraInicio.Value);
                actualizarContrato.FechaHoraTermino = Convert.ToDateTime(dtpHoraTermino.Value);
                actualizarContrato.Asistentes = int.Parse(txtAsistentes.Text);
                actualizarContrato.PersonalAdicional = int.Parse(txtPersonalAdicional.Text);
                actualizarContrato.Realizado = realizado1;
                actualizarContrato.ValorTotalContrato = MyGlobals._total;
                actualizarContrato.Observaciones = txtObservaciones.Text;



                MessageBox.Show("Cliente Actualizado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                LimpiarContratos();

            }
            else
            {
                MessageBox.Show("Cliente no se puede Actualizar UPDATE", "Atecion", MessageBoxButton.OK, MessageBoxImage.Warning);
                LimpiarContratos();
            }
        }



        // Activa de forma automatica los valores(total) mostrados en la vista para el usuario 
        private void txtPersonalAdicional_KeyUp(object sender, KeyEventArgs e)
        {


            MyGlobals._asistentes = Convert.ToInt32(txtAsistentes.Text);
            MyGlobals._personalAdicional = Convert.ToInt32(txtPersonalAdicional.Text);
            CalcularValorContrato();

            txbTotal.Text = MyGlobals._total.ToString();
        }


        //Encargado de almacenar y mostrar los datos capturados desde otra visa y tiene referencia con la clase global /paso2
        public void MostrarDatosContrato()
        {

            if (contraGlobal != null)
            {

                txtNumeroContrato.Text = contraGlobal.Numero;
                dtpFechaInicio.SelectedDate = contraGlobal.Creacion;
                dtpFechaTermino.SelectedDate = contraGlobal.Termino;
                txtRut.Text = contraGlobal.RutCliente;
                cboModalidad.SelectedValue = contraGlobal.IdModalidad;
                cboTipoEvento.SelectedValue = contraGlobal.IdTipoEvento;
                dtpHoraInicio.Value = contraGlobal.FechaHoraInicio;
                dtpHoraTermino.Value = contraGlobal.FechaHoraTermino;
                txtAsistentes.Text = contraGlobal.Asistentes.ToString();
                txtPersonalAdicional.Text = contraGlobal.PersonalAdicional.ToString();
                rbtRealizado.IsChecked = contraGlobal.Realizado;
                txbTotal.Text = contraGlobal.ValorTotalContrato.ToString();
                txtObservaciones.Text = contraGlobal.Observaciones;

            }

        }




        // Hace lo lo que dice el nombre xd
        private void CalcularValorContrato()
        {
            int totalAsistentes = 0;
            int totalAdicional = 0;
            int UF = 30000;

            int _asistentes = MyGlobals._asistentes;
            int _personalAdicional = MyGlobals._personalAdicional;

            if ((_asistentes >= 1) & (_asistentes <= 20))
            {
                totalAsistentes = UF * 3;
            }
            else if ((_asistentes >= 21) & (_asistentes <= 50))
            {
                totalAsistentes = UF * 5;
            }
            else if (_asistentes >= 51)
            {
                int adicional = 0;
                int contador = 0;

                adicional = _asistentes - 50;

                //Se divide por 20 ya que son los grupos de personas para cobrar un valor adicional
                contador = adicional / 20;
                contador = contador * 2;
                totalAsistentes = UF * (contador + 5);
            }

            //Calculo Personal Adicional



            if (_personalAdicional == 2)
            {
                totalAdicional = UF * 2;
            }
            else if (_personalAdicional == 3)
            {
                totalAdicional = UF * 3;
            }
            else if (_personalAdicional == 4)
            {
                totalAdicional = UF * (int)3.5;
            }
            else if (_personalAdicional > 4)
            {
                double adicionalPersonal = 0;

                adicionalPersonal = _personalAdicional - 4;

                // aca obtengo la cantidad total de uf segun el contrato adicional de empleados
                adicionalPersonal = adicionalPersonal * 0.5;

                adicionalPersonal = adicionalPersonal + 3.5;

                totalAdicional = UF * (int)adicionalPersonal;
            }


            int total = totalAsistentes + totalAdicional;

            MyGlobals._total = total;
        }


        // El combo box con dependencia
        private void cboTipoEvento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Inicio)
            {
                ModalidadServicio modalidad = new ModalidadServicio();

                try
                {
                    string valor;

                    valor = cboTipoEvento.SelectedValue.ToString();
                    List<ModalidadServicio> modalidadServicios = new List<ModalidadServicio>();

                    foreach (var x in modalidad.ReadAll())
                    {

                        if (x.IdTipoEvento == int.Parse(valor))
                        {
                            modalidadServicios.Add(x);

                        }
                    }

                    cboModalidad.ItemsSource = modalidadServicios;
                    cboModalidad.DisplayMemberPath = "Nombre";
                    cboModalidad.SelectedValuePath = "IdModalidad";
                    cboModalidad.SelectedIndex = 0;

                }
                catch (Exception)
                {

                }
            }
        }
    }
}










