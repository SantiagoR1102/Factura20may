using Modelos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmCliente : Form
    {
        private List<objCliente> ListaCliente;
        private ConexionBD.DBCliente Clientes;


        public FrmCliente()
        {

            InitializeComponent();
            Clientes = new ConexionBD.DBCliente();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmCliNew(0);
            formulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarCli();

        }


        private void ListarCli()
        {
            ListaCliente = new List<objCliente>();
            ListaCliente = Clientes.ListarCli();
            listView1.Items.Clear();
            for (int x = 0; x < ListaCliente.Count; x++)
            {
                ListViewItem item = new ListViewItem(ListaCliente[x].Id.ToString());
                item.SubItems.Add(ListaCliente[x].Nombre);
                item.SubItems.Add(ListaCliente[x].Apellido);
                item.SubItems.Add(ListaCliente[x].Correo);
                item.SubItems.Add(ListaCliente[x].Telefono.ToString());
                item.SubItems.Add(ListaCliente[x].Direccion);
                listView1.Items.Add(item);
            }

        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                Form formulario = new FrmCliNew(id);
                formulario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
