using Modelos;
using System;
using System.Windows.Forms;

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



        //Buscar Cedula de la persona 
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






        //Bsucar Coditgo de producto
        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {


            string codigo = txtbxCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Por favor, ingrese un código.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resultado = Facturacion.BuscarProductoPorCodigo(codigo);
                if (resultado.Nombre != null)
                {
                    txtbxDesc.Text = resultado.Nombre;
                    txtBxprecio.Text = resultado.Precio.HasValue ? resultado.Precio.Value.ToString() : string.Empty;
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún producto con el código {codigo}.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbxDesc.Text = string.Empty;
                    txtBxprecio.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}


