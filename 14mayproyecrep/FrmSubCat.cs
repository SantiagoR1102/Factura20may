using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Modelos;

namespace _14mayproyecrep
{
    public partial class FrmSubCat : Form
    {
        private List<objSubCategoria> ListaSubcat;
        private ConexionBD.DBSubCategoria SubCategoria;


        public FrmSubCat()
        {
            InitializeComponent();
            SubCategoria = new ConexionBD.DBSubCategoria();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void newSubcat_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmSubCatNew(0);
            formulario.ShowDialog();
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            ListarSubc();
        }



        private void ListarSubc()
        {
            ListaSubcat = new List<objSubCategoria>();
            ListaSubcat = SubCategoria.ListarSubCat();
            listViSubc.Items.Clear();
            for (int x = 0; x < ListaSubcat.Count; x++)
            {
                ListViewItem item = new ListViewItem(ListaSubcat[x].Id.ToString());
                item.SubItems.Add(ListaSubcat[x].Nombre);
                listViSubc.Items.Add(item);
            }

        }

        private void listViSubc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                id = Convert.ToInt32(listViSubc.SelectedItems[0].SubItems[0].Text);
                Form formulario = new FrmSubCatNew(id);
                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
