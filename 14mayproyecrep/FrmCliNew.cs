using System;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmCliNew : Form
    {
        private ConexionBD.DBCliente cliente;
        public FrmCliNew(int id)
        {
            InitializeComponent();
            cliente = new ConexionBD.DBCliente();
            txtId.Text = id.ToString();

            string info = id == 0 ? "Nuevo Cliente" : "Actualizar Cliente";
            Text = info; lblClie.Text = info;

        }

        private void FrmCliNew_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int telefono;
                if (!int.TryParse(txtbxTelefono.Text, out telefono))
                {
                    MessageBox.Show("El teléfono debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = Convert.ToInt32(txtId.Text);
                bool rs = cliente.GuardarClie(id, txtbxNombre.Text, txtbxapellido.Text, txtbxCorreo.Text, telefono, txtbxDireccion.Text);
                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbxNombre.Text = "";txtbxapellido.Text = ""; txtbxCorreo.Text = "";txtbxTelefono.Text = "";txtbxDireccion.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
