using BeautySolutions.View.ViewModel;
using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using OnBreak.Negocio;
using System;

namespace OnBreak_MDT_V._2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()

        {
            InitializeComponent();

            var menuInicio = new List<SubItem>();
            var item0 = new ItemMenu("Inicio",menuInicio,PackIconKind.House);
            

            var menuCliente = new List<SubItem>();
            menuCliente.Add(new SubItem("Ingresar Cliente" , new UserControlCrearCliente()));
            menuCliente.Add(new SubItem("Lista de Clientes", new UserControlListarCliente()));

            var item1 = new ItemMenu("Adm Clientes", menuCliente, PackIconKind.Account);


            var menuContrato = new List<SubItem>();
            menuContrato.Add(new SubItem("Ingresar Contrato", new UserControlAgregarContratos()));
            menuContrato.Add(new SubItem("Lista de Contratos", new UserControlListarContratos()));

            var item2 = new ItemMenu("Adm Contratos", menuContrato, PackIconKind.Contract);




            Menu.Children.Add(new UserControlMenuItem(item0, this));
            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this));

        }

        internal void SwitchScreen (object sender)
        {
            var screen = ((UserControl)sender);
            if(screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

        private void ButtonPopUpSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Metodos
        //Actividad empresa

       
         
    }

      
    
}

public static class MyGlobals
{
    public static int _total;
    public static int _asistentes;
    public static int _personalAdicional;
    public static string _rut;
    public static int _actividad;
    public static int _empresa;


}

public static class MyGlobalContrato
{
    public static string _numero;
    public static string _rutCliente;
    public static int _idTipoEvento;

}


