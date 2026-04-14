namespace GUI.Autenticacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Iniciarsesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Location = new System.Drawing.Point(28, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(287, 34);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContrasena.Location = new System.Drawing.Point(32, 153);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(283, 27);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.TextChanged += new System.EventHandler(this.Contrasena_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese su usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese su contraseña:";
            // 
            // Iniciarsesion
            // 
            this.Iniciarsesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(138)))));
            this.Iniciarsesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Iniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Iniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciarsesion.ForeColor = System.Drawing.Color.Black;
            this.Iniciarsesion.Location = new System.Drawing.Point(28, 219);
            this.Iniciarsesion.Name = "Iniciarsesion";
            this.Iniciarsesion.Size = new System.Drawing.Size(283, 43);
            this.Iniciarsesion.TabIndex = 4;
            this.Iniciarsesion.Text = "Iniciar sesion";
            this.Iniciarsesion.UseVisualStyleBackColor = false;
            this.Iniciarsesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(331, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(67, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿No estás registrado?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(87, 288);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Crear nuevo usuario";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AcceptButton = this.Iniciarsesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo_iniciosesion;
            this.ClientSize = new System.Drawing.Size(504, 322);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Iniciarsesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Click += new System.EventHandler(this.label1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Iniciarsesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}