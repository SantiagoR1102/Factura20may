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
        public FrmProductos()
        {
            InitializeComponent();
            productos = new ConexionBD.DBProductos();
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewPro_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProductosNew(null);
            formulario.ShowDialog();
        }

        private void Listar()
        {
            ListaProductos = new List<objProductos>();
            ListaProductos = productos.Listar();
            listViewPro.Items.Clear();
            for (int x=0; x<ListaProductos.Count; x++)
            {
                ListViewItem item = new ListViewItem(ListaProductos[x].Id.ToString());
                item.SubItems.Add(ListaProductos[x].Nombre);
                listViewPro.Items.Add(item);   
            }
        }

        private void listViewPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                id = Convert.ToInt32(listViewPro.SelectedItems[0].SubItems[0].Text);
                if (id > 0)
                {
                    objProductos modelo = new objProductos()
                    {
                        Id = Convert.ToInt32(listViewPro.SelectedItems[0].SubItems[0].Text),
                        Nombre = listViewPro.SelectedItems[0].SubItems[1].Text
                    };
                    Form formulario = new FrmProductosNew(modelo);
                    formulario.ShowDialog();
                };

            }
            catch { }
        }

        
    }
}
