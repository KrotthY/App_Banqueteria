using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.SqlServer.Server;
using OnBreak.Negocio;



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

        // Funciona correctamente pero aun tiene que modifcarse ya existe problemas 
        //para regisrar un contrato entonces e stearon algunos valores para pruebas habra que editarlos
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

        public bool Inicio = false; 


        // Funciona correctamente
        private void CargarTipoEvento()
        {
            cboTipoEvento.ItemsSource = new TipoEvento().ReadAll();
            cboTipoEvento.DisplayMemberPath = "Descripcion";
            cboTipoEvento.SelectedValuePath = "IdTipoEvento";
            cboTipoEvento.SelectedIndex = 0;

         
        }




        // Funciona correctamente guardar un cliente tiene que revisarse
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


        // Aun sin terminar pero se tiene un idea del desarrollo
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



        //Funciona Correctamente
        public Contrato contraGlobal;

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            Contrato contra = new Contrato();
            OpcionalListarContratos opcionalContratos = new OpcionalListarContratos();
            opcionalContratos.SetUserControl(this);

            opcionalContratos.Show();

        }


        // Funciona Correctamente
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


        //INICIO KEY UP AND DOWN
        //Terminado
        private void txtPersonalAdicional_KeyUp(object sender, KeyEventArgs e)
        {


            MyGlobals._asistentes = Convert.ToInt32(txtAsistentes.Text);
            MyGlobals._personalAdicional = Convert.ToInt32(txtPersonalAdicional.Text);
            CalcularValorContrato();

            txbTotal.Text = MyGlobals._total.ToString();
        }


        //Setear clases globales
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




        // El metodo funciona correctamente el  calculo
        //Falta Agregar valor de eventos
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


        private void cboModalidad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {



        }

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


         
    
            
        
    



