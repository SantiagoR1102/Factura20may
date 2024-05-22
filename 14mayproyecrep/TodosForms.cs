using System;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class TodosForms : Form
    {
        public TodosForms()
        {
            InitializeComponent();
        }

        private void FormCategoria_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmCategorias(null);
            formulario.ShowDialog();
        }

        private void FormCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmCliente(null);
            formulario.ShowDialog();
        }

        private void FormSubCat_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmSubCat(null);
            formulario.ShowDialog();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProductos(null);
            formulario.ShowDialog();
        }
    }
}
