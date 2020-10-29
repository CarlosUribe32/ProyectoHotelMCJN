namespace FinalPOODef
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.lsbReservas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearCompra = new System.Windows.Forms.Button();
            this.lsbCompras = new System.Windows.Forms.ListBox();
            this.btnAñadirACompra = new System.Windows.Forms.Button();
            this.lsbDisponibles = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lsbitemsCompra = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbReservas
            // 
            this.lsbReservas.BackColor = System.Drawing.SystemColors.Info;
            this.lsbReservas.FormattingEnabled = true;
            this.lsbReservas.Location = new System.Drawing.Point(12, 43);
            this.lsbReservas.Name = "lsbReservas";
            this.lsbReservas.Size = new System.Drawing.Size(209, 238);
            this.lsbReservas.TabIndex = 0;
            this.lsbReservas.SelectedIndexChanged += new System.EventHandler(this.lsbReservas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de reservas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Productos/Servicios disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 3;
            // 
            // nmrCantidad
            // 
            this.nmrCantidad.BackColor = System.Drawing.SystemColors.Info;
            this.nmrCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmrCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrCantidad.Location = new System.Drawing.Point(810, 287);
            this.nmrCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCantidad.Name = "nmrCantidad";
            this.nmrCantidad.ReadOnly = true;
            this.nmrCantidad.Size = new System.Drawing.Size(70, 18);
            this.nmrCantidad.TabIndex = 4;
            this.nmrCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrCantidad.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Compras";
            // 
            // btnCrearCompra
            // 
            this.btnCrearCompra.Location = new System.Drawing.Point(416, 260);
            this.btnCrearCompra.Name = "btnCrearCompra";
            this.btnCrearCompra.Size = new System.Drawing.Size(213, 21);
            this.btnCrearCompra.TabIndex = 6;
            this.btnCrearCompra.Text = "Crear nueva compra";
            this.btnCrearCompra.UseVisualStyleBackColor = true;
            this.btnCrearCompra.Click += new System.EventHandler(this.btnCrearCompra_Click);
            // 
            // lsbCompras
            // 
            this.lsbCompras.BackColor = System.Drawing.SystemColors.Info;
            this.lsbCompras.FormattingEnabled = true;
            this.lsbCompras.Location = new System.Drawing.Point(227, 44);
            this.lsbCompras.Name = "lsbCompras";
            this.lsbCompras.Size = new System.Drawing.Size(183, 212);
            this.lsbCompras.TabIndex = 7;
            // 
            // btnAñadirACompra
            // 
            this.btnAñadirACompra.Location = new System.Drawing.Point(635, 261);
            this.btnAñadirACompra.Name = "btnAñadirACompra";
            this.btnAñadirACompra.Size = new System.Drawing.Size(169, 48);
            this.btnAñadirACompra.TabIndex = 8;
            this.btnAñadirACompra.Text = "Añadir producto/s a la compra";
            this.btnAñadirACompra.UseVisualStyleBackColor = true;
            this.btnAñadirACompra.Click += new System.EventHandler(this.btnAñadirACompra_Click);
            // 
            // lsbDisponibles
            // 
            this.lsbDisponibles.BackColor = System.Drawing.SystemColors.Info;
            this.lsbDisponibles.FormattingEnabled = true;
            this.lsbDisponibles.Location = new System.Drawing.Point(635, 43);
            this.lsbDisponibles.Name = "lsbDisponibles";
            this.lsbDisponibles.Size = new System.Drawing.Size(243, 212);
            this.lsbDisponibles.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(810, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(10, 288);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(176, 41);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lsbitemsCompra
            // 
            this.lsbitemsCompra.BackColor = System.Drawing.SystemColors.Info;
            this.lsbitemsCompra.FormattingEnabled = true;
            this.lsbitemsCompra.Location = new System.Drawing.Point(416, 44);
            this.lsbitemsCompra.Name = "lsbitemsCompra";
            this.lsbitemsCompra.Size = new System.Drawing.Size(213, 212);
            this.lsbitemsCompra.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Items de la compra";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(909, 346);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lsbitemsCompra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsbDisponibles);
            this.Controls.Add(this.btnAñadirACompra);
            this.Controls.Add(this.lsbCompras);
            this.Controls.Add(this.btnCrearCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmrCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbReservas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(925, 385);
            this.MinimumSize = new System.Drawing.Size(925, 385);
            this.Name = "FormCompra";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCrearCompra;
        private System.Windows.Forms.ListBox lsbCompras;
        private System.Windows.Forms.Button btnAñadirACompra;
        private System.Windows.Forms.ListBox lsbDisponibles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lsbitemsCompra;
        private System.Windows.Forms.Label label6;
    }
}