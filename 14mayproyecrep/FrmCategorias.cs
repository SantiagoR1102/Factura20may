using Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmCategorias : Form
    {
        private List<objCategoria> ListaCategorias;
        private ConexionBD.DBCategorias categorias;

        public FrmCategorias(objCategoria modelo)
        {
            InitializeComponent();
            categorias = new ConexionBD.DBCategorias();
            
            
        }
        
        /*Agregar categoria (button)*/

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmNewCategoria(null);
            formulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            ListaCategorias = new List<objCategoria>();
            ListaCategorias = categorias.Listar();
            ListData.Items.Clear();
            for (int x = 0; x < ListaCategorias.Count; x++)
            {
                ListViewItem item = new ListViewItem(ListaCategorias[x].Id.ToString());
                item.SubItems.Add(ListaCategorias[x].Nombre);
                ListData.Items.Add(item);
                
            }

        }



        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void ListData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                id = Convert.ToInt32(ListData.SelectedItems[0].SubItems[0].Text);
                if(id > 0) 
                {
                    objCategoria modelo = new objCategoria()
                    {
                        Id = Convert.ToInt32(ListData.SelectedItems[0].SubItems[0].Text),
                        Nombre = ListData.SelectedItems[0].SubItems[1].Text
                    };

                    Form formulario = new FrmNewCategoria(modelo);
                    formulario.ShowDialog();

                };

               
            }
            catch { }

        }

        private void Panel_1_Superior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
