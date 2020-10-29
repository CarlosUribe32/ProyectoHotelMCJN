namespace FinalPOODef
{
    partial class FormReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReserva));
            this.cbtipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbhabLibres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.chkSi = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.chkHuesped = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.nmrDias = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDias)).BeginInit();
            this.SuspendLayout();
            // 
            // cbtipoHabitacion
            // 
            this.cbtipoHabitacion.BackColor = System.Drawing.SystemColors.Info;
            this.cbtipoHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipoHabitacion.FormattingEnabled = true;
            this.cbtipoHabitacion.Location = new System.Drawing.Point(18, 105);
            this.cbtipoHabitacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbtipoHabitacion.Name = "cbtipoHabitacion";
            this.cbtipoHabitacion.Size = new System.Drawing.Size(158, 28);
            this.cbtipoHabitacion.TabIndex = 0;
            this.cbtipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cbtipoHabitacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el tipo de habitacion";
            // 
            // cbhabLibres
            // 
            this.cbhabLibres.BackColor = System.Drawing.SystemColors.Info;
            this.cbhabLibres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhabLibres.FormattingEnabled = true;
            this.cbhabLibres.Location = new System.Drawing.Point(18, 197);
            this.cbhabLibres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbhabLibres.Name = "cbhabLibres";
            this.cbhabLibres.Size = new System.Drawing.Size(127, 28);
            this.cbhabLibres.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Habitaciones libres";
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(392, 340);
            this.btnReservar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(411, 66);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // chkSi
            // 
            this.chkSi.AutoSize = true;
            this.chkSi.Location = new System.Drawing.Point(466, 186);
            this.chkSi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSi.Name = "chkSi";
            this.chkSi.Size = new System.Drawing.Size(49, 24);
            this.chkSi.TabIndex = 6;
            this.chkSi.Text = "Si";
            this.chkSi.UseVisualStyleBackColor = true;
            this.chkSi.CheckedChanged += new System.EventHandler(this.chkSi_CheckedChanged);
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Location = new System.Drawing.Point(466, 222);
            this.chkNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(55, 24);
            this.chkNo.TabIndex = 7;
            this.chkNo.Text = "No";
            this.chkNo.UseVisualStyleBackColor = true;
            this.chkNo.CheckedChanged += new System.EventHandler(this.chkNo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿Es colombiano?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "¿Es huesped o cliente?";
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Location = new System.Drawing.Point(465, 297);
            this.chkCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(84, 24);
            this.chkCliente.TabIndex = 11;
            this.chkCliente.Text = "Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            this.chkCliente.CheckedChanged += new System.EventHandler(this.chkCliente_CheckedChanged);
            // 
            // chkHuesped
            // 
            this.chkHuesped.AutoSize = true;
            this.chkHuesped.Location = new System.Drawing.Point(465, 262);
            this.chkHuesped.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHuesped.Name = "chkHuesped";
            this.chkHuesped.Size = new System.Drawing.Size(100, 24);
            this.chkHuesped.TabIndex = 10;
            this.chkHuesped.Text = "Huesped";
            this.chkHuesped.UseVisualStyleBackColor = true;
            this.chkHuesped.CheckedChanged += new System.EventHandler(this.chkHuesped_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ingrese su nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(554, 71);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(420, 30);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ingrese su cedula o ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Info;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(554, 125);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(420, 30);
            this.txtId.TabIndex = 15;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrDias
            // 
            this.nmrDias.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nmrDias.Location = new System.Drawing.Point(974, 257);
            this.nmrDias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmrDias.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nmrDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrDias.Name = "nmrDias";
            this.nmrDias.ReadOnly = true;
            this.nmrDias.Size = new System.Drawing.Size(56, 26);
            this.nmrDias.TabIndex = 16;
            this.nmrDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "¿De cuantos dias es su estadia?";
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1162, 398);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmrDias);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkCliente);
            this.Controls.Add(this.chkHuesped);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkSi);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbhabLibres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtipoHabitacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1184, 454);
            this.MinimumSize = new System.Drawing.Size(1184, 454);
            this.Name = "FormReserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbtipoHabitacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbhabLibres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.CheckBox chkSi;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.CheckBox chkHuesped;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.NumericUpDown nmrDias;
        private System.Windows.Forms.Label label7;
    }
}