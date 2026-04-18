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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarContacto));
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.DireccionTextoAgregarContacto = new System.Windows.Forms.Label();
            this.CorreoTextoAgregarContacto = new System.Windows.Forms.Label();
            this.TelefonoTextoAgregarContacto = new System.Windows.Forms.Label();
            this.nombreTextoAgregarContacto = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttoncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold);
            this.buttoncancelar.Location = new System.Drawing.Point(849, 263);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(213, 89);
            this.buttoncancelar.TabIndex = 11;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(138)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(849, 149);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(213, 83);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editar Contacto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.DireccionTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.CorreoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.TelefonoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.nombreTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 351);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.Location = new System.Drawing.Point(156, 278);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(608, 35);
            this.txtDireccion.TabIndex = 12;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // DireccionTextoAgregarContacto
            // 
            this.DireccionTextoAgregarContacto.AutoSize = true;
            this.DireccionTextoAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionTextoAgregarContacto.ForeColor = System.Drawing.SystemColors.Window;
            this.DireccionTextoAgregarContacto.Location = new System.Drawing.Point(3, 280);
            this.DireccionTextoAgregarContacto.Name = "DireccionTextoAgregarContacto";
            this.DireccionTextoAgregarContacto.Size = new System.Drawing.Size(151, 32);
            this.DireccionTextoAgregarContacto.TabIndex = 16;
            this.DireccionTextoAgregarContacto.Text = "Dirección:";
            // 
            // CorreoTextoAgregarContacto
            // 
            this.CorreoTextoAgregarContacto.AutoSize = true;
            this.CorreoTextoAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoTextoAgregarContacto.ForeColor = System.Drawing.SystemColors.Window;
            this.CorreoTextoAgregarContacto.Location = new System.Drawing.Point(3, 203);
            this.CorreoTextoAgregarContacto.Name = "CorreoTextoAgregarContacto";
            this.CorreoTextoAgregarContacto.Size = new System.Drawing.Size(115, 32);
            this.CorreoTextoAgregarContacto.TabIndex = 15;
            this.CorreoTextoAgregarContacto.Text = "Correo:";
            // 
            // TelefonoTextoAgregarContacto
            // 
            this.TelefonoTextoAgregarContacto.AutoSize = true;
            this.TelefonoTextoAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoTextoAgregarContacto.ForeColor = System.Drawing.SystemColors.Window;
            this.TelefonoTextoAgregarContacto.Location = new System.Drawing.Point(3, 123);
            this.TelefonoTextoAgregarContacto.Name = "TelefonoTextoAgregarContacto";
            this.TelefonoTextoAgregarContacto.Size = new System.Drawing.Size(143, 32);
            this.TelefonoTextoAgregarContacto.TabIndex = 14;
            this.TelefonoTextoAgregarContacto.Text = "Teléfono:";
            // 
            // nombreTextoAgregarContacto
            // 
            this.nombreTextoAgregarContacto.AutoSize = true;
            this.nombreTextoAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextoAgregarContacto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nombreTextoAgregarContacto.Location = new System.Drawing.Point(3, 34);
            this.nombreTextoAgregarContacto.Name = "nombreTextoAgregarContacto";
            this.nombreTextoAgregarContacto.Size = new System.Drawing.Size(129, 32);
            this.nombreTextoAgregarContacto.TabIndex = 13;
            this.nombreTextoAgregarContacto.Text = "Nombre:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Location = new System.Drawing.Point(156, 205);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(608, 35);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Location = new System.Drawing.Point(156, 123);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(608, 35);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(156, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(608, 35);
            this.txtNombre.TabIndex = 11;
            // 
            // EditarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo_de_agenda_contactos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1076, 442);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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