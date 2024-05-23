
namespace _14mayproyecrep
{
    partial class FrmProductos
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
            this.listViewPro = new System.Windows.Forms.ListView();
            this.idPro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Precioo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewPro = new System.Windows.Forms.Button();
            this.Refrescar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewPro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // listViewPro
            // 
            this.listViewPro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewPro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPro,
            this.nombre,
            this.Precioo,
            this.Categoria,
            this.SubCategoria});
            this.listViewPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPro.GridLines = true;
            this.listViewPro.HideSelection = false;
            this.listViewPro.Location = new System.Drawing.Point(0, 62);
            this.listViewPro.MultiSelect = false;
            this.listViewPro.Name = "listViewPro";
            this.listViewPro.Size = new System.Drawing.Size(800, 388);
            this.listViewPro.TabIndex = 0;
            this.listViewPro.UseCompatibleStateImageBehavior = false;
            this.listViewPro.View = System.Windows.Forms.View.Details;
            this.listViewPro.SelectedIndexChanged += new System.EventHandler(this.listViewPro_SelectedIndexChanged);
            // 
            // idPro
            // 
            this.idPro.Text = "Id";
            this.idPro.Width = 55;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 200;
            // 
            // Precioo
            // 
            this.Precioo.Text = "Precio";
            this.Precioo.Width = 150;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 120;
            // 
            // SubCategoria
            // 
            this.SubCategoria.Text = "SubCategoria";
            this.SubCategoria.Width = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNewPro);
            this.panel3.Controls.Add(this.Refrescar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(638, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(162, 62);
            this.panel3.TabIndex = 2;
            // 
            // btnNewPro
            // 
            this.btnNewPro.BackColor = System.Drawing.Color.White;
            this.btnNewPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNewPro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPro.Image = global::_14mayproyecrep.Properties.Resources.nuevo_24;
            this.btnNewPro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewPro.Location = new System.Drawing.Point(6, 6);
            this.btnNewPro.Name = "btnNewPro";
            this.btnNewPro.Size = new System.Drawing.Size(69, 50);
            this.btnNewPro.TabIndex = 2;
            this.btnNewPro.Text = "&Nuevo";
            this.btnNewPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewPro.UseVisualStyleBackColor = false;
            this.btnNewPro.Click += new System.EventHandler(this.btnNewPro_Click);
            // 
            // Refrescar
            // 
            this.Refrescar.BackColor = System.Drawing.Color.White;
            this.Refrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Refrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refrescar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Refrescar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refrescar.Image = global::_14mayproyecrep.Properties.Resources.actualizar_24;
            this.Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Refrescar.Location = new System.Drawing.Point(81, 6);
            this.Refrescar.Name = "Refrescar";
            this.Refrescar.Size = new System.Drawing.Size(75, 50);
            this.Refrescar.TabIndex = 0;
            this.Refrescar.Text = "&Refrescar";
            this.Refrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Refrescar.UseVisualStyleBackColor = false;
            this.Refrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::_14mayproyecrep.Properties.Resources.productos64;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProductos";
            this.Text = "Productos";
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
        private System.Windows.Forms.ListView listViewPro;
        private System.Windows.Forms.Panel panel3;
        protected internal System.Windows.Forms.Button btnNewPro;
        private System.Windows.Forms.Button Refrescar;
        private System.Windows.Forms.ColumnHeader idPro;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader Precioo;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader SubCategoria;
    }
}