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

namespace pmc_inventario
{
    /// <summary>
    /// Lógica de interacción para AgregarArticuloMenu.xaml
    /// </summary>
    public partial class AgregarArticuloMenu : Window
    {
        public bool precionado = false;
        public AgregarArticuloMenu()
        {
            InitializeComponent();
        }
        public AgregarArticuloMenu(int cod,string codigo,string descripcion)
        {
            InitializeComponent();
            lblTitulo.Content = "Modificar Articulo";
            btnAgregar.Content = "Modificar";
            txtCodigo.Text = codigo;
            txtDescripcion.Text = descripcion;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtDescripcion.Text != "")
            {
                Articulo miArticulo = new Articulo();
                try
                {
                    miArticulo.Codigo = int.Parse(txtCodigo.Text);
                }
                catch
                {
                    MessageBox.Show("Deve Ingresar un Codigo Numerico");
                }
                miArticulo.Descripcion = txtDescripcion.Text;
                miArticulo.Ubicacion = "Arreglar"; //ARREGLAR////////////////////////////////////////////////
                CargarArchivo Cargar = new CargarArchivo("BaseDatos.txt");
                List<Articulo> miListaArticulos = Cargar.DevolverLista().Where(n => n.Codigo == int.Parse(txtCodigo.Text)).ToList();
                if(miListaArticulos.Equals(null))
                {
                    if (miListaArticulos[0].Codigo == int.Parse(txtCodigo.Text))
                    {
                        MessageBox.Show("Ya hay un Articulo con el mismo codigo");
                    }
                   
                }
                else
                {
                    Cargar.AgregarArchivo(txtCodigo.Text, txtDescripcion.Text, "Arreglar");
                    precionado = true;
                    this.Close();
                }
                
            }
        }
    }
}
