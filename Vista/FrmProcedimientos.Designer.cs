namespace Vista
{
    partial class FrmProcedimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcedimientos));
            this.PanelDatos = new System.Windows.Forms.Panel();
            this.Datetime = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoProcedimiento = new System.Windows.Forms.TextBox();
            this.txtNumAuto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbFormaRealizacion = new System.Windows.Forms.ComboBox();
            this.cbbDiagnosticoP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbFinalidadProcedimiento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbAmbitoP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIde = new System.Windows.Forms.TextBox();
            this.txtVrlProcedimiento = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.checkView = new System.Windows.Forms.CheckBox();
            this.PanelVista = new System.Windows.Forms.Panel();
            this.tablaProcedimientos = new System.Windows.Forms.DataGridView();
            this.PanelDatos.SuspendLayout();
            this.PanelVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDatos
            // 
            this.PanelDatos.BackColor = System.Drawing.Color.White;
            this.PanelDatos.Controls.Add(this.Datetime);
            this.PanelDatos.Controls.Add(this.txtCodigoProcedimiento);
            this.PanelDatos.Controls.Add(this.txtNumAuto);
            this.PanelDatos.Controls.Add(this.label5);
            this.PanelDatos.Controls.Add(this.cbbFormaRealizacion);
            this.PanelDatos.Controls.Add(this.cbbDiagnosticoP);
            this.PanelDatos.Controls.Add(this.label9);
            this.PanelDatos.Controls.Add(this.cbbFinalidadProcedimiento);
            this.PanelDatos.Controls.Add(this.label8);
            this.PanelDatos.Controls.Add(this.cbbAmbitoP);
            this.PanelDatos.Controls.Add(this.label7);
            this.PanelDatos.Controls.Add(this.label6);
            this.PanelDatos.Controls.Add(this.cbbTipos);
            this.PanelDatos.Controls.Add(this.label2);
            this.PanelDatos.Controls.Add(this.label4);
            this.PanelDatos.Controls.Add(this.label3);
            this.PanelDatos.Controls.Add(this.label16);
            this.PanelDatos.Controls.Add(this.label14);
            this.PanelDatos.Controls.Add(this.label1);
            this.PanelDatos.Controls.Add(this.TxtIde);
            this.PanelDatos.Controls.Add(this.txtVrlProcedimiento);
            this.PanelDatos.Controls.Add(this.txtNumeroFactura);
            this.PanelDatos.Location = new System.Drawing.Point(157, 64);
            this.PanelDatos.Name = "PanelDatos";
            this.PanelDatos.Size = new System.Drawing.Size(692, 328);
            this.PanelDatos.TabIndex = 1;
            // 
            // Datetime
            // 
            this.Datetime.Location = new System.Drawing.Point(251, 144);
            this.Datetime.Name = "Datetime";
            this.Datetime.Size = new System.Drawing.Size(200, 20);
            this.Datetime.TabIndex = 3;
            // 
            // txtCodigoProcedimiento
            // 
            this.txtCodigoProcedimiento.Location = new System.Drawing.Point(60, 121);
            this.txtCodigoProcedimiento.Name = "txtCodigoProcedimiento";
            this.txtCodigoProcedimiento.Size = new System.Drawing.Size(106, 20);
            this.txtCodigoProcedimiento.TabIndex = 0;
            this.txtCodigoProcedimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProcedimiento_KeyPress);
            // 
            // txtNumAuto
            // 
            this.txtNumAuto.Location = new System.Drawing.Point(532, 121);
            this.txtNumAuto.Name = "txtNumAuto";
            this.txtNumAuto.Size = new System.Drawing.Size(106, 20);
            this.txtNumAuto.TabIndex = 0;
            this.txtNumAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAuto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numero De Autorizacion";
            // 
            // cbbFormaRealizacion
            // 
            this.cbbFormaRealizacion.FormattingEnabled = true;
            this.cbbFormaRealizacion.Location = new System.Drawing.Point(60, 271);
            this.cbbFormaRealizacion.Name = "cbbFormaRealizacion";
            this.cbbFormaRealizacion.Size = new System.Drawing.Size(121, 21);
            this.cbbFormaRealizacion.TabIndex = 2;
            // 
            // cbbDiagnosticoP
            // 
            this.cbbDiagnosticoP.FormattingEnabled = true;
            this.cbbDiagnosticoP.Location = new System.Drawing.Point(532, 197);
            this.cbbDiagnosticoP.Name = "cbbDiagnosticoP";
            this.cbbDiagnosticoP.Size = new System.Drawing.Size(121, 21);
            this.cbbDiagnosticoP.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Diagnostico Principal";
            // 
            // cbbFinalidadProcedimiento
            // 
            this.cbbFinalidadProcedimiento.FormattingEnabled = true;
            this.cbbFinalidadProcedimiento.Location = new System.Drawing.Point(282, 223);
            this.cbbFinalidadProcedimiento.Name = "cbbFinalidadProcedimiento";
            this.cbbFinalidadProcedimiento.Size = new System.Drawing.Size(121, 21);
            this.cbbFinalidadProcedimiento.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Finalidad de Procedimiento";
            // 
            // cbbAmbitoP
            // 
            this.cbbAmbitoP.FormattingEnabled = true;
            this.cbbAmbitoP.Location = new System.Drawing.Point(60, 197);
            this.cbbAmbitoP.Name = "cbbAmbitoP";
            this.cbbAmbitoP.Size = new System.Drawing.Size(121, 21);
            this.cbbAmbitoP.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ambito Procedimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo Procedimiento";
            // 
            // cbbTipos
            // 
            this.cbbTipos.FormattingEnabled = true;
            this.cbbTipos.Location = new System.Drawing.Point(282, 65);
            this.cbbTipos.Name = "cbbTipos";
            this.cbbTipos.Size = new System.Drawing.Size(121, 21);
            this.cbbTipos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de Procedimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero De Identificacion";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Forma de realizacion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(529, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Valor Procedimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero De Factura";
            // 
            // TxtIde
            // 
            this.TxtIde.Location = new System.Drawing.Point(524, 40);
            this.TxtIde.Name = "TxtIde";
            this.TxtIde.Size = new System.Drawing.Size(106, 20);
            this.TxtIde.TabIndex = 0;
            this.TxtIde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIde_KeyPress);
            // 
            // txtVrlProcedimiento
            // 
            this.txtVrlProcedimiento.Location = new System.Drawing.Point(532, 272);
            this.txtVrlProcedimiento.Name = "txtVrlProcedimiento";
            this.txtVrlProcedimiento.Size = new System.Drawing.Size(106, 20);
            this.txtVrlProcedimiento.TabIndex = 0;
            this.txtVrlProcedimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVrlProcedimiento_KeyPress);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(60, 40);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(106, 20);
            this.txtNumeroFactura.TabIndex = 0;
            this.txtNumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroFactura_KeyPress);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(664, 485);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(185, 35);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar Procedimiento";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(403, 485);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(185, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Actualizar Procedimiento";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Location = new System.Drawing.Point(144, 485);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(185, 35);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Guardar Procedimiento";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // checkView
            // 
            this.checkView.AutoSize = true;
            this.checkView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkView.Location = new System.Drawing.Point(439, 562);
            this.checkView.Name = "checkView";
            this.checkView.Size = new System.Drawing.Size(135, 17);
            this.checkView.TabIndex = 5;
            this.checkView.Text = "Pasar a modificaciones";
            this.checkView.UseVisualStyleBackColor = false;
            this.checkView.CheckedChanged += new System.EventHandler(this.checkView_CheckedChanged);
            // 
            // PanelVista
            // 
            this.PanelVista.BackColor = System.Drawing.Color.White;
            this.PanelVista.Controls.Add(this.tablaProcedimientos);
            this.PanelVista.Location = new System.Drawing.Point(144, 27);
            this.PanelVista.Name = "PanelVista";
            this.PanelVista.Size = new System.Drawing.Size(721, 385);
            this.PanelVista.TabIndex = 6;
            // 
            // tablaProcedimientos
            // 
            this.tablaProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProcedimientos.Location = new System.Drawing.Point(34, 21);
            this.tablaProcedimientos.Name = "tablaProcedimientos";
            this.tablaProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProcedimientos.Size = new System.Drawing.Size(648, 330);
            this.tablaProcedimientos.TabIndex = 1;
            this.tablaProcedimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProcedimientos_CellContentClick);
            // 
            // FrmProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(988, 591);
            this.Controls.Add(this.PanelVista);
            this.Controls.Add(this.checkView);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.PanelDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProcedimientos";
            this.Text = "Vistas";
            this.Load += new System.EventHandler(this.FrmProcedimientos_Load);
            this.PanelDatos.ResumeLayout(false);
            this.PanelDatos.PerformLayout();
            this.PanelVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDatos;
        private System.Windows.Forms.DateTimePicker Datetime;
        private System.Windows.Forms.ComboBox cbbDiagnosticoP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbFinalidadProcedimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbAmbitoP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIde;
        private System.Windows.Forms.TextBox txtVrlProcedimiento;
        private System.Windows.Forms.TextBox txtNumAuto;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.CheckBox checkView;
        private System.Windows.Forms.ComboBox cbbFormaRealizacion;
        private System.Windows.Forms.TextBox txtCodigoProcedimiento;
        private System.Windows.Forms.Panel PanelVista;
        private System.Windows.Forms.DataGridView tablaProcedimientos;
    }
}