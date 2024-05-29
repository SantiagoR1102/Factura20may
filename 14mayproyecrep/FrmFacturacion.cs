using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _14mayproyecrep
{

    public partial class FrmFacturacion : Form
    {


        //private List<objFacturacion> ListaFactura;
        private ConexionBD.DBFacturacion Facturacion;
        private ConexionBD.DBProductos DBProductos;
        private List<objProductos> ListaProductos;
        List<objDetalleFactura> listafaca;
        private ConexionBD.DBCliente Cliente;
        private int TotalFactura = 0;


        public FrmFacturacion(objFacturacion modelo)
        {
            InitializeComponent();
            Facturacion = new ConexionBD.DBFacturacion();
            DBProductos = new ConexionBD.DBProductos();
            ListaProductos = new List<objProductos>();
            listafaca = new List<objDetalleFactura>();
            Cliente = new ConexionBD.DBCliente();
        }



        //Buscar Cedula de la persona 
        private void button2_Click_1(object sender, EventArgs e)
        {
            string cedula = txtBuscarCliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(cedula))
            {
                MessageBox.Show("Por favor, ingrese una cédula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var nombre = Cliente.Buscar(cedula);
                if (nombre != null)
                {
                    txtNombreCliente.Text = nombre.Nombre;
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
                var resultado = DBProductos.Buscar(codigo);
                if (resultado.Nombre != null)
                {
                    txtbxDesc.Text = resultado.Nombre;
                    txtBxprecio.Text = resultado.Precio.ToString();
                    txtBxCantidad.Focus();

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


        //refrscar
        private void button1_Click(object sender, EventArgs e)
        {
            ListarSubc();
        }



        private void ListarSubc()
        {
           
            listafac.Items.Clear();

            foreach (var detalle in listafaca)
            {
                ListViewItem item = new ListViewItem(detalle.CodPro.ToString());
                item.SubItems.Add(detalle.Cantidad.ToString());
                item.SubItems.Add(detalle.Precio.ToString());
                item.SubItems.Add(detalle.Total.ToString());
                listafac.Items.Add(item);

            }

        }


        //btn de enviar a la listview
        private void AggFac_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListaProductos.Count > 0)
                {
                    bool r = ListaProductos.Where(x => x.CodPro == Convert.ToInt32(txtbxCodigo.Text)).Any();
                    if (r)
                    {
                        MessageBox.Show("Producto ya existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                ListaProductos.Add(new objProductos()
                {
                    CodPro = Convert.ToInt32(txtbxCodigo.Text),
                    Nombre = txtbxDesc.Text,
                    Precio = Convert.ToInt32(txtBxprecio.Text),
                    Total = Convert.ToInt32(txtBxprecio.Text) * Convert.ToInt32(txtBxCantidad.Text),
                    
                });


                listafac.Items.Clear();


                foreach (var pedidos in ListaProductos)
                {
                    ListViewItem item = new ListViewItem(pedidos.CodPro.ToString());
                    item.SubItems.Add(pedidos.Nombre);
                    item.SubItems.Add(txtBxCantidad.Text);
                    item.SubItems.Add(txtNombreCliente.Text );
                    item.SubItems.Add(pedidos.Precio.ToString("#.##"));
                    item.SubItems.Add(pedidos.Total.ToString("#.##"));
                    listafac.Items.Add(item);

                }
                CalcularTotal();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtbxCodigo.Text = "";
            txtbxDesc.Text = "";
            txtBxCantidad.Text = "";
            txtBxprecio.Text = "";
            txtNombreCliente.Text = "";
            txtBuscarCliente.Text = "";
        }

        private void listafac_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (listafac.SelectedItems.Count > 0)
                {
                    var selectedItem = listafac.SelectedItems[0];
                    int id = Convert.ToInt32(selectedItem.SubItems[0].Text);


                    objDetalleFactura modelo = new objDetalleFactura()
                    {

                        Id = id,
                        CodPro = Convert.ToInt32(selectedItem.SubItems[1].Text),
                        Nombre = selectedItem.SubItems[2].Text,
                        Cantidad = Convert.ToInt32(selectedItem.SubItems[3].Text),
                        Precio = Convert.ToInt32(selectedItem.SubItems[4].Text),
                        Total = Convert.ToInt32(selectedItem.SubItems[5].Text),                        

                    };
                    Form formulario = new FrmFacturacion(null);
                    formulario.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularTotal()
        {
            decimal totalFinal = 0;
            foreach (ListViewItem item in listafac.Items)
            {
                if (decimal.TryParse(item.SubItems[5].Text, out decimal total))
                {
                    totalFinal += total;
                    TotalFactura = Convert.ToInt32(totalFinal);
                }
            }

            txtbxpagot.Text = string.Format("{0:C2}", totalFinal);
        }
        
        private void masCiente_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmCliNew(null);
            formulario.ShowDialog();
        }




        //enviar al modelo----------------------------------------------------------------------------------------
        private void button3_Click_1(object sender, EventArgs e)
        {
            //listaFacturacion.Clear();
            objFacturacion facturacion = new objFacturacion
            {
                Cedula = Convert.ToInt32(txtBuscarCliente.Text),
                TotalFinal = TotalFactura
            };

            foreach (ListViewItem item in listafac.Items)
            {
                objDetalleFactura detalle = new objDetalleFactura
                {
                    CodPro = Convert.ToInt32(item.SubItems[0].Text),
                    Nombre = item.SubItems[1].Text,
                    Cantidad = Convert.ToInt32(item.SubItems[2].Text),

                    Precio = Convert.ToInt32(item.SubItems[4].Text),
                    Total = Convert.ToInt32(item.SubItems[5].Text),
                    
            };

                facturacion.Detalle.Add(detalle);
            }


            var rs = Facturacion.Guardar(facturacion);
            if (!rs) {
                MessageBox.Show("Error al guardar la factura");
                return;
            }
            MessageBox.Show("Datos guardados con éxito en los modelos.");

        }

        private void txtbxpagot_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listafac.Items.Clear();
                MessageBox.Show("Los elementos han sido eliminados Correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los elementos : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}







