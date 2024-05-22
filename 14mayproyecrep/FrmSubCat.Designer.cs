
namespace _14mayproyecrep
{
    partial class FrmSubCat
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
            this.listViSubc = new System.Windows.Forms.ListView();
            this.idsubcat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreSubcat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idcatego = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newSubcat = new System.Windows.Forms.Button();
            this.Refrescar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViSubc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 491);
            this.panel1.TabIndex = 0;
            // 
            // listViSubc
            // 
            this.listViSubc.BackColor = System.Drawing.Color.Gainsboro;
            this.listViSubc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViSubc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idsubcat,
            this.NombreSubcat,
            this.idcatego,
            this.columnHeader1});
            this.listViSubc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViSubc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listViSubc.GridLines = true;
            this.listViSubc.HideSelection = false;
            this.listViSubc.Location = new System.Drawing.Point(0, 74);
            this.listViSubc.MultiSelect = false;
            this.listViSubc.Name = "listViSubc";
            this.listViSubc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listViSubc.Size = new System.Drawing.Size(823, 417);
            this.listViSubc.TabIndex = 0;
            this.listViSubc.UseCompatibleStateImageBehavior = false;
            this.listViSubc.View = System.Windows.Forms.View.Details;
            this.listViSubc.SelectedIndexChanged += new System.EventHandler(this.listViSubc_SelectedIndexChanged);
            // 
            // idsubcat
            // 
            this.idsubcat.Text = "ID";
            this.idsubcat.Width = 42;
            // 
            // NombreSubcat
            // 
            this.NombreSubcat.Text = "NOMBRE";
            this.NombreSubcat.Width = 300;
            // 
            // idcatego
            // 
            this.idcatego.Text = "CATEGORIA";
            this.idcatego.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Categoria";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 77;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(823, 74);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newSubcat);
            this.panel3.Controls.Add(this.Refrescar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(667, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 54);
            this.panel3.TabIndex = 2;
            // 
            // newSubcat
            // 
            this.newSubcat.BackColor = System.Drawing.Color.White;
            this.newSubcat.Dock = System.Windows.Forms.DockStyle.Left;
            this.newSubcat.Image = global::_14mayproyecrep.Properties.Resources.nuevo_24;
            this.newSubcat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newSubcat.Location = new System.Drawing.Point(0, 0);
            this.newSubcat.Name = "newSubcat";
            this.newSubcat.Size = new System.Drawing.Size(68, 54);
            this.newSubcat.TabIndex = 1;
            this.newSubcat.Text = "&Nuevo";
            this.newSubcat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newSubcat.UseVisualStyleBackColor = false;
            this.newSubcat.Click += new System.EventHandler(this.newSubcat_Click);
            // 
            // Refrescar
            // 
            this.Refrescar.BackColor = System.Drawing.Color.White;
            this.Refrescar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Refrescar.Image = global::_14mayproyecrep.Properties.Resources.actualizar_24;
            this.Refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Refrescar.Location = new System.Drawing.Point(78, 0);
            this.Refrescar.Name = "Refrescar";
            this.Refrescar.Size = new System.Drawing.Size(68, 54);
            this.Refrescar.TabIndex = 0;
            this.Refrescar.Text = "Refrescar";
            this.Refrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Refrescar.UseVisualStyleBackColor = false;
            this.Refrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sub-Categoria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::_14mayproyecrep.Properties.Resources.subcat_64;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSubCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 491);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSubCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario SubCategoria";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViSubc;
        private System.Windows.Forms.ColumnHeader idsubcat;
        private System.Windows.Forms.ColumnHeader NombreSubcat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button newSubcat;
        private System.Windows.Forms.Button Refrescar;
        private System.Windows.Forms.ColumnHeader idcatego;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}