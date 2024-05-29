
namespace _14mayproyecrep
{
    partial class FrmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listafac = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.persona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtbxpagot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxCodigo = new System.Windows.Forms.TextBox();
            this.txtBxCantidad = new System.Windows.Forms.TextBox();
            this.txtBxprecio = new System.Windows.Forms.TextBox();
            this.AggFac = new System.Windows.Forms.Button();
            this.txtbxDesc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.masCiente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 586);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listafac);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(862, 345);
            this.panel6.TabIndex = 4;
            // 
            // listafac
            // 
            this.listafac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listafac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.persona,
            this.Precio,
            this.Total});
            this.listafac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listafac.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listafac.GridLines = true;
            this.listafac.HideSelection = false;
            this.listafac.Location = new System.Drawing.Point(0, 0);
            this.listafac.MultiSelect = false;
            this.listafac.Name = "listafac";
            this.listafac.Size = new System.Drawing.Size(862, 345);
            this.listafac.TabIndex = 1;
            this.listafac.UseCompatibleStateImageBehavior = false;
            this.listafac.View = System.Windows.Forms.View.Details;
            this.listafac.SelectedIndexChanged += new System.EventHandler(this.listafac_SelectedIndexChanged_1);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cantidad.Width = 150;
            // 
            // persona
            // 
            this.persona.Text = "NombrePer";
            this.persona.Width = 160;
            // 
            // Precio
            // 
            this.Precio.Text = "Precio";
            this.Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Precio.Width = 150;
            // 
            // Total
            // 
            this.Total.Tag = "";
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Total.Width = 160;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 496);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(862, 90);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.txtbxpagot);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(609, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 90);
            this.panel5.TabIndex = 2;
            // 
            // txtbxpagot
            // 
            this.txtbxpagot.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxpagot.Location = new System.Drawing.Point(39, 24);
            this.txtbxpagot.Name = "txtbxpagot";
            this.txtbxpagot.ReadOnly = true;
            this.txtbxpagot.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxpagot.Size = new System.Drawing.Size(200, 22);
            this.txtbxpagot.TabIndex = 0;
            this.txtbxpagot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxpagot.TextChanged += new System.EventHandler(this.txtbxpagot_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Pago:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 49);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscarCodigo, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, -3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(862, 26);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(89, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(692, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(606, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.txtbxCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBxCantidad, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBxprecio, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.AggFac, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbxDesc, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 26);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // txtbxCodigo
            // 
            this.txtbxCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxCodigo.Location = new System.Drawing.Point(3, 3);
            this.txtbxCodigo.Name = "txtbxCodigo";
            this.txtbxCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtbxCodigo.TabIndex = 0;
            // 
            // txtBxCantidad
            // 
            this.txtBxCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBxCantidad.Location = new System.Drawing.Point(606, 3);
            this.txtBxCantidad.Name = "txtBxCantidad";
            this.txtBxCantidad.Size = new System.Drawing.Size(80, 20);
            this.txtBxCantidad.TabIndex = 2;
            // 
            // txtBxprecio
            // 
            this.txtBxprecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBxprecio.Location = new System.Drawing.Point(692, 3);
            this.txtBxprecio.Name = "txtBxprecio";
            this.txtBxprecio.ReadOnly = true;
            this.txtBxprecio.Size = new System.Drawing.Size(123, 20);
            this.txtBxprecio.TabIndex = 3;
            // 
            // AggFac
            // 
            this.AggFac.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AggFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AggFac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AggFac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AggFac.Location = new System.Drawing.Point(821, 3);
            this.AggFac.Name = "AggFac";
            this.AggFac.Size = new System.Drawing.Size(38, 20);
            this.AggFac.TabIndex = 4;
            this.AggFac.Text = "+";
            this.AggFac.UseVisualStyleBackColor = false;
            this.AggFac.Click += new System.EventHandler(this.AggFac_Click);
            // 
            // txtbxDesc
            // 
            this.txtbxDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxDesc.Location = new System.Drawing.Point(89, 3);
            this.txtbxDesc.Name = "txtbxDesc";
            this.txtbxDesc.ReadOnly = true;
            this.txtbxDesc.Size = new System.Drawing.Size(511, 20);
            this.txtbxDesc.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(862, 102);
            this.panel2.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.masCiente);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.txtNombreCliente);
            this.panel9.Controls.Add(this.txtBuscarCliente);
            this.panel9.Controls.Add(this.button2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(662, 15);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(185, 72);
            this.panel9.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(6, 44);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(126, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(6, 17);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(126, 20);
            this.txtBuscarCliente.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(60, 43);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(196, 36);
            this.panel7.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "FACTURACIÓN";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::_14mayproyecrep.Properties.Resources.eliminar16;
            this.button4.Location = new System.Drawing.Point(39, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "Borrar Fac";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::_14mayproyecrep.Properties.Resources.total16;
            this.button3.Location = new System.Drawing.Point(150, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "Enviar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCodigo.Image = global::_14mayproyecrep.Properties.Resources.lupa16;
            this.btnBuscarCodigo.Location = new System.Drawing.Point(821, 3);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(38, 20);
            this.btnBuscarCodigo.TabIndex = 6;
            this.btnBuscarCodigo.UseVisualStyleBackColor = false;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // masCiente
            // 
            this.masCiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.masCiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.masCiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masCiente.Image = global::_14mayproyecrep.Properties.Resources.mas216;
            this.masCiente.Location = new System.Drawing.Point(163, 17);
            this.masCiente.Name = "masCiente";
            this.masCiente.Size = new System.Drawing.Size(19, 20);
            this.masCiente.TabIndex = 6;
            this.masCiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.masCiente.UseVisualStyleBackColor = false;
            this.masCiente.Click += new System.EventHandler(this.masCiente_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::_14mayproyecrep.Properties.Resources.lupa16;
            this.button2.Location = new System.Drawing.Point(138, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 20);
            this.button2.TabIndex = 5;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::_14mayproyecrep.Properties.Resources.actualizar_24;
            this.button1.Location = new System.Drawing.Point(21, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 7;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::_14mayproyecrep.Properties.Resources.Factura64;
            this.pictureBox1.Location = new System.Drawing.Point(18, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 586);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFacturacion";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AggFac;
        private System.Windows.Forms.TextBox txtBxprecio;
        private System.Windows.Forms.TextBox txtBxCantidad;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtbxCodigo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxpagot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView listafac;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbxDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button masCiente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader persona;
        private System.Windows.Forms.Button button4;
    }
}