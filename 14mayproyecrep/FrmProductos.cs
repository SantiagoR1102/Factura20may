using Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmProductos : Form
    {
        private List<objProductos> ListaProductos;
        private ConexionBD.DBProductos productos;


        public FrmProductos(objProductos modelo)
        {
            InitializeComponent();
            productos = new ConexionBD.DBProductos();
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            try
            {
                ListaProductos = productos.Listar();
                listViewPro.Items.Clear();
                foreach (var producto in ListaProductos)
                {
                    ListViewItem item = new ListViewItem(producto.Id.ToString());
                    item.SubItems.Add(producto.Nombre);
                    item.SubItems.Add(producto.Precio.ToString());
                    item.SubItems.Add(producto.SubCategoria.ToString());
                    item.SubItems.Add(producto.categoria.ToString());
                    item.SubItems.Add(producto.CodPro.ToString());


                    listViewPro.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listViewPro.SelectedItems.Count > 0)
                {
                    var selectedItem = listViewPro.SelectedItems[0];
                    int id = Convert.ToInt32(selectedItem.SubItems[0].Text);

                    objProductos modelo = new objProductos()
                    {
                        Id = id,
                        Nombre = selectedItem.SubItems[1].Text,
                        Precio = Convert.ToInt32(selectedItem.SubItems[2].Text),

                        idSubCategoria = Convert.ToInt32(selectedItem.SubItems[3].Text),
                        CodPro = Convert.ToInt32(selectedItem.SubItems[4].Text),

                    };
                    Form formulario = new FrmProductosNew(modelo);
                    formulario.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewPro_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProductosNew(null);
            formulario.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}