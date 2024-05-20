
namespace _14mayproyecrep
{
    partial class FrmCliente
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDClie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreClie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ApellidoClie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CorreoCLi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefonocli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DireccionClie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NuevoClie = new System.Windows.Forms.Button();
            this.RefrescarClie = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 617);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDClie,
            this.NombreClie,
            this.ApellidoClie,
            this.CorreoCLi,
            this.Telefonocli,
            this.DireccionClie});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 74);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(950, 543);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IDClie
            // 
            this.IDClie.Text = "ID";
            this.IDClie.Width = 37;
            // 
            // NombreClie
            // 
            this.NombreClie.Text = "Nombre";
            this.NombreClie.Width = 145;
            // 
            // ApellidoClie
            // 
            this.ApellidoClie.Text = "Apellido";
            this.ApellidoClie.Width = 159;
            // 
            // CorreoCLi
            // 
            this.CorreoCLi.Text = "Correo";
            this.CorreoCLi.Width = 208;
            // 
            // Telefonocli
            // 
            this.Telefonocli.Text = "Telefono";
            this.Telefonocli.Width = 209;
            // 
            // DireccionClie
            // 
            this.DireccionClie.Tag = "";
            this.DireccionClie.Text = "Dirección";
            this.DireccionClie.Width = 242;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(950, 74);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NuevoClie);
            this.panel3.Controls.Add(this.RefrescarClie);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(782, 6);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(162, 62);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // NuevoClie
            // 
            this.NuevoClie.BackColor = System.Drawing.Color.White;
            this.NuevoClie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NuevoClie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoClie.Dock = System.Windows.Forms.DockStyle.Left;
            this.NuevoClie.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoClie.Image = global::_14mayproyecrep.Properties.Resources.nuevo_24;
            this.NuevoClie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoClie.Location = new System.Drawing.Point(6, 6);
            this.NuevoClie.Name = "NuevoClie";
            this.NuevoClie.Size = new System.Drawing.Size(69, 50);
            this.NuevoClie.TabIndex = 2;
            this.NuevoClie.Text = "&Nuevo";
            this.NuevoClie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoClie.UseVisualStyleBackColor = false;
            this.NuevoClie.Click += new System.EventHandler(this.button2_Click);
            // 
            // RefrescarClie
            // 
            this.RefrescarClie.BackColor = System.Drawing.Color.White;
            this.RefrescarClie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefrescarClie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefrescarClie.Dock = System.Windows.Forms.DockStyle.Right;
            this.RefrescarClie.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefrescarClie.Image = global::_14mayproyecrep.Properties.Resources.actualizar_24;
            this.RefrescarClie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RefrescarClie.Location = new System.Drawing.Point(81, 6);
            this.RefrescarClie.Name = "RefrescarClie";
            this.RefrescarClie.Size = new System.Drawing.Size(75, 50);
            this.RefrescarClie.TabIndex = 0;
            this.RefrescarClie.Text = "&Refrescar";
            this.RefrescarClie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RefrescarClie.UseVisualStyleBackColor = false;
            this.RefrescarClie.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_14mayproyecrep.Properties.Resources.cliente_64;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 617);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCliente";
            this.Text = "Formulario Cliente";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDClie;
        private System.Windows.Forms.ColumnHeader NombreClie;
        private System.Windows.Forms.ColumnHeader ApellidoClie;
        private System.Windows.Forms.ColumnHeader CorreoCLi;
        private System.Windows.Forms.ColumnHeader Telefonocli;
        private System.Windows.Forms.ColumnHeader DireccionClie;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RefrescarClie;
        protected internal System.Windows.Forms.Button NuevoClie;
    }
}