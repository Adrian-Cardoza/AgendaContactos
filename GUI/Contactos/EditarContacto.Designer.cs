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
            this.buttoncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancelar.Location = new System.Drawing.Point(771, 211);
            this.buttoncancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(156, 54);
            this.buttoncancelar.TabIndex = 11;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(755, 126);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(189, 60);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editar Contacto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.DireccionTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.CorreoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.TelefonoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.nombreTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(11, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(703, 280);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // DireccionTextoAgregarContacto
            // 
            this.DireccionTextoAgregarContacto.AutoSize = true;
            this.DireccionTextoAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionTextoAgregarContacto.Location = new System.Drawing.Point(12, 224);
            this.DireccionTextoAgregarContacto.Name = "DireccionTextoAgregarContacto";
            this.DireccionTextoAgregarContacto.Size = new System.Drawing.Size(121, 29);
            this.DireccionTextoAgregarContacto.TabIndex = 16;
            this.DireccionTextoAgregarContacto.Text = "Dirección:";
            // 
            // CorreoTextoAgregarContacto
            // 
            this.CorreoTextoAgregarContacto.AutoSize = true;
            this.CorreoTextoAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoTextoAgregarContacto.Location = new System.Drawing.Point(12, 163);
            this.CorreoTextoAgregarContacto.Name = "CorreoTextoAgregarContacto";
            this.CorreoTextoAgregarContacto.Size = new System.Drawing.Size(94, 29);
            this.CorreoTextoAgregarContacto.TabIndex = 15;
            this.CorreoTextoAgregarContacto.Text = "Correo:";
            // 
            // TelefonoTextoAgregarContacto
            // 
            this.TelefonoTextoAgregarContacto.AutoSize = true;
            this.TelefonoTextoAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoTextoAgregarContacto.Location = new System.Drawing.Point(12, 99);
            this.TelefonoTextoAgregarContacto.Name = "TelefonoTextoAgregarContacto";
            this.TelefonoTextoAgregarContacto.Size = new System.Drawing.Size(116, 29);
            this.TelefonoTextoAgregarContacto.TabIndex = 14;
            this.TelefonoTextoAgregarContacto.Text = "Teléfono:";
            // 
            // nombreTextoAgregarContacto
            // 
            this.nombreTextoAgregarContacto.AutoSize = true;
            this.nombreTextoAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextoAgregarContacto.Location = new System.Drawing.Point(12, 27);
            this.nombreTextoAgregarContacto.Name = "nombreTextoAgregarContacto";
            this.nombreTextoAgregarContacto.Size = new System.Drawing.Size(107, 29);
            this.nombreTextoAgregarContacto.TabIndex = 13;
            this.nombreTextoAgregarContacto.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(139, 231);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(450, 22);
            this.txtDireccion.TabIndex = 12;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(139, 170);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(396, 22);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(139, 99);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(251, 22);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 34);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(469, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // EditarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo_de_agenda_contactos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 353);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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