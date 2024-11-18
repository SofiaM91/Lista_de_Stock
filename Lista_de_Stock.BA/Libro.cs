using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Stock.BA
{public class Libro
    {
        public string Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public decimal Cantidad { get; set; }

        public Libro()
        {

        }
        public Libro(string codigo,
                    string descripcion,
                    string precio,
                    string cantidad)
        {



            Codigo = codigo;
            Descripcion = descripcion;
            Precio = Convert.ToDecimal(precio);
            Cantidad = Convert.ToDecimal(cantidad);

        }
        public override string ToString()
        {
            return $"{Codigo} - {Descripcion} - ({Precio}) -({Cantidad})";
        }

    }
}
