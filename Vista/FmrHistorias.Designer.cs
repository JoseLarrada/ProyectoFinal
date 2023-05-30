namespace Vista
{
    partial class FmrHistorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrHistorias));
            this.TablaFactura = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaProcedimientos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMedicacion = new Vista.pruebas();
            this.txtTratamiento = new Vista.pruebas();
            this.txtNumF = new Vista.pruebas();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaFactura
            // 
            this.TablaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaFactura.Location = new System.Drawing.Point(31, 266);
            this.TablaFactura.Name = "TablaFactura";
            this.TablaFactura.Size = new System.Drawing.Size(349, 205);
            this.TablaFactura.TabIndex = 1;
            this.TablaFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaFactura_CellContentClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descipcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medicacion";
            // 
            // tablaProcedimientos
            // 
            this.tablaProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProcedimientos.Location = new System.Drawing.Point(508, 266);
            this.tablaProcedimientos.Name = "tablaProcedimientos";
            this.tablaProcedimientos.Size = new System.Drawing.Size(456, 205);
            this.tablaProcedimientos.TabIndex = 1;
            this.tablaProcedimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProcedimientos_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(392, 492);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(185, 35);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(677, 492);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(185, 35);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(187, 153);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // txtMedicacion
            // 
            this.txtMedicacion.BackColor = System.Drawing.SystemColors.Window;
            this.txtMedicacion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMedicacion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMedicacion.BorderRadius = 15;
            this.txtMedicacion.BorderSize = 2;
            this.txtMedicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicacion.Location = new System.Drawing.Point(747, 81);
            this.txtMedicacion.Multiline = true;
            this.txtMedicacion.Name = "txtMedicacion";
            this.txtMedicacion.Padding = new System.Windows.Forms.Padding(7);
            this.txtMedicacion.PasswordChar = false;
            this.txtMedicacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMedicacion.PlaceholderText = "";
            this.txtMedicacion.Size = new System.Drawing.Size(245, 123);
            this.txtMedicacion.TabIndex = 0;
            this.txtMedicacion.Texts = "";
            this.txtMedicacion.UnderlinedStyle = false;
            this.txtMedicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicacion_KeyPress);
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.txtTratamiento.BackColor = System.Drawing.SystemColors.Window;
            this.txtTratamiento.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTratamiento.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTratamiento.BorderRadius = 15;
            this.txtTratamiento.BorderSize = 2;
            this.txtTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.Location = new System.Drawing.Point(457, 81);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Padding = new System.Windows.Forms.Padding(7);
            this.txtTratamiento.PasswordChar = false;
            this.txtTratamiento.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTratamiento.PlaceholderText = "";
            this.txtTratamiento.Size = new System.Drawing.Size(224, 123);
            this.txtTratamiento.TabIndex = 0;
            this.txtTratamiento.Texts = "";
            this.txtTratamiento.UnderlinedStyle = false;
            this.txtTratamiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTratamiento_KeyPress);
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
            this.txtNumF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumF_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CONSULTAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PROCEDIMIENTOS";
            // 
            // FmrHistorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.tablaProcedimientos);
            this.Controls.Add(this.TablaFactura);
            this.Controls.Add(this.txtMedicacion);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.txtNumF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrHistorias";
            this.Text = "Historias";
            this.Load += new System.EventHandler(this.Historias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimientos)).EndInit();
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
        private System.Windows.Forms.DataGridView tablaProcedimientos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}