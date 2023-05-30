namespace Vista
{
    partial class FmrFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrFacturacion));
            this.TablaFactura = new System.Windows.Forms.DataGridView();
            this.dttFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxFiltrar = new System.Windows.Forms.CheckBox();
            this.txtValorTotal = new Vista.pruebas();
            this.txtValorDescuentos = new Vista.pruebas();
            this.txtValorComision = new Vista.pruebas();
            this.txtNumeroPoliza = new Vista.pruebas();
            this.txtPlanBeneficios = new Vista.pruebas();
            this.txtNumeroFactura = new Vista.pruebas();
            this.txtNumeroContrato = new Vista.pruebas();
            ((System.ComponentModel.ISupportInitialize)(this.TablaFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaFactura
            // 
            this.TablaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaFactura.Location = new System.Drawing.Point(144, 241);
            this.TablaFactura.Name = "TablaFactura";
            this.TablaFactura.Size = new System.Drawing.Size(505, 223);
            this.TablaFactura.TabIndex = 1;
            this.TablaFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaFactura_CellContentClick);
            // 
            // dttFechaFinal
            // 
            this.dttFechaFinal.Location = new System.Drawing.Point(174, 47);
            this.dttFechaFinal.Name = "dttFechaFinal";
            this.dttFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dttFechaFinal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plan Beneficio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numero de poliza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Valor Comision";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Valor Descuentos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Valor Total";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(421, 488);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(185, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Cancelar Factura";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(167, 488);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(185, 35);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Facturar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Contrato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero Factura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 495);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cbxFiltrar
            // 
            this.cbxFiltrar.AutoSize = true;
            this.cbxFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxFiltrar.ForeColor = System.Drawing.Color.Black;
            this.cbxFiltrar.Location = new System.Drawing.Point(350, 532);
            this.cbxFiltrar.Name = "cbxFiltrar";
            this.cbxFiltrar.Size = new System.Drawing.Size(94, 17);
            this.cbxFiltrar.TabIndex = 7;
            this.cbxFiltrar.Text = "Mostrar Todos";
            this.cbxFiltrar.UseVisualStyleBackColor = false;
            this.cbxFiltrar.CheckedChanged += new System.EventHandler(this.cbxFiltrar_CheckedChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorTotal.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtValorTotal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValorTotal.BorderRadius = 15;
            this.txtValorTotal.BorderSize = 2;
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(478, 182);
            this.txtValorTotal.Multiline = false;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Padding = new System.Windows.Forms.Padding(7);
            this.txtValorTotal.PasswordChar = false;
            this.txtValorTotal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorTotal.PlaceholderText = "";
            this.txtValorTotal.Size = new System.Drawing.Size(128, 31);
            this.txtValorTotal.TabIndex = 4;
            this.txtValorTotal.Texts = "";
            this.txtValorTotal.UnderlinedStyle = false;
            this.txtValorTotal.Enter += new System.EventHandler(this.txtValorTotal_Enter);
            this.txtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorTotal_KeyPress);
            // 
            // txtValorDescuentos
            // 
            this.txtValorDescuentos.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorDescuentos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtValorDescuentos.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValorDescuentos.BorderRadius = 15;
            this.txtValorDescuentos.BorderSize = 2;
            this.txtValorDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDescuentos.Location = new System.Drawing.Point(329, 182);
            this.txtValorDescuentos.Multiline = false;
            this.txtValorDescuentos.Name = "txtValorDescuentos";
            this.txtValorDescuentos.Padding = new System.Windows.Forms.Padding(7);
            this.txtValorDescuentos.PasswordChar = false;
            this.txtValorDescuentos.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorDescuentos.PlaceholderText = "";
            this.txtValorDescuentos.Size = new System.Drawing.Size(128, 31);
            this.txtValorDescuentos.TabIndex = 4;
            this.txtValorDescuentos.Texts = "";
            this.txtValorDescuentos.UnderlinedStyle = false;
            this.txtValorDescuentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDescuentos_KeyPress);
            // 
            // txtValorComision
            // 
            this.txtValorComision.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorComision.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtValorComision.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValorComision.BorderRadius = 15;
            this.txtValorComision.BorderSize = 2;
            this.txtValorComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorComision.Location = new System.Drawing.Point(167, 182);
            this.txtValorComision.Multiline = false;
            this.txtValorComision.Name = "txtValorComision";
            this.txtValorComision.Padding = new System.Windows.Forms.Padding(7);
            this.txtValorComision.PasswordChar = false;
            this.txtValorComision.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValorComision.PlaceholderText = "";
            this.txtValorComision.Size = new System.Drawing.Size(128, 31);
            this.txtValorComision.TabIndex = 4;
            this.txtValorComision.Texts = "";
            this.txtValorComision.UnderlinedStyle = false;
            this.txtValorComision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorComision_KeyPress);
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroPoliza.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumeroPoliza.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumeroPoliza.BorderRadius = 15;
            this.txtNumeroPoliza.BorderSize = 2;
            this.txtNumeroPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPoliza.Location = new System.Drawing.Point(466, 103);
            this.txtNumeroPoliza.Multiline = false;
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumeroPoliza.PasswordChar = false;
            this.txtNumeroPoliza.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumeroPoliza.PlaceholderText = "";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(128, 31);
            this.txtNumeroPoliza.TabIndex = 4;
            this.txtNumeroPoliza.Texts = "";
            this.txtNumeroPoliza.UnderlinedStyle = false;
            this.txtNumeroPoliza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPoliza_KeyPress);
            // 
            // txtPlanBeneficios
            // 
            this.txtPlanBeneficios.BackColor = System.Drawing.SystemColors.Window;
            this.txtPlanBeneficios.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPlanBeneficios.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPlanBeneficios.BorderRadius = 15;
            this.txtPlanBeneficios.BorderSize = 2;
            this.txtPlanBeneficios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanBeneficios.Location = new System.Drawing.Point(316, 103);
            this.txtPlanBeneficios.Multiline = false;
            this.txtPlanBeneficios.Name = "txtPlanBeneficios";
            this.txtPlanBeneficios.Padding = new System.Windows.Forms.Padding(7);
            this.txtPlanBeneficios.PasswordChar = false;
            this.txtPlanBeneficios.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPlanBeneficios.PlaceholderText = "";
            this.txtPlanBeneficios.Size = new System.Drawing.Size(128, 31);
            this.txtPlanBeneficios.TabIndex = 4;
            this.txtPlanBeneficios.Texts = "";
            this.txtPlanBeneficios.UnderlinedStyle = false;
            this.txtPlanBeneficios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlanBeneficios_KeyPress);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroFactura.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumeroFactura.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumeroFactura.BorderRadius = 15;
            this.txtNumeroFactura.BorderSize = 2;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(412, 36);
            this.txtNumeroFactura.Multiline = false;
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumeroFactura.PasswordChar = false;
            this.txtNumeroFactura.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumeroFactura.PlaceholderText = "";
            this.txtNumeroFactura.Size = new System.Drawing.Size(128, 31);
            this.txtNumeroFactura.TabIndex = 4;
            this.txtNumeroFactura.Texts = "";
            this.txtNumeroFactura.UnderlinedStyle = false;
            this.txtNumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroFactura_KeyPress);
            // 
            // txtNumeroContrato
            // 
            this.txtNumeroContrato.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroContrato.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNumeroContrato.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNumeroContrato.BorderRadius = 15;
            this.txtNumeroContrato.BorderSize = 2;
            this.txtNumeroContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroContrato.Location = new System.Drawing.Point(171, 103);
            this.txtNumeroContrato.Multiline = false;
            this.txtNumeroContrato.Name = "txtNumeroContrato";
            this.txtNumeroContrato.Padding = new System.Windows.Forms.Padding(7);
            this.txtNumeroContrato.PasswordChar = false;
            this.txtNumeroContrato.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumeroContrato.PlaceholderText = "";
            this.txtNumeroContrato.Size = new System.Drawing.Size(128, 31);
            this.txtNumeroContrato.TabIndex = 4;
            this.txtNumeroContrato.Texts = "";
            this.txtNumeroContrato.UnderlinedStyle = false;
            this.txtNumeroContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroContrato_KeyPress);
            // 
            // FmrFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(786, 561);
            this.Controls.Add(this.cbxFiltrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValorDescuentos);
            this.Controls.Add(this.txtValorComision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumeroPoliza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlanBeneficios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.txtNumeroContrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dttFechaFinal);
            this.Controls.Add(this.TablaFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrFacturacion";
            this.Text = "FmrFacturacion";
            this.Load += new System.EventHandler(this.FmrFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TablaFactura;
        private System.Windows.Forms.DateTimePicker dttFechaFinal;
        private System.Windows.Forms.Label label2;
        private pruebas txtNumeroContrato;
        private System.Windows.Forms.Label label4;
        private pruebas txtPlanBeneficios;
        private System.Windows.Forms.Label label5;
        private pruebas txtNumeroPoliza;
        private System.Windows.Forms.Label label6;
        private pruebas txtValorComision;
        private System.Windows.Forms.Label label7;
        private pruebas txtValorDescuentos;
        private System.Windows.Forms.Label label8;
        private pruebas txtValorTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private pruebas txtNumeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxFiltrar;
    }
}