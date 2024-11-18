using Lista_de_Stock.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Stock.FE
{
    public partial class frmLibros : Form
    {
        Libros ListaLibros { get; set; } = new Libros();
        private Libros Libros = new Libros();


        public frmLibros()
        {
            InitializeComponent();
            DGV.DataSource = Libros.ListaLibros;
        }
        
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Libro Lib = new Libro(txtCodigo.Text,
                        txtDescripcion.Text,
                        txtPrecio.Text,
                        txtCantidad.Text);

            Libros.Insert(Lib);

        }
    }
}
