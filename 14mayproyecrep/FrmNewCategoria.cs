using System;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmNewCategoria : Form
    {
        private ConexionBD.DBCategorias categorias;
        public FrmNewCategoria(int id)
        {
            InitializeComponent();
            categorias = new ConexionBD.DBCategorias();
            txtId.Text = id.ToString();

            string info = id == 0 ? "NUEVA CATEGORIA" : "ACTUALIZANDO CATEGORIA";
            Text = info; lblInfo.Text = info;
            
        }

        private void EnviarCat_Click(object sender, EventArgs e)
        {
            //string nombre = txtBxNombre.Text;
            //DBCategorias conexionBD = new DBCategorias();
            //conexionBD.insertarDatos(nombre);
            //conexionBD.CerrarConexion();
            //txtBxNombre.Text = "";
            //MessageBox.Show("Datos guardados exitosamente.");
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                bool rs = categorias.Guardar(id, txtBxNombre.Text);
                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    txtBxNombre.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
