using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmc_inventario
{
    internal class CargarArchivo
    {
        List<Articulo> ListaArticulos;
        private string BD;
        public void AgregarArchivo(string codigo,string descripcion,string ubicacion)
        {
            char coma = ',';
            StreamWriter Agregar = File.AppendText(BD);
            Agregar.WriteLine(codigo + coma + descripcion + coma + ubicacion);
            Agregar.Close();

        }
        public List<Articulo> DevolverLista()
        {
            if(ListaArticulos == null)
            {
                ListaArticulos = new List<Articulo>();
                Articulo miArticulo = new Articulo();
                miArticulo.Codigo = 0;
                miArticulo.Descripcion = "No Hay Articulos en la Base de Datos";
                miArticulo.Ubicacion = "";
                ListaArticulos.Add(miArticulo);     
            }
            return ListaArticulos;
        }
        public CargarArchivo(string BD)
        {
            this.BD = BD;
            StreamWriter Crear;
            if (!(File.Exists(BD)))
            {
                Crear = File.AppendText(BD);
                Crear.Close();
            }
            else
            {
                StreamReader Leer = File.OpenText(BD);
                string lectura = Leer.ReadLine();
                if (lectura != null)
                {
                    ListaArticulos = new List<Articulo>();
                    while (lectura != null)
                    {
                        string[] articulo = lectura.Split(',');
                        Articulo miArticulo = new Articulo();                       
                        miArticulo.Codigo = int.Parse(articulo[0]);
                        miArticulo.Descripcion = articulo[1];
                        miArticulo.Ubicacion = articulo[2];
                        ListaArticulos.Add(miArticulo);
                        lectura = Leer.ReadLine();
                    }
                }
                Leer.Close();
            }
            


        }
        

                
    }
}
