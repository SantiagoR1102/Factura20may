using Modelos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmNewCategoria : Form
    {
        private ConexionBD.DBCategorias categorias;

        public FrmNewCategoria(objCategoria modelo)
        {
            InitializeComponent();
            categorias = new ConexionBD.DBCategorias();

            //txtId.Text = modelo.Id.ToString();
            //txtBxNombre.Text = modelo.Nombre;

            /*string info = modelo.Id == 0 ? "NUEVA CATEGORIA" : "ACTUALIZANDO CATEGORIA";
            Text = info; lblInfo.Text = info;*/



            if (modelo == null)
            {
                txtId.Text = "0";
                txtBxNombre.Text = "";
                string info = "NUEVA CATEGORIA";
                Text = info; lblInfo.Text = info;
            }
            else
            {
                txtId.Text = modelo.Id.ToString();
                txtBxNombre.Text = modelo.Nombre;
                string info = "ACTUALIZANDO CATEGORIA";
                Text = info; lblInfo.Text = info;
            }

        }
        



        private void EnviarCat_Click(object sender, EventArgs e)
        {


            try
            {
                if (string.IsNullOrWhiteSpace(txtBxNombre.Text))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío");
                    return;
                }
                if (HasNumbers(txtBxNombre.Text))
                {
                    MessageBox.Show("Nombre no pueden contener números");
                    return;
                }
                int id = Convert.ToInt32(txtId.Text);
                bool rs = categorias.Guardar(id, txtBxNombre.Text);
                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtBxNombre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasNumbers(string input)
        {
            return input.Any(char.IsDigit);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
