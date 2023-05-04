namespace Vista
{
    partial class FmrPacieentes
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
            this.PanelDatos = new System.Windows.Forms.Panel();
            this.cbbCiudad = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbZona = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDepartamentos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbSexo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ccbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMedidaEdad = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtxSapellido = new System.Windows.Forms.TextBox();
            this.txtxPapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtxSnombre = new System.Windows.Forms.TextBox();
            this.txtNumI = new System.Windows.Forms.TextBox();
            this.txtxPnombre = new System.Windows.Forms.TextBox();
            this.PanelVista = new System.Windows.Forms.Panel();
            this.tablap = new System.Windows.Forms.DataGridView();
            this.Tipo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkView = new System.Windows.Forms.CheckBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.PanelDatos.SuspendLayout();
            this.PanelVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablap)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDatos
            // 
            this.PanelDatos.Controls.Add(this.cbbCiudad);
            this.PanelDatos.Controls.Add(this.label12);
            this.PanelDatos.Controls.Add(this.cbbZona);
            this.PanelDatos.Controls.Add(this.label8);
            this.PanelDatos.Controls.Add(this.cbbDepartamentos);
            this.PanelDatos.Controls.Add(this.label11);
            this.PanelDatos.Controls.Add(this.cbbSexo);
            this.PanelDatos.Controls.Add(this.label10);
            this.PanelDatos.Controls.Add(this.ccbTipoUsuario);
            this.PanelDatos.Controls.Add(this.label6);
            this.PanelDatos.Controls.Add(this.cbbTipos);
            this.PanelDatos.Controls.Add(this.label2);
            this.PanelDatos.Controls.Add(this.label3);
            this.PanelDatos.Controls.Add(this.label7);
            this.PanelDatos.Controls.Add(this.label5);
            this.PanelDatos.Controls.Add(this.label4);
            this.PanelDatos.Controls.Add(this.label16);
            this.PanelDatos.Controls.Add(this.label15);
            this.PanelDatos.Controls.Add(this.label14);
            this.PanelDatos.Controls.Add(this.txtMedidaEdad);
            this.PanelDatos.Controls.Add(this.txtEdad);
            this.PanelDatos.Controls.Add(this.txtxSapellido);
            this.PanelDatos.Controls.Add(this.txtxPapellido);
            this.PanelDatos.Controls.Add(this.label1);
            this.PanelDatos.Controls.Add(this.txtxSnombre);
            this.PanelDatos.Controls.Add(this.txtNumI);
            this.PanelDatos.Controls.Add(this.txtxPnombre);
            this.PanelDatos.Location = new System.Drawing.Point(111, 52);
            this.PanelDatos.Name = "PanelDatos";
            this.PanelDatos.Size = new System.Drawing.Size(680, 301);
            this.PanelDatos.TabIndex = 1;
            // 
            // cbbCiudad
            // 
            this.cbbCiudad.FormattingEnabled = true;
            this.cbbCiudad.Location = new System.Drawing.Point(521, 183);
            this.cbbCiudad.Name = "cbbCiudad";
            this.cbbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cbbCiudad.TabIndex = 2;
            this.cbbCiudad.SelectedIndexChanged += new System.EventHandler(this.cbbDiagR3_SelectedIndexChanged);
            this.cbbCiudad.Click += new System.EventHandler(this.cbbCiudad_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(518, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Ciudad Residencia";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cbbZona
            // 
            this.cbbZona.FormattingEnabled = true;
            this.cbbZona.Location = new System.Drawing.Point(50, 250);
            this.cbbZona.Name = "cbbZona";
            this.cbbZona.Size = new System.Drawing.Size(121, 21);
            this.cbbZona.TabIndex = 2;
            this.cbbZona.SelectedIndexChanged += new System.EventHandler(this.cbbDiagR2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Zona";
            this.label8.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbbDepartamentos
            // 
            this.cbbDepartamentos.FormattingEnabled = true;
            this.cbbDepartamentos.Location = new System.Drawing.Point(360, 183);
            this.cbbDepartamentos.Name = "cbbDepartamentos";
            this.cbbDepartamentos.Size = new System.Drawing.Size(121, 21);
            this.cbbDepartamentos.TabIndex = 2;
            this.cbbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.cbbDiagR2_SelectedIndexChanged);
            this.cbbDepartamentos.Click += new System.EventHandler(this.cbbDepartamentos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Departamento Residencia";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbbSexo
            // 
            this.cbbSexo.FormattingEnabled = true;
            this.cbbSexo.Location = new System.Drawing.Point(203, 183);
            this.cbbSexo.Name = "cbbSexo";
            this.cbbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbbSexo.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sexo";
            // 
            // ccbTipoUsuario
            // 
            this.ccbTipoUsuario.FormattingEnabled = true;
            this.ccbTipoUsuario.Location = new System.Drawing.Point(365, 39);
            this.ccbTipoUsuario.Name = "ccbTipoUsuario";
            this.ccbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.ccbTipoUsuario.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tipo de usuario";
            // 
            // cbbTipos
            // 
            this.cbbTipos.FormattingEnabled = true;
            this.cbbTipos.Location = new System.Drawing.Point(50, 43);
            this.cbbTipos.Name = "cbbTipos";
            this.cbbTipos.Size = new System.Drawing.Size(121, 21);
            this.cbbTipos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de identificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero De Identificacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Unidad de medida Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Segundo Apellido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(357, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Primer Apellido";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(200, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Segundo Nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Primer Nombre";
            // 
            // txtMedidaEdad
            // 
            this.txtMedidaEdad.Location = new System.Drawing.Point(50, 183);
            this.txtMedidaEdad.Name = "txtMedidaEdad";
            this.txtMedidaEdad.Size = new System.Drawing.Size(106, 20);
            this.txtMedidaEdad.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(521, 39);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(106, 20);
            this.txtEdad.TabIndex = 0;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtxSapellido
            // 
            this.txtxSapellido.Location = new System.Drawing.Point(506, 114);
            this.txtxSapellido.Name = "txtxSapellido";
            this.txtxSapellido.Size = new System.Drawing.Size(106, 20);
            this.txtxSapellido.TabIndex = 0;
            this.txtxSapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxSapellido_KeyPress);
            // 
            // txtxPapellido
            // 
            this.txtxPapellido.Location = new System.Drawing.Point(360, 114);
            this.txtxPapellido.Name = "txtxPapellido";
            this.txtxPapellido.Size = new System.Drawing.Size(106, 20);
            this.txtxPapellido.TabIndex = 0;
            this.txtxPapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxPapellido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // txtxSnombre
            // 
            this.txtxSnombre.Location = new System.Drawing.Point(203, 114);
            this.txtxSnombre.Name = "txtxSnombre";
            this.txtxSnombre.Size = new System.Drawing.Size(106, 20);
            this.txtxSnombre.TabIndex = 0;
            this.txtxSnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxSnombre_KeyPress);
            // 
            // txtNumI
            // 
            this.txtNumI.Location = new System.Drawing.Point(205, 43);
            this.txtNumI.Name = "txtNumI";
            this.txtNumI.Size = new System.Drawing.Size(106, 20);
            this.txtNumI.TabIndex = 0;
            this.txtNumI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumI_KeyPress);
            // 
            // txtxPnombre
            // 
            this.txtxPnombre.Location = new System.Drawing.Point(50, 114);
            this.txtxPnombre.Name = "txtxPnombre";
            this.txtxPnombre.Size = new System.Drawing.Size(106, 20);
            this.txtxPnombre.TabIndex = 0;
            this.txtxPnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxPnombre_KeyPress);
            // 
            // PanelVista
            // 
            this.PanelVista.Controls.Add(this.tablap);
            this.PanelVista.Location = new System.Drawing.Point(94, 28);
            this.PanelVista.Name = "PanelVista";
            this.PanelVista.Size = new System.Drawing.Size(741, 371);
            this.PanelVista.TabIndex = 2;
            // 
            // tablap
            // 
            this.tablap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Id,
            this.Numero_Identificacion,
            this.Primer_Nombre,
            this.Primer_Apellido,
            this.Edad,
            this.Sexo});
            this.tablap.Location = new System.Drawing.Point(61, 11);
            this.tablap.Name = "tablap";
            this.tablap.Size = new System.Drawing.Size(648, 330);
            this.tablap.TabIndex = 0;
            this.tablap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablap_CellContentClick);
            // 
            // Tipo_Id
            // 
            this.Tipo_Id.HeaderText = "Tipo_Identificacion";
            this.Tipo_Id.Name = "Tipo_Id";
            // 
            // Numero_Identificacion
            // 
            this.Numero_Identificacion.HeaderText = "Numero_Identificacion";
            this.Numero_Identificacion.Name = "Numero_Identificacion";
            // 
            // Primer_Nombre
            // 
            this.Primer_Nombre.HeaderText = "Primer_Nombre";
            this.Primer_Nombre.Name = "Primer_Nombre";
            // 
            // Primer_Apellido
            // 
            this.Primer_Apellido.HeaderText = "Primer_Apellido";
            this.Primer_Apellido.Name = "Primer_Apellido";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // checkView
            // 
            this.checkView.AutoSize = true;
            this.checkView.Location = new System.Drawing.Point(379, 488);
            this.checkView.Name = "checkView";
            this.checkView.Size = new System.Drawing.Size(135, 17);
            this.checkView.TabIndex = 7;
            this.checkView.Text = "Pasar a modificaciones";
            this.checkView.UseVisualStyleBackColor = true;
            this.checkView.CheckedChanged += new System.EventHandler(this.checkView_CheckedChanged);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(578, 425);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(109, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar Consultas";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(404, 425);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Actualizar Consultas";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(220, 425);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(102, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Guardar Consulta";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // FmrPacieentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 549);
            this.Controls.Add(this.checkView);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.PanelVista);
            this.Controls.Add(this.PanelDatos);
            this.Name = "FmrPacieentes";
            this.Text = "FmrPacieentes";
            this.Load += new System.EventHandler(this.FmrPacieentes_Load);
            this.PanelDatos.ResumeLayout(false);
            this.PanelDatos.PerformLayout();
            this.PanelVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDatos;
        private System.Windows.Forms.ComboBox cbbCiudad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbDepartamentos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbSexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ccbTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMedidaEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtxSapellido;
        private System.Windows.Forms.TextBox txtxPapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtxSnombre;
        private System.Windows.Forms.TextBox txtNumI;
        private System.Windows.Forms.TextBox txtxPnombre;
        private System.Windows.Forms.ComboBox cbbZona;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelVista;
        private System.Windows.Forms.DataGridView tablap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.CheckBox checkView;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
    }
}