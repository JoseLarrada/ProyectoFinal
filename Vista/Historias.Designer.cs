namespace Vista
{
    partial class Historias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historias));
            this.TablaFactura = new System.Windows.Forms.DataGridView();
            this.txtNumF = new Vista.pruebas();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTratamiento = new Vista.pruebas();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedicacion = new Vista.pruebas();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaHistorias = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TablaFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorias)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaFactura
            // 
            this.TablaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaFactura.Location = new System.Drawing.Point(31, 266);
            this.TablaFactura.Name = "TablaFactura";
            this.TablaFactura.Size = new System.Drawing.Size(349, 205);
            this.TablaFactura.TabIndex = 1;
            // 
            // txtNumF
            // 
            this.txtNumF.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumF.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumF.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumF.BorderRadius = 15;
            this.txtNumF.BorderSize = 2;
            this.txtNumF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumF.Location = new System.Drawing.Point(187, 81);
            this.txtNumF.Multiline = false;
            this.txtNumF.Name = "txtNumF";
            this.txtNumF.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumF.PasswordChar = false;
            this.txtNumF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumF.PlaceholderText = "";
            this.txtNumF.Size = new System.Drawing.Size(164, 31);
            this.txtNumF.TabIndex = 0;
            this.txtNumF.Texts = "";
            this.txtNumF.UnderlinedStyle = false;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(104, 492);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(185, 35);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Factura";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.BackColor = System.Drawing.SystemColors.Window;
            this.txtTratamiento.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTratamiento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTratamiento.BorderRadius = 15;
            this.txtTratamiento.BorderSize = 2;
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.Location = new System.Drawing.Point(392, 81);
            this.txtTratamiento.Multiline = false;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Padding = new System.Windows.Forms.Padding(7);
            this.txtTratamiento.PasswordChar = false;
            this.txtTratamiento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTratamiento.PlaceholderText = "";
            this.txtTratamiento.Size = new System.Drawing.Size(219, 31);
            this.txtTratamiento.TabIndex = 0;
            this.txtTratamiento.Texts = "";
            this.txtTratamiento.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descipcion";
            // 
            // txtMedicacion
            // 
            this.txtMedicacion.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedicacion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMedicacion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMedicacion.BorderRadius = 15;
            this.txtMedicacion.BorderSize = 2;
            this.txtMedicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicacion.Location = new System.Drawing.Point(646, 81);
            this.txtMedicacion.Multiline = false;
            this.txtMedicacion.Name = "txtMedicacion";
            this.txtMedicacion.Padding = new System.Windows.Forms.Padding(7);
            this.txtMedicacion.PasswordChar = false;
            this.txtMedicacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicacion.PlaceholderText = "";
            this.txtMedicacion.Size = new System.Drawing.Size(225, 31);
            this.txtMedicacion.TabIndex = 0;
            this.txtMedicacion.Texts = "";
            this.txtMedicacion.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medicacion";
            // 
            // tablaHistorias
            // 
            this.tablaHistorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHistorias.Location = new System.Drawing.Point(508, 266);
            this.tablaHistorias.Name = "tablaHistorias";
            this.tablaHistorias.Size = new System.Drawing.Size(456, 205);
            this.tablaHistorias.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(392, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(677, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(187, 136);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // Historias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 630);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.tablaHistorias);
            this.Controls.Add(this.TablaFactura);
            this.Controls.Add(this.txtMedicacion);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.txtNumF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historias";
            this.Text = "Historias";
            this.Load += new System.EventHandler(this.Historias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHistorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pruebas txtNumF;
        private System.Windows.Forms.DataGridView TablaFactura;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private pruebas txtTratamiento;
        private System.Windows.Forms.Label label2;
        private pruebas txtMedicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tablaHistorias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}