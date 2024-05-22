using Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmSubCat : Form
    {
        private List<objSubCategoria> ListaSubcat;
        private ConexionBD.DBSubCategoria SubCategoria;


        public FrmSubCat(objSubCategoria modelo)
        {
            InitializeComponent();
            SubCategoria = new ConexionBD.DBSubCategoria();
        }
        private void newSubcat_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmSubCatNew(null);
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
                item.SubItems.Add(ListaSubcat[x].categoria.Nombre);
                item.SubItems.Add(ListaSubcat[x].categoria.Id.ToString());
                listViSubc.Items.Add(item);
            }

        }

        private void listViSubc_SelectedIndexChanged(object sender, EventArgs e)
        {



            try
            {
                int id = 0;
                id = Convert.ToInt32(listViSubc.SelectedItems[0].SubItems[0].Text);
                if (id > 0)
                {
                    objSubCategoria modelo = new objSubCategoria()
                    {
                        Id = Convert.ToInt32(listViSubc.SelectedItems[0].SubItems[0].Text),
                        Nombre = listViSubc.SelectedItems[0].SubItems[1].Text,
                        IdCategoria = Convert.ToInt32(listViSubc.SelectedItems[0].SubItems[3].Text)
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

       
    }

}
