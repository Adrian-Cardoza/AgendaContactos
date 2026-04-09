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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditarContacto = new System.Windows.Forms.Button();
            this.btnAñadirContacto = new System.Windows.Forms.Button();
            this.dgvListadoContactos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1164, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "AGENDA DE CONTACTOS ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(730, 443);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 46);
            this.button3.TabIndex = 12;
            this.button3.Text = "ELIMINAR CONTACTO";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnEditarContacto
            // 
            this.btnEditarContacto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEditarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarContacto.Location = new System.Drawing.Point(488, 443);
            this.btnEditarContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarContacto.Name = "btnEditarContacto";
            this.btnEditarContacto.Size = new System.Drawing.Size(234, 46);
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
            this.btnAñadirContacto.Location = new System.Drawing.Point(244, 443);
            this.btnAñadirContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadirContacto.Name = "btnAñadirContacto";
            this.btnAñadirContacto.Size = new System.Drawing.Size(234, 46);
            this.btnAñadirContacto.TabIndex = 10;
            this.btnAñadirContacto.Text = "AÑADIR CONTACTO";
            this.btnAñadirContacto.UseVisualStyleBackColor = false;
            this.btnAñadirContacto.Click += new System.EventHandler(this.btnAñadirContacto_Click);
            // 
            // dgvListadoContactos
            // 
            this.dgvListadoContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoContactos.Location = new System.Drawing.Point(18, 137);
            this.dgvListadoContactos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListadoContactos.Name = "dgvListadoContactos";
            this.dgvListadoContactos.RowHeadersWidth = 62;
            this.dgvListadoContactos.Size = new System.Drawing.Size(1164, 297);
            this.dgvListadoContactos.TabIndex = 9;
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtBuscar.Location = new System.Drawing.Point(18, 97);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(883, 26);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.Text = "Buscar un Contacto";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 54);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ListadoContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditarContacto);
            this.Controls.Add(this.btnAñadirContacto);
            this.Controls.Add(this.dgvListadoContactos);
            this.Controls.Add(this.txtBuscar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListadoContactos";
            this.Text = "ListadoContactos";
            this.Load += new System.EventHandler(this.ListadoContactos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEditarContacto;
        private System.Windows.Forms.Button btnAñadirContacto;
        private System.Windows.Forms.DataGridView dgvListadoContactos;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}