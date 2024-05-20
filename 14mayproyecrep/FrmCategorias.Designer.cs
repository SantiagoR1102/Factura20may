
namespace _14mayproyecrep
{
    partial class FrmCategorias
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
            this.Panel_1_Superior = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel_2_Imagen = new System.Windows.Forms.Panel();
            this.Panel_3_Lista = new System.Windows.Forms.Panel();
            this.ListData = new System.Windows.Forms.ListView();
            this.col_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_editar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Imagen_0 = new System.Windows.Forms.PictureBox();
            this.Panel_1_Superior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Panel_2_Imagen.SuspendLayout();
            this.Panel_3_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_0)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_1_Superior
            // 
            this.Panel_1_Superior.BackColor = System.Drawing.Color.Transparent;
            this.Panel_1_Superior.Controls.Add(this.tableLayoutPanel1);
            this.Panel_1_Superior.Controls.Add(this.Panel_2_Imagen);
            this.Panel_1_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_1_Superior.Location = new System.Drawing.Point(0, 0);
            this.Panel_1_Superior.Name = "Panel_1_Superior";
            this.Panel_1_Superior.Size = new System.Drawing.Size(877, 65);
            this.Panel_1_Superior.TabIndex = 0;
            this.Panel_1_Superior.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_1_Superior_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnNuevo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(689, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 65);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Panel_2_Imagen
            // 
            this.Panel_2_Imagen.Controls.Add(this.Imagen_0);
            this.Panel_2_Imagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_2_Imagen.Location = new System.Drawing.Point(0, 0);
            this.Panel_2_Imagen.Name = "Panel_2_Imagen";
            this.Panel_2_Imagen.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_2_Imagen.Size = new System.Drawing.Size(67, 65);
            this.Panel_2_Imagen.TabIndex = 0;
            // 
            // Panel_3_Lista
            // 
            this.Panel_3_Lista.BackColor = System.Drawing.Color.Transparent;
            this.Panel_3_Lista.Controls.Add(this.ListData);
            this.Panel_3_Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_3_Lista.Location = new System.Drawing.Point(0, 65);
            this.Panel_3_Lista.Name = "Panel_3_Lista";
            this.Panel_3_Lista.Padding = new System.Windows.Forms.Padding(5);
            this.Panel_3_Lista.Size = new System.Drawing.Size(877, 499);
            this.Panel_3_Lista.TabIndex = 1;
            // 
            // ListData
            // 
            this.ListData.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ListData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Id,
            this.col_nombre,
            this.col_editar});
            this.ListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListData.ForeColor = System.Drawing.Color.White;
            this.ListData.GridLines = true;
            this.ListData.HideSelection = false;
            this.ListData.Location = new System.Drawing.Point(5, 5);
            this.ListData.MultiSelect = false;
            this.ListData.Name = "ListData";
            this.ListData.Size = new System.Drawing.Size(867, 489);
            this.ListData.TabIndex = 0;
            this.ListData.UseCompatibleStateImageBehavior = false;
            this.ListData.View = System.Windows.Forms.View.Details;
            this.ListData.SelectedIndexChanged += new System.EventHandler(this.ListData_SelectedIndexChanged);
            // 
            // col_Id
            // 
            this.col_Id.Text = "ID";
            this.col_Id.Width = 41;
            // 
            // col_nombre
            // 
            this.col_nombre.Text = "CATEGORIA";
            this.col_nombre.Width = 758;
            // 
            // col_editar
            // 
            this.col_editar.Text = "EDITAR";
            this.col_editar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::_14mayproyecrep.Properties.Resources.nuevo_24;
            this.btnNuevo.Location = new System.Drawing.Point(8, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 49);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::_14mayproyecrep.Properties.Resources.actualizar_24;
            this.button1.Location = new System.Drawing.Point(97, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Refrescar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Imagen_0
            // 
            this.Imagen_0.BackgroundImage = global::_14mayproyecrep.Properties.Resources.menu;
            this.Imagen_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_0.Location = new System.Drawing.Point(5, 5);
            this.Imagen_0.Name = "Imagen_0";
            this.Imagen_0.Size = new System.Drawing.Size(57, 55);
            this.Imagen_0.TabIndex = 0;
            this.Imagen_0.TabStop = false;
            // 
            // FrmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 564);
            this.Controls.Add(this.Panel_3_Lista);
            this.Controls.Add(this.Panel_1_Superior);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATEGORIAS";
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.Panel_1_Superior.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Panel_2_Imagen.ResumeLayout(false);
            this.Panel_3_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Imagen_0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_1_Superior;
        private System.Windows.Forms.Panel Panel_2_Imagen;
        private System.Windows.Forms.PictureBox Imagen_0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel Panel_3_Lista;
        private System.Windows.Forms.ListView ListData;
        private System.Windows.Forms.ColumnHeader col_Id;
        private System.Windows.Forms.ColumnHeader col_nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader col_editar;
    }
}