using System;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmSubCatNew : Form
    {
        private ConexionBD.DBCategorias categorias;
        private ConexionBD.DBSubCategoria SubCategoria;

        public FrmSubCatNew(int id)
        {
            InitializeComponent();
            categorias = new ConexionBD.DBCategorias();
            SubCategoria = new ConexionBD.DBSubCategoria();
            Categorias();
        }

        private void Categorias()
        {
            try
            {
                cboCategorias.DataSource = categorias.Listar();
                cboCategorias.DisplayMember = "Nombre";
                cboCategorias.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarSubCat_Click(object sender, EventArgs e)
        {
            try
            {
                int id = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text);
                int idCategoria = Convert.ToInt32(cboCategorias.SelectedValue);
                bool rs = SubCategoria.GuardarSub(id, txtbxNomSubc.Text, idCategoria);

                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtbxNomSubc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
