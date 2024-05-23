using Modelos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmProductosNew : Form
    {
        private ConexionBD.DBProductos productos;
        private ConexionBD.DBSubCategoria subCategoria;
        private ConexionBD.DBCategorias  Categoria;


        public FrmProductosNew(objProductos modelo)
        {
            InitializeComponent();
            productos = new ConexionBD.DBProductos();
            subCategoria = new ConexionBD.DBSubCategoria();
            Categoria = new ConexionBD.DBCategorias();


            if (modelo == null)
            {
                txtId.Text = "0";
                string info = "Nuevo Producto";
                Text = info;
                lblTit.Text = info;
            }
            else
            {
                txtId.Text = modelo.Id.ToString();
                txtbxNom.Text = modelo.Nombre;
                txtbxPrecio.Text = modelo.Precio.ToString();
                txtbxsubcat.SelectedValue = modelo.idSubCategoria;
                cboxcat.SelectedValue = modelo.Id;

                string info = "Actualizar Producto";
                Text = info;
                lblTit.Text = info;
            }

            CargarSubCategorias();
            CargarCategorias();
        }

        private void CargarSubCategorias()
        {
            try
            {
                var subCategorias = subCategoria.ListarSubCat();
                txtbxsubcat.DataSource = subCategorias;
                txtbxsubcat.DisplayMember = "Nombre";
                txtbxsubcat.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarCategorias()
        {
            try
            {
                var Categorias = Categoria.Listar();
                cboxcat.DataSource = Categorias;
                cboxcat.DisplayMember = "Nombre";
                cboxcat.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviaPro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbxNom.Text))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío");
                    return;
                }
                if (HasNumber(txtbxNom.Text))
                {
                    MessageBox.Show("El campo Nombre no puede tener números");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxPrecio.Text) || !uint.TryParse(txtbxPrecio.Text, out uint precio))
                {
                    MessageBox.Show("El campo Precio debe ser un número válido");
                    return;
                }
                if (txtbxsubcat.SelectedValue == null || !int.TryParse(txtbxsubcat.SelectedValue.ToString(), out int idSubCategoria))
                {
                    MessageBox.Show("Por favor, seleccione una subcategoría válida");
                    return;
                }

                int id = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text);
                bool rs = productos.Guardar(id, txtbxNom.Text, (int)precio, idSubCategoria);

                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Limpiar campos
                txtbxNom.Text = "";
                txtbxPrecio.Text = "";
                txtbxsubcat.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasNumber(string input)
        {
            return input.Any(char.IsDigit);
        }

        private void mascat_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmSubCatNew(null);
            formulario.ShowDialog();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmCategorias(null);
            formulario.ShowDialog();
        }
    }
}