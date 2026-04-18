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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarContacto));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.nombreTextoAgregarContacto = new System.Windows.Forms.Label();
            this.TelefonoTextoAgregarContacto = new System.Windows.Forms.Label();
            this.CorreoTextoAgregarContacto = new System.Windows.Forms.Label();
            this.DireccionTextoAgregarContacto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar Contacto";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(138)))));
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Location = new System.Drawing.Point(870, 134);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(176, 68);
            this.buttonAgregar.TabIndex = 6;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttoncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncancelar.Location = new System.Drawing.Point(870, 250);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(176, 68);
            this.buttoncancelar.TabIndex = 7;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = false;
            this.buttoncancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 373);
            this.panel1.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(141, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(566, 35);
            this.txtNombre.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.Location = new System.Drawing.Point(141, 131);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(566, 35);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Location = new System.Drawing.Point(141, 213);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(566, 35);
            this.txtCorreo.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.Location = new System.Drawing.Point(141, 297);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(566, 35);
            this.txtDireccion.TabIndex = 12;
            // 
            // nombreTextoAgregarContacto
            // 
            this.nombreTextoAgregarContacto.AutoSize = true;
            this.nombreTextoAgregarContacto.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreTextoAgregarContacto.Location = new System.Drawing.Point(27, 48);
            this.nombreTextoAgregarContacto.Name = "nombreTextoAgregarContacto";
            this.nombreTextoAgregarContacto.Size = new System.Drawing.Size(114, 29);
            this.nombreTextoAgregarContacto.TabIndex = 13;
            this.nombreTextoAgregarContacto.Text = "Nombre:";
            // 
            // TelefonoTextoAgregarContacto
            // 
            this.TelefonoTextoAgregarContacto.AutoSize = true;
            this.TelefonoTextoAgregarContacto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TelefonoTextoAgregarContacto.Location = new System.Drawing.Point(27, 137);
            this.TelefonoTextoAgregarContacto.Name = "TelefonoTextoAgregarContacto";
            this.TelefonoTextoAgregarContacto.Size = new System.Drawing.Size(125, 29);
            this.TelefonoTextoAgregarContacto.TabIndex = 14;
            this.TelefonoTextoAgregarContacto.Text = "Teléfono:";
            // 
            // CorreoTextoAgregarContacto
            // 
            this.CorreoTextoAgregarContacto.AutoSize = true;
            this.CorreoTextoAgregarContacto.ForeColor = System.Drawing.SystemColors.Control;
            this.CorreoTextoAgregarContacto.Location = new System.Drawing.Point(27, 218);
            this.CorreoTextoAgregarContacto.Name = "CorreoTextoAgregarContacto";
            this.CorreoTextoAgregarContacto.Size = new System.Drawing.Size(101, 29);
            this.CorreoTextoAgregarContacto.TabIndex = 15;
            this.CorreoTextoAgregarContacto.Text = "Correo:";
            // 
            // DireccionTextoAgregarContacto
            // 
            this.DireccionTextoAgregarContacto.AutoSize = true;
            this.DireccionTextoAgregarContacto.ForeColor = System.Drawing.SystemColors.Control;
            this.DireccionTextoAgregarContacto.Location = new System.Drawing.Point(27, 302);
            this.DireccionTextoAgregarContacto.Name = "DireccionTextoAgregarContacto";
            this.DireccionTextoAgregarContacto.Size = new System.Drawing.Size(131, 29);
            this.DireccionTextoAgregarContacto.TabIndex = 16;
            this.DireccionTextoAgregarContacto.Text = "Dirección:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.DireccionTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.CorreoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.TelefonoTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.nombreTextoAgregarContacto);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(28, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 373);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // AgregarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo_de_agenda_contactos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 468);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarContacto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttoncancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label nombreTextoAgregarContacto;
        private System.Windows.Forms.Label TelefonoTextoAgregarContacto;
        private System.Windows.Forms.Label CorreoTextoAgregarContacto;
        private System.Windows.Forms.Label DireccionTextoAgregarContacto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}