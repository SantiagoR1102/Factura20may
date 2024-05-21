﻿using Modelos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmSubCatNew : Form
    {
        private ConexionBD.DBCategorias categorias;
        private ConexionBD.DBSubCategoria SubCategoria;

        public FrmSubCatNew(objSubCategoria modelo)
        {
            InitializeComponent();
            categorias = new ConexionBD.DBCategorias();
            SubCategoria = new ConexionBD.DBSubCategoria();
           


            if(modelo==null)
            {
                txtId.Text = "0";
                string info = "Nueva SubCat";
                Text = info; Lbltit.Text = info;
            }
            else
            {
                txtId.Text = modelo.Id.ToString();
                txtbxNomSubc.Text = modelo.Nombre;
                string info = "Actualizar datos";
                Text = info; Lbltit.Text = info;
            }

            Categorias();
        }

        private void Categorias()
        {
            try
            {
                cboCategorias.DataSource = categorias.Listar();
                cboCategorias.DisplayMember = "Nombre";
                cboCategorias.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarSubCat_Click(object sender, EventArgs e)
        {


            try
            {
                int id = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text);
                int idCategoria = Convert.ToInt32(cboCategorias.SelectedValue);
                bool rs = SubCategoria.GuardarSub(id, txtbxNomSubc.Text, idCategoria);
                /*xtbxNomSubc.Text = Convert.ToString(listViSubc.CurretRow.Cells[@Nombre].value);*/


                if (string.IsNullOrWhiteSpace(txtbxNomSubc.Text))
                {
                    MessageBox.Show("El campo Nombre no puede estar vacio");
                    return;
                }
                if (HasNumber(txtbxNomSubc.Text))
                {
                    MessageBox.Show("El campo Nombre no puede contener numeros");
                    return;
                }


                if (rs)
                {
                    MessageBox.Show("Datos guardados con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtbxNomSubc.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool HasNumber(string input)
        {
            return input.Any(char.IsDigit);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}