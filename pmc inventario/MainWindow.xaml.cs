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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pmc_inventario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {  
        public MainWindow()
        {
            InitializeComponent();
            devolverLista();
        }
        private void devolverLista()
        {
            CargarArchivo Cargar = new CargarArchivo("BaseDatos.txt");
            dtgLista.ItemsSource = Cargar.DevolverLista();
        }

        private void dtgLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblSector.Content = "dtgLista.SelectedIndex.Resolver";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AgregarArticuloMenu Agregar = new AgregarArticuloMenu();
            Agregar.ShowDialog();
            devolverLista();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            int indice = int.Parse(dtgLista.SelectedIndex.ToString());
            if (indice >= 0)
            {
                string codigo = "";
                string descripcion = "";

                for (int i = 1; i < dtgLista.Items.Count; i++)
                {
                    codigo = (dtgLista.Columns[0].GetCellContent(dtgLista.Items[indice]) as TextBlock).Text.ToString();
                    descripcion = (dtgLista.Columns[1].GetCellContent(dtgLista.Items[indice]) as TextBlock).Text.ToString();
                }
                if (codigo != "")
                {
                    AgregarArticuloMenu Agregar = new AgregarArticuloMenu(0, codigo, descripcion);
                    Agregar.ShowDialog();
                    devolverLista();
                }
            }
       
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int indice = int.Parse(dtgLista.SelectedIndex.ToString());
            if (indice >= 0)
            {
                string codigo = "";
                for (int i = 1; i < dtgLista.Items.Count; i++)
                {
                    codigo = (dtgLista.Columns[0].GetCellContent(dtgLista.Items[indice]) as TextBlock).Text.ToString();
                }
                if (codigo != "")
                {
                    CargarArchivo Cargar = new CargarArchivo("BaseDatos.txt");
                    Cargar.Eliminar(codigo);
                    devolverLista();
                }
            }
        }
    }
}
