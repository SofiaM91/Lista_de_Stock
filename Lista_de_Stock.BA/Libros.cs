using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Stock.BA
{
    public class Libros
    {
        public DataTable ListaLibros { get; set; } = new DataTable();

        public Libros()
        {
            ListaLibros.TableName = "ListaLibros";
            ListaLibros.Columns.Add("Codigo");
            ListaLibros.Columns.Add("Descripcion");
            ListaLibros.Columns.Add("Precio");
            ListaLibros.Columns.Add("Cantidad") ;
            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Libros.xml"))
            {
                ListaLibros.ReadXml("Libros.xml");
            }
        }

        public void Insert(Libro libro)
        {
           
            ListaLibros.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaLibros.Rows.Count - 1;
            ListaLibros.Rows[NuevoRenglon]["Codigo"] = libro.Codigo;
            ListaLibros.Rows[NuevoRenglon]["Descripcion"] = libro.Descripcion;
            ListaLibros.Rows[NuevoRenglon]["Precio"] = libro.Precio;
            ListaLibros.Rows[NuevoRenglon]["Cantidad"] = libro.Cantidad;

            ListaLibros.WriteXml("Libros.xml");
        }

    }
}
