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
            int b = int.Parse(dtgLista.SelectedIndex.ToString());

            MessageBox.Show(b.ToString());
            AgregarArticuloMenu Agregar = new AgregarArticuloMenu(0);
            
            Agregar.ShowDialog();
            devolverLista();
        }
    }
}
