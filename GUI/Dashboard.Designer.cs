namespace GUI
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.lblNombreUsuario = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.btnListadoContactos = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNombreUsuario
			// 
			this.lblNombreUsuario.AutoSize = true;
			this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
			this.lblNombreUsuario.Location = new System.Drawing.Point(7, 14);
			this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNombreUsuario.Name = "lblNombreUsuario";
			this.lblNombreUsuario.Size = new System.Drawing.Size(71, 20);
			this.lblNombreUsuario.TabIndex = 1;
			this.lblNombreUsuario.Text = "Usuario";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.btnListadoContactos);
			this.panel1.Location = new System.Drawing.Point(12, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(509, 224);
			this.panel1.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.button2.BackgroundImage = global::GUI.Properties.Resources.agregarContacto;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(261, 15);
			this.button2.Name = "button2";
			this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button2.Size = new System.Drawing.Size(233, 168);
			this.button2.TabIndex = 1;
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnListadoContactos
			// 
			this.btnListadoContactos.BackColor = System.Drawing.Color.Plum;
			this.btnListadoContactos.BackgroundImage = global::GUI.Properties.Resources.contact;
			this.btnListadoContactos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnListadoContactos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListadoContactos.FlatAppearance.BorderSize = 0;
			this.btnListadoContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListadoContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListadoContactos.Location = new System.Drawing.Point(11, 15);
			this.btnListadoContactos.Name = "btnListadoContactos";
			this.btnListadoContactos.Size = new System.Drawing.Size(233, 168);
			this.btnListadoContactos.TabIndex = 0;
			this.btnListadoContactos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnListadoContactos.UseVisualStyleBackColor = false;
			this.btnListadoContactos.Click += new System.EventHandler(this.btnListadoContactos_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.panel2.Controls.Add(this.lblNombreUsuario);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(509, 44);
			this.panel2.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel3.Location = new System.Drawing.Point(12, 292);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(509, 71);
			this.panel3.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(84, 196);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lista de Contactos";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(319, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Agregar Nuevo Contacto";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::GUI.Properties.Resources.fondo_de_agenda_contactos;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(533, 369);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.Label lblNombreUsuario;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnListadoContactos;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}

