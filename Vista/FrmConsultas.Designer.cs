﻿namespace Vista
{
    partial class FrmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultas));
            this.PanelDatos = new System.Windows.Forms.Panel();
            this.Datetime = new System.Windows.Forms.DateTimePicker();
            this.cbbDiagR3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbDiagR2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbDiagR = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbTdiagP = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbDiagnosticoP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbFinalidadConsulta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbCausa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ccbCConsulta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVrlNeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrlCuoM = new System.Windows.Forms.TextBox();
            this.TxtIde = new System.Windows.Forms.TextBox();
            this.txtVrlConsulta = new System.Windows.Forms.TextBox();
            this.txtNumAuto = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.PanelVista = new System.Windows.Forms.Panel();
            this.tablaConsultas = new System.Windows.Forms.DataGridView();
            this.checkView = new System.Windows.Forms.CheckBox();
            this.PanelDatos.SuspendLayout();
            this.PanelVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDatos
            // 
            this.PanelDatos.BackColor = System.Drawing.Color.White;
            this.PanelDatos.Controls.Add(this.Datetime);
            this.PanelDatos.Controls.Add(this.cbbDiagR3);
            this.PanelDatos.Controls.Add(this.label12);
            this.PanelDatos.Controls.Add(this.cbbDiagR2);
            this.PanelDatos.Controls.Add(this.label11);
            this.PanelDatos.Controls.Add(this.cbbDiagR);
            this.PanelDatos.Controls.Add(this.label10);
            this.PanelDatos.Controls.Add(this.cbbTdiagP);
            this.PanelDatos.Controls.Add(this.label13);
            this.PanelDatos.Controls.Add(this.cbbDiagnosticoP);
            this.PanelDatos.Controls.Add(this.label9);
            this.PanelDatos.Controls.Add(this.cbbFinalidadConsulta);
            this.PanelDatos.Controls.Add(this.label8);
            this.PanelDatos.Controls.Add(this.cbbCausa);
            this.PanelDatos.Controls.Add(this.label7);
            this.PanelDatos.Controls.Add(this.ccbCConsulta);
            this.PanelDatos.Controls.Add(this.label6);
            this.PanelDatos.Controls.Add(this.cbbTipos);
            this.PanelDatos.Controls.Add(this.label2);
            this.PanelDatos.Controls.Add(this.label4);
            this.PanelDatos.Controls.Add(this.label3);
            this.PanelDatos.Controls.Add(this.label5);
            this.PanelDatos.Controls.Add(this.label16);
            this.PanelDatos.Controls.Add(this.label15);
            this.PanelDatos.Controls.Add(this.label14);
            this.PanelDatos.Controls.Add(this.txtVrlNeto);
            this.PanelDatos.Controls.Add(this.label1);
            this.PanelDatos.Controls.Add(this.txtVrlCuoM);
            this.PanelDatos.Controls.Add(this.TxtIde);
            this.PanelDatos.Controls.Add(this.txtVrlConsulta);
            this.PanelDatos.Controls.Add(this.txtNumAuto);
            this.PanelDatos.Controls.Add(this.txtNumeroFactura);
            this.PanelDatos.Location = new System.Drawing.Point(161, 40);
            this.PanelDatos.Name = "PanelDatos";
            this.PanelDatos.Size = new System.Drawing.Size(680, 357);
            this.PanelDatos.TabIndex = 0;
            // 
            // Datetime
            // 
            this.Datetime.Location = new System.Drawing.Point(455, 40);
            this.Datetime.Name = "Datetime";
            this.Datetime.Size = new System.Drawing.Size(200, 20);
            this.Datetime.TabIndex = 3;
            this.Datetime.ValueChanged += new System.EventHandler(this.Datetime_ValueChanged);
            this.Datetime.Leave += new System.EventHandler(this.Datetime_Leave);
            // 
            // cbbDiagR3
            // 
            this.cbbDiagR3.FormattingEnabled = true;
            this.cbbDiagR3.Location = new System.Drawing.Point(506, 206);
            this.cbbDiagR3.Name = "cbbDiagR3";
            this.cbbDiagR3.Size = new System.Drawing.Size(121, 21);
            this.cbbDiagR3.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Diagnostico Relacionado 3";
            // 
            // cbbDiagR2
            // 
            this.cbbDiagR2.FormattingEnabled = true;
            this.cbbDiagR2.Location = new System.Drawing.Point(345, 206);
            this.cbbDiagR2.Name = "cbbDiagR2";
            this.cbbDiagR2.Size = new System.Drawing.Size(121, 21);
            this.cbbDiagR2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Diagnostico Relacionado 2";
            // 
            // cbbDiagR
            // 
            this.cbbDiagR.FormattingEnabled = true;
            this.cbbDiagR.Location = new System.Drawing.Point(188, 206);
            this.cbbDiagR.Name = "cbbDiagR";
            this.cbbDiagR.Size = new System.Drawing.Size(121, 21);
            this.cbbDiagR.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Diagnostico Relacionado";
            // 
            // cbbTdiagP
            // 
            this.cbbTdiagP.FormattingEnabled = true;
            this.cbbTdiagP.Location = new System.Drawing.Point(34, 298);
            this.cbbTdiagP.Name = "cbbTdiagP";
            this.cbbTdiagP.Size = new System.Drawing.Size(121, 21);
            this.cbbTdiagP.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tipo Diagnostico Principal";
            // 
            // cbbDiagnosticoP
            // 
            this.cbbDiagnosticoP.FormattingEnabled = true;
            this.cbbDiagnosticoP.Location = new System.Drawing.Point(35, 206);
            this.cbbDiagnosticoP.Name = "cbbDiagnosticoP";
            this.cbbDiagnosticoP.Size = new System.Drawing.Size(121, 21);
            this.cbbDiagnosticoP.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Diagnostico Principal";
            // 
            // cbbFinalidadConsulta
            // 
            this.cbbFinalidadConsulta.FormattingEnabled = true;
            this.cbbFinalidadConsulta.Location = new System.Drawing.Point(325, 120);
            this.cbbFinalidadConsulta.Name = "cbbFinalidadConsulta";
            this.cbbFinalidadConsulta.Size = new System.Drawing.Size(121, 21);
            this.cbbFinalidadConsulta.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Finalidad de Consulta";
            // 
            // cbbCausa
            // 
            this.cbbCausa.FormattingEnabled = true;
            this.cbbCausa.Location = new System.Drawing.Point(506, 120);
            this.cbbCausa.Name = "cbbCausa";
            this.cbbCausa.Size = new System.Drawing.Size(121, 21);
            this.cbbCausa.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Causa Externa";
            // 
            // ccbCConsulta
            // 
            this.ccbCConsulta.FormattingEnabled = true;
            this.ccbCConsulta.Location = new System.Drawing.Point(172, 120);
            this.ccbCConsulta.Name = "ccbCConsulta";
            this.ccbCConsulta.Size = new System.Drawing.Size(121, 21);
            this.ccbCConsulta.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo Consulta";
            // 
            // cbbTipos
            // 
            this.cbbTipos.FormattingEnabled = true;
            this.cbbTipos.Location = new System.Drawing.Point(169, 40);
            this.cbbTipos.Name = "cbbTipos";
            this.cbbTipos.Size = new System.Drawing.Size(121, 21);
            this.cbbTipos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha de Consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero De Identificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numero De Autorizacion";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(503, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Valor Neto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(346, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Valor Cuota Moderada";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(193, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Valor Consulta";
            // 
            // txtVrlNeto
            // 
            this.txtVrlNeto.Location = new System.Drawing.Point(506, 298);
            this.txtVrlNeto.Name = "txtVrlNeto";
            this.txtVrlNeto.Size = new System.Drawing.Size(106, 20);
            this.txtVrlNeto.TabIndex = 0;
            this.txtVrlNeto.Enter += new System.EventHandler(this.txtVrlNeto_Enter);
            this.txtVrlNeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVrlNeto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero De Factura";
            // 
            // txtVrlCuoM
            // 
            this.txtVrlCuoM.Location = new System.Drawing.Point(349, 298);
            this.txtVrlCuoM.Name = "txtVrlCuoM";
            this.txtVrlCuoM.Size = new System.Drawing.Size(106, 20);
            this.txtVrlCuoM.TabIndex = 0;
            this.txtVrlCuoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVrlCuoM_KeyPress);
            this.txtVrlCuoM.Leave += new System.EventHandler(this.txtVrlCuoM_Leave);
            // 
            // TxtIde
            // 
            this.TxtIde.Location = new System.Drawing.Point(322, 41);
            this.TxtIde.Name = "TxtIde";
            this.TxtIde.Size = new System.Drawing.Size(106, 20);
            this.TxtIde.TabIndex = 0;
            this.TxtIde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIde_KeyPress);
            this.TxtIde.Leave += new System.EventHandler(this.TxtIde_Leave);
            // 
            // txtVrlConsulta
            // 
            this.txtVrlConsulta.Location = new System.Drawing.Point(196, 298);
            this.txtVrlConsulta.Name = "txtVrlConsulta";
            this.txtVrlConsulta.Size = new System.Drawing.Size(106, 20);
            this.txtVrlConsulta.TabIndex = 0;
            this.txtVrlConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVrlConsulta_KeyPress);
            // 
            // txtNumAuto
            // 
            this.txtNumAuto.Location = new System.Drawing.Point(36, 120);
            this.txtNumAuto.Name = "txtNumAuto";
            this.txtNumAuto.Size = new System.Drawing.Size(106, 20);
            this.txtNumAuto.TabIndex = 0;
            this.txtNumAuto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumAuto_KeyPress);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(33, 43);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(106, 20);
            this.txtNumeroFactura.TabIndex = 0;
            this.txtNumeroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Location = new System.Drawing.Point(144, 485);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(185, 35);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Guardar Consulta";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(403, 485);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(185, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Actualizar Consultas";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(664, 485);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(185, 35);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar Consultas";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // PanelVista
            // 
            this.PanelVista.BackColor = System.Drawing.Color.White;
            this.PanelVista.Controls.Add(this.tablaConsultas);
            this.PanelVista.Location = new System.Drawing.Point(128, 26);
            this.PanelVista.Name = "PanelVista";
            this.PanelVista.Size = new System.Drawing.Size(721, 385);
            this.PanelVista.TabIndex = 2;
            // 
            // tablaConsultas
            // 
            this.tablaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaConsultas.Location = new System.Drawing.Point(34, 21);
            this.tablaConsultas.Name = "tablaConsultas";
            this.tablaConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaConsultas.Size = new System.Drawing.Size(648, 330);
            this.tablaConsultas.TabIndex = 1;
            this.tablaConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaConsultas_CellContentClick_1);
            // 
            // checkView
            // 
            this.checkView.AutoSize = true;
            this.checkView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkView.Location = new System.Drawing.Point(436, 575);
            this.checkView.Name = "checkView";
            this.checkView.Size = new System.Drawing.Size(135, 17);
            this.checkView.TabIndex = 3;
            this.checkView.Text = "Pasar a modificaciones";
            this.checkView.UseVisualStyleBackColor = false;
            this.checkView.CheckedChanged += new System.EventHandler(this.checkView_CheckedChanged);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 630);
            this.Controls.Add(this.checkView);
            this.Controls.Add(this.PanelVista);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.PanelDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.PanelDatos.ResumeLayout(false);
            this.PanelDatos.PerformLayout();
            this.PanelVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelDatos;
        private System.Windows.Forms.DateTimePicker Datetime;
        private System.Windows.Forms.ComboBox cbbDiagR3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbDiagR2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbDiagR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbTdiagP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbbDiagnosticoP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbFinalidadConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbCausa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtVrlNeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVrlCuoM;
        private System.Windows.Forms.TextBox TxtIde;
        private System.Windows.Forms.TextBox txtVrlConsulta;
        private System.Windows.Forms.TextBox txtNumAuto;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.ComboBox ccbCConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel PanelVista;
        private System.Windows.Forms.CheckBox checkView;
        private System.Windows.Forms.DataGridView tablaConsultas;
    }
}