namespace Escenario3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnom = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.lblced = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.Columtel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(61, 55);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(44, 13);
            this.lblnom.TabIndex = 0;
            this.lblnom.Text = "Nombre";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(310, 45);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(132, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(310, 101);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(132, 101);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(100, 20);
            this.txtCed.TabIndex = 6;
            // 
            // lblced
            // 
            this.lblced.AutoSize = true;
            this.lblced.Location = new System.Drawing.Point(61, 101);
            this.lblced.Name = "lblced";
            this.lblced.Size = new System.Drawing.Size(40, 13);
            this.lblced.TabIndex = 5;
            this.lblced.Text = "Cédula";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(132, 153);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 8;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(61, 153);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(49, 13);
            this.lbltel.TabIndex = 7;
            this.lbltel.Text = "Telefono";
            // 
            // Columtel
            // 
            this.Columtel.HeaderText = "Telefono";
            this.Columtel.Name = "Columtel";
            // 
            // Columced
            // 
            this.Columced.HeaderText = "Cédula";
            this.Columced.Name = "Columced";
            // 
            // Columnom
            // 
            this.Columnom.HeaderText = "Nombre";
            this.Columnom.Name = "Columnom";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnom,
            this.Columced,
            this.Columtel});
            this.DGV.Location = new System.Drawing.Point(31, 212);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(343, 150);
            this.DGV.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 392);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.lblced);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblnom);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.Label lblced;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columtel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columced;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnom;
        private System.Windows.Forms.DataGridView DGV;
    }
}

