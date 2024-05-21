using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14mayproyecrep
{
    public partial class FrmProductosNew : Form
    {
        private ConexionBD.DBProductos productos;
        public FrmProductosNew(objCliente modelo)
        {
            InitializeComponent();
            productos = new ConexionBD.DBProductos();
            if(modelo== null)
            {
                
            }
        }
    }
}
