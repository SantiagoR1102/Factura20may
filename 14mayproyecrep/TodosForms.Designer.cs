
namespace _14mayproyecrep
{
    partial class TodosForms
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
            this.FormSubCat = new System.Windows.Forms.Button();
            this.FormCliente = new System.Windows.Forms.Button();
            this.FormCategoria = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProd);
            this.panel1.Controls.Add(this.FormSubCat);
            this.panel1.Controls.Add(this.FormCliente);
            this.panel1.Controls.Add(this.FormCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // FormSubCat
            // 
            this.FormSubCat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormSubCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormSubCat.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormSubCat.ForeColor = System.Drawing.Color.Black;
            this.FormSubCat.Location = new System.Drawing.Point(432, 200);
            this.FormSubCat.Name = "FormSubCat";
            this.FormSubCat.Size = new System.Drawing.Size(292, 49);
            this.FormSubCat.TabIndex = 2;
            this.FormSubCat.Text = "SubCategoria";
            this.FormSubCat.UseVisualStyleBackColor = false;
            this.FormSubCat.Click += new System.EventHandler(this.FormSubCat_Click);
            // 
            // FormCliente
            // 
            this.FormCliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCliente.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCliente.ForeColor = System.Drawing.Color.Black;
            this.FormCliente.Location = new System.Drawing.Point(137, 114);
            this.FormCliente.Name = "FormCliente";
            this.FormCliente.Size = new System.Drawing.Size(292, 49);
            this.FormCliente.TabIndex = 1;
            this.FormCliente.Text = "Cliente";
            this.FormCliente.UseVisualStyleBackColor = false;
            this.FormCliente.Click += new System.EventHandler(this.FormCliente_Click);
            // 
            // FormCategoria
            // 
            this.FormCategoria.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCategoria.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCategoria.ForeColor = System.Drawing.Color.Black;
            this.FormCategoria.Location = new System.Drawing.Point(137, 44);
            this.FormCategoria.Name = "FormCategoria";
            this.FormCategoria.Size = new System.Drawing.Size(292, 49);
            this.FormCategoria.TabIndex = 0;
            this.FormCategoria.Text = "Categoria";
            this.FormCategoria.UseVisualStyleBackColor = false;
            this.FormCategoria.Click += new System.EventHandler(this.FormCategoria_Click);
            // 
            // btnProd
            // 
            this.btnProd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.ForeColor = System.Drawing.Color.Black;
            this.btnProd.Location = new System.Drawing.Point(432, 266);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(292, 49);
            this.btnProd.TabIndex = 3;
            this.btnProd.Text = "Productos";
            this.btnProd.UseVisualStyleBackColor = false;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // TodosForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "TodosForms";
            this.Text = "TodosForms";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FormSubCat;
        private System.Windows.Forms.Button FormCliente;
        private System.Windows.Forms.Button FormCategoria;
        private System.Windows.Forms.Button btnProd;
    }
}