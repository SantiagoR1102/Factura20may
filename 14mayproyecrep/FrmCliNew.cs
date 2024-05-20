using Modelos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmCliNew : Form
    {
        private ConexionBD.DBCliente cliente;


        public FrmCliNew(objCliente modelo)
        {
            InitializeComponent();
            cliente = new ConexionBD.DBCliente();
            /*txtId.Text = modelo.Id.ToString();
            txtbxNombre.Text = modelo.Nombre;
            txtbxapellido.Text = modelo.Apellido;
            txtbxCorreo.Text = modelo.Correo;
            txtbxTelefono.Text = modelo.Telefono.ToString();
            txtbxDireccion.Text = modelo.Direccion;
            string info = modelo.Id == 0 ? "Nuevo Cliente" : "Actualizar Cliente";
            Text = info; lblClie.Text = info;*/


            if (modelo == null)
            {
                txtId.Text = "0";
                string info = "Nuevo Cliente";
                Text = info; lblClie.Text = info;
            }
            else
            {
                txtId.Text = modelo.Id.ToString();
                txtbxNombre.Text = modelo.Nombre;
                txtbxapellido.Text = modelo.Apellido;
                txtbxCorreo.Text = modelo.Correo;
                txtbxTelefono.Text = modelo.Telefono.ToString();
                txtbxDireccion.Text = modelo.Direccion;
                string info = "Actualizar Cliente";
                Text = info; lblClie.Text = info;
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            /*Validaciones de los campos: nombre, apellido, correo, telefono y direccion*/
            try
            {


                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtbxNombre.Text))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacío");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxapellido.Text))
                {
                    MessageBox.Show("El campo Apellido no puede estar vacío");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxCorreo.Text))
                {
                    MessageBox.Show("El campo Correo no puede estar vacío");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxTelefono.Text))
                {
                    MessageBox.Show("El campo Teléfono no puede estar vacío");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtbxDireccion.Text))
                {
                    MessageBox.Show("El campo Dirección no puede estar vacío");
                    return;
                }
                if (HasNumbers(txtbxNombre.Text) || HasNumbers(txtbxapellido.Text))
                {
                    MessageBox.Show("Nombre y Apellido no pueden contener números");
                    return;
                }
                if (!IsNumeric(txtbxTelefono.Text))
                {
                    MessageBox.Show("El teléfono debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Guardar datos
                int id = Convert.ToInt32(txtId.Text);
                bool rs = cliente.GuardarClie(id, txtbxNombre.Text, txtbxapellido.Text, txtbxCorreo.Text, Convert.ToInt32(txtbxTelefono.Text), txtbxDireccion.Text);
                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbxNombre.Text = "";
                    txtbxapellido.Text = "";
                    txtbxCorreo.Text = "";
                    txtbxTelefono.Text = "";
                    txtbxDireccion.Text = "";
                }
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

        private bool IsNumeric(string input)
        {
            return input.All(char.IsDigit);
        }


        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
