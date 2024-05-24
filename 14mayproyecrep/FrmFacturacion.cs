using System;
using Modelos;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace _14mayproyecrep
{

    public partial class FrmFacturacion : Form
    {


        //private List<objFacturacion> ListaFactura;
        private ConexionBD.DBFacturacion Facturacion;
        
        public FrmFacturacion(objFacturacion modelo)
        {
            InitializeComponent();
            Facturacion = new ConexionBD.DBFacturacion();

        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {

        }



        private void txtCedulaCliente_TextChanged(object sender, EventArgs e)
        {
            string cedula = txtNombreCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(cedula))
            {
                LimpiarCampo();
                return;
            }

            try
            {
                string nombre = Facturacion.BuscarNombrePorCedula(cedula);
                if (nombre != null)
                {
                    txtNombreCliente.Text = nombre;
                }
                else
                {
                    LimpiarCampo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el nombre del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampo()
        {
            txtNombreCliente.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cedula = txtBuscarCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Por favor, ingrese una cédula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string nombre = Facturacion.BuscarNombrePorCedula(cedula);
                if (nombre != null)
                {
                    txtNombreCliente.Text = nombre;
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún cliente con la cédula {cedula}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreCliente.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el nombre del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

    /*public class objCliente
    {
        public string Nombre { get; set; }
    }*/

