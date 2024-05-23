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
        


        private void txtBxnom_TextChanged(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscarCliente.Text;

            if (string.IsNullOrWhiteSpace(criterioBusqueda))
            {
                LimpiarCampo();
                return;
            }

            try
            {
                var cliente = Facturacion.BuscarClientePorNombre(criterioBusqueda);
                if (cliente != null)
                {
                    txtNombreCliente.Text = cliente.Nombre;
                }
                else
                {
                    LimpiarCampo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LimpiarCampo()
        {
            txtNombreCliente.Text = string.Empty;
        }
    }

    /*public class objCliente
    {
        public string Nombre { get; set; }
    }*/
}
