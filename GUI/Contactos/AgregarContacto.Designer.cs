namespace GUI.Contactos
{
    partial class AgregarContacto
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DireccionTextoAgregarContacto = new System.Windows.Forms.Label();
            this.CorreoTextoAgregarContacto = new System.Windows.Forms.Label();
            this.TelefonoTextoAgregarContacto = new System.Windows.Forms.Label();
            this.nombreTextoAgregarContacto = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar Contacto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.DireccionTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.CorreoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.TelefonoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.nombreTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 370);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DireccionTextoAgregarContacto
            // 
            this.DireccionTextoAgregarContacto.AutoSize = true;
            this.DireccionTextoAgregarContacto.Location = new System.Drawing.Point(27, 302);
            this.DireccionTextoAgregarContacto.Name = "DireccionTextoAgregarContacto";
            this.DireccionTextoAgregarContacto.Size = new System.Drawing.Size(109, 25);
            this.DireccionTextoAgregarContacto.TabIndex = 16;
            this.DireccionTextoAgregarContacto.Text = "Dirección:";
            // 
            // CorreoTextoAgregarContacto
            // 
            this.CorreoTextoAgregarContacto.AutoSize = true;
            this.CorreoTextoAgregarContacto.Location = new System.Drawing.Point(27, 218);
            this.CorreoTextoAgregarContacto.Name = "CorreoTextoAgregarContacto";
            this.CorreoTextoAgregarContacto.Size = new System.Drawing.Size(85, 25);
            this.CorreoTextoAgregarContacto.TabIndex = 15;
            this.CorreoTextoAgregarContacto.Text = "Correo:";
            // 
            // TelefonoTextoAgregarContacto
            // 
            this.TelefonoTextoAgregarContacto.AutoSize = true;
            this.TelefonoTextoAgregarContacto.Location = new System.Drawing.Point(27, 137);
            this.TelefonoTextoAgregarContacto.Name = "TelefonoTextoAgregarContacto";
            this.TelefonoTextoAgregarContacto.Size = new System.Drawing.Size(104, 25);
            this.TelefonoTextoAgregarContacto.TabIndex = 14;
            this.TelefonoTextoAgregarContacto.Text = "Teléfono:";
            this.TelefonoTextoAgregarContacto.Click += new System.EventHandler(this.label3_Click);
            // 
            // nombreTextoAgregarContacto
            // 
            this.nombreTextoAgregarContacto.AutoSize = true;
            this.nombreTextoAgregarContacto.Location = new System.Drawing.Point(27, 48);
            this.nombreTextoAgregarContacto.Name = "nombreTextoAgregarContacto";
            this.nombreTextoAgregarContacto.Size = new System.Drawing.Size(94, 25);
            this.nombreTextoAgregarContacto.TabIndex = 13;
            this.nombreTextoAgregarContacto.Text = "Nombre:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 297);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(566, 30);
            this.textBox4.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(566, 30);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(566, 30);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(566, 30);
            this.textBox3.TabIndex = 11;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonAgregar.Location = new System.Drawing.Point(870, 134);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(176, 68);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.BackColor = System.Drawing.Color.IndianRed;
            this.buttoncancelar.Location = new System.Drawing.Point(870, 250);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(176, 68);
            this.buttoncancelar.TabIndex = 7;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            // 
            // AgregarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 468);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AgregarContacto";
            this.Text = "AgregarContacto";
            this.Load += new System.EventHandler(this.AgregarContacto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DireccionTextoAgregarContacto;
        private System.Windows.Forms.Label CorreoTextoAgregarContacto;
        private System.Windows.Forms.Label TelefonoTextoAgregarContacto;
        private System.Windows.Forms.Label nombreTextoAgregarContacto;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttoncancelar;
    }
}