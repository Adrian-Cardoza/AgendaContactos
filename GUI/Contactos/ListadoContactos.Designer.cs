namespace GUI.Contactos
{
    partial class ListadoContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoContactos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnEditarContacto = new System.Windows.Forms.Button();
            this.btnAñadirContacto = new System.Windows.Forms.Button();
            this.dgvListadoContactos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnDashboard);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(768, 20);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(259, 28);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Volver al Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "AGENDA DE CONTACTOS ";
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarContacto.Location = new System.Drawing.Point(649, 354);
            this.btnEliminarContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(208, 37);
            this.btnEliminarContacto.TabIndex = 12;
            this.btnEliminarContacto.Text = "ELIMINAR CONTACTO";
            this.btnEliminarContacto.UseVisualStyleBackColor = false;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContacto.Location = new System.Drawing.Point(433, 354);
            this.btnEditarContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Size = new System.Drawing.Size(208, 37);
            this.btnEditarContacto.TabIndex = 11;
            this.btnEditarContacto.Text = "EDITAR CONTACTO";
            this.btnEditarContacto.UseVisualStyleBackColor = false;
            this.btnEditarContacto.Click += new System.EventHandler(this.btnEditarContacto_Click);
            // 
            // btnAñadirContacto
            // 
            this.btnAñadirContacto.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAñadirContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirContacto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAñadirContacto.Location = new System.Drawing.Point(217, 354);
            this.btnAñadirContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadirContacto.Name = "btnAñadirContacto";
            this.btnAñadirContacto.Size = new System.Drawing.Size(208, 37);
            this.btnAñadirContacto.TabIndex = 10;
            this.btnAñadirContacto.Text = "AÑADIR CONTACTO";
            this.btnAñadirContacto.UseVisualStyleBackColor = false;
            this.btnAñadirContacto.Click += new System.EventHandler(this.btnAñadirContacto_Click);
            // 
            // dgvListadoContactos
            // 
            this.dgvListadoContactos.AllowUserToAddRows = false;
            this.dgvListadoContactos.AllowUserToDeleteRows = false;
            this.dgvListadoContactos.AllowUserToOrderColumns = true;
            this.dgvListadoContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoContactos.Location = new System.Drawing.Point(16, 110);
            this.dgvListadoContactos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvListadoContactos.Name = "dgvListadoContactos";
            this.dgvListadoContactos.ReadOnly = true;
            this.dgvListadoContactos.RowHeadersWidth = 62;
            this.dgvListadoContactos.Size = new System.Drawing.Size(1035, 238);
            this.dgvListadoContactos.TabIndex = 9;
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscar.Location = new System.Drawing.Point(16, 78);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(785, 22);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.Text = "Buscar un Contacto";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // ListadoContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.fondo_de_agenda_contactos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarContacto);
            this.Controls.Add(this.btnEditarContacto);
            this.Controls.Add(this.btnAñadirContacto);
            this.Controls.Add(this.dgvListadoContactos);
            this.Controls.Add(this.txtBuscar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoContactos";
            this.Text = "ListadoContactos";
            this.Load += new System.EventHandler(this.ListadoContactos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarContacto;
        private System.Windows.Forms.Button btnEditarContacto;
        private System.Windows.Forms.Button btnAñadirContacto;
        private System.Windows.Forms.DataGridView dgvListadoContactos;
        private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Button btnDashboard;
	}
}