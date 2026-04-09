namespace GUI.Contactos
{
    partial class EditarContacto
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
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DireccionTextoAgregarContacto = new System.Windows.Forms.Label();
            this.CorreoTextoAgregarContacto = new System.Windows.Forms.Label();
            this.TelefonoTextoAgregarContacto = new System.Windows.Forms.Label();
            this.nombreTextoAgregarContacto = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.BackColor = System.Drawing.Color.IndianRed;
            this.buttoncancelar.Location = new System.Drawing.Point(870, 227);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(176, 68);
            this.buttoncancelar.TabIndex = 11;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditar.Location = new System.Drawing.Point(870, 111);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(176, 68);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editar Contacto";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.DireccionTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.CorreoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.TelefonoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.nombreTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 370);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // DireccionTextoAgregarContacto
            // 
            this.DireccionTextoAgregarContacto.AutoSize = true;
            this.DireccionTextoAgregarContacto.Location = new System.Drawing.Point(27, 302);
            this.DireccionTextoAgregarContacto.Name = "DireccionTextoAgregarContacto";
            this.DireccionTextoAgregarContacto.Size = new System.Drawing.Size(79, 20);
            this.DireccionTextoAgregarContacto.TabIndex = 16;
            this.DireccionTextoAgregarContacto.Text = "Dirección:";
            // 
            // CorreoTextoAgregarContacto
            // 
            this.CorreoTextoAgregarContacto.AutoSize = true;
            this.CorreoTextoAgregarContacto.Location = new System.Drawing.Point(27, 218);
            this.CorreoTextoAgregarContacto.Name = "CorreoTextoAgregarContacto";
            this.CorreoTextoAgregarContacto.Size = new System.Drawing.Size(61, 20);
            this.CorreoTextoAgregarContacto.TabIndex = 15;
            this.CorreoTextoAgregarContacto.Text = "Correo:";
            // 
            // TelefonoTextoAgregarContacto
            // 
            this.TelefonoTextoAgregarContacto.AutoSize = true;
            this.TelefonoTextoAgregarContacto.Location = new System.Drawing.Point(27, 137);
            this.TelefonoTextoAgregarContacto.Name = "TelefonoTextoAgregarContacto";
            this.TelefonoTextoAgregarContacto.Size = new System.Drawing.Size(75, 20);
            this.TelefonoTextoAgregarContacto.TabIndex = 14;
            this.TelefonoTextoAgregarContacto.Text = "Teléfono:";
            // 
            // nombreTextoAgregarContacto
            // 
            this.nombreTextoAgregarContacto.AutoSize = true;
            this.nombreTextoAgregarContacto.Location = new System.Drawing.Point(27, 48);
            this.nombreTextoAgregarContacto.Name = "nombreTextoAgregarContacto";
            this.nombreTextoAgregarContacto.Size = new System.Drawing.Size(69, 20);
            this.nombreTextoAgregarContacto.TabIndex = 13;
            this.nombreTextoAgregarContacto.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(141, 297);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(566, 26);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(141, 213);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(566, 26);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(141, 132);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(566, 26);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(566, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // EditarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 441);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditarContacto";
            this.Text = "EditarContacto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DireccionTextoAgregarContacto;
        private System.Windows.Forms.Label CorreoTextoAgregarContacto;
        private System.Windows.Forms.Label TelefonoTextoAgregarContacto;
        private System.Windows.Forms.Label nombreTextoAgregarContacto;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
    }
}