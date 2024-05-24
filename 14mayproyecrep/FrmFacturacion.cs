using Modelos;
using System;
using System.Collections.Generic;
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


        //refrscar
        private void button1_Click(object sender, EventArgs e)
        {
            ListarSubc();
        }



        private void ListarSubc()
        {
            List<objDetalleFactura> listafaca = Facturacion.Listardetalelfac();
            listafac.Items.Clear();

            foreach (var detalle in listafaca)
            {
                ListViewItem item = new ListViewItem(detalle.CodPro.ToString());
                item.SubItems.Add(detalle.Nombre);
                item.SubItems.Add(detalle.Cantidad.ToString());
                item.SubItems.Add(detalle.Precio.ToString());
                item.SubItems.Add(detalle.Total.ToString());
                listafac.Items.Add(item);

            }
        }



        private void listafac_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int id = 0;
                id = Convert.ToInt32(listafac.SelectedItems[0].SubItems[0].Text);
                if (id > 0)
                {
                    objSubCategoria modelo = new objSubCategoria()
                    {
                        Nombre = listafac.SelectedItems[0].SubItems[1].Text,
                        //IdCategoria = Convert.ToInt32(listafac.SelectedItems[0].SubItems[3].Text)
                    };
                    Form formulario = new FrmSubCatNew(modelo);
                    formulario.ShowDialog();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //btn de enviar a la listview
        private void AggFac_Click(object sender, EventArgs e)
        {


            try
            {
                int id = string.IsNullOrEmpty(txtid.Text) ? 0 : Convert.ToInt32(txtid.Text);
                int CodigoPro = string.IsNullOrEmpty(txtbxCodigo.Text) ? 0 : Convert.ToInt32(txtbxCodigo.Text);
                int Cantidad = string.IsNullOrEmpty(txtBxCantidad.Text) ? 0 : Convert.ToInt32(txtBxCantidad.Text);
                int Precio = string.IsNullOrEmpty(txtBxprecio.Text) ? 0 : Convert.ToInt32(txtBxprecio.Text);

                int Total = Cantidad * Precio;
                bool rs = Facturacion.Guardar(id, CodigoPro, txtbxDesc.Text, Cantidad, Precio, Total);

                if (string.IsNullOrWhiteSpace(txtbxCodigo.Text))
                {
                    MessageBox.Show("El campo Código no puede estar vacío");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
                {
                    MessageBox.Show("El campo Cédula no puede estar vacío");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBxCantidad.Text))
                {
                    MessageBox.Show("El campo Cantidad no puede estar vacío");
                    return;
                }

                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtbxCodigo.Text = "";
                txtBuscarCliente.Text = "";
                txtNombreCliente.Text = "";
                txtBxCantidad.Text = "";
                txtBxprecio.Text = "";
                txtbxDesc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            /* int id = string.IsNullOrEmpty(txtid.Text) ? 0 : Convert.ToInt32(txtid.Text);
             int CodigoPro = string.IsNullOrEmpty(txtbxCodigo.Text) ? 0 : Convert.ToInt32(txtbxCodigo.Text);
             int Cantidad = string.IsNullOrEmpty(txtBxCantidad.Text) ? 0 : Convert.ToInt32(txtBxCantidad.Text);
             int Precio = string.IsNullOrEmpty(txtBxprecio.Text) ? 0 : Convert.ToInt32(txtBxprecio.Text);


             bool rs = Facturacion.Guardar( id,  CodigoPro,  txtbxDesc.Text,  Cantidad,  Precio);


             if (string.IsNullOrWhiteSpace(txtbxCodigo.Text))
             {
                 MessageBox.Show("El campo Codigo no puede estar vacio");
                 return;
             }
             if (string.IsNullOrWhiteSpace(txtBuscarCliente.Text))
             {
                 MessageBox.Show("El campo Cedula no puede estar vacio");
                 return;
             }
             if (string.IsNullOrWhiteSpace(txtBxCantidad.Text))
             {
                 MessageBox.Show("El campo Cantidad no puede estar vacio");
                 return;
             }


             if (rs)
             {
                 MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             txtbxCodigo.Text = "";
             txtBuscarCliente.Text = "";
             txtbxCodigo.Text = "";
             txtBxCantidad.Text = "";
             txtbxDesc.Text = "";


         }
         catch (Exception ex)
         {
             MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }*/
        }
    }

}




