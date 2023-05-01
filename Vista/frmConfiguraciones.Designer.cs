namespace Vista
{
    partial class frmConfiguraciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.ListaTipos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnModificar2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.txtCodCons = new System.Windows.Forms.TextBox();
            this.ListaCodConsultas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.TxtTipo);
            this.groupBox1.Controls.Add(this.ListaTipos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPOS DE IDENTIFICACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Identificacion";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(205, 211);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(110, 211);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 211);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(18, 94);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(110, 20);
            this.TxtTipo.TabIndex = 2;
            // 
            // ListaTipos
            // 
            this.ListaTipos.FormattingEnabled = true;
            this.ListaTipos.Location = new System.Drawing.Point(295, 35);
            this.ListaTipos.Name = "ListaTipos";
            this.ListaTipos.Size = new System.Drawing.Size(161, 212);
            this.ListaTipos.TabIndex = 1;
            this.ListaTipos.SelectedIndexChanged += new System.EventHandler(this.ListaTipos_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEliminar2);
            this.groupBox2.Controls.Add(this.btnModificar2);
            this.groupBox2.Controls.Add(this.btnAgregar2);
            this.groupBox2.Controls.Add(this.txtCodCons);
            this.groupBox2.Controls.Add(this.ListaCodConsultas);
            this.groupBox2.Location = new System.Drawing.Point(521, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CODIGO CONSULTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CodigoConsulta";
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Location = new System.Drawing.Point(205, 211);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar2.TabIndex = 3;
            this.btnEliminar2.Text = "Eliminar";
            this.btnEliminar2.UseVisualStyleBackColor = true;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnModificar2
            // 
            this.btnModificar2.Location = new System.Drawing.Point(110, 211);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(75, 23);
            this.btnModificar2.TabIndex = 3;
            this.btnModificar2.Text = "Modificar";
            this.btnModificar2.UseVisualStyleBackColor = true;
            this.btnModificar2.Click += new System.EventHandler(this.btnModificar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(18, 211);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar2.TabIndex = 3;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // txtCodCons
            // 
            this.txtCodCons.Location = new System.Drawing.Point(18, 94);
            this.txtCodCons.Name = "txtCodCons";
            this.txtCodCons.Size = new System.Drawing.Size(110, 20);
            this.txtCodCons.TabIndex = 2;
            // 
            // ListaCodConsultas
            // 
            this.ListaCodConsultas.FormattingEnabled = true;
            this.ListaCodConsultas.Location = new System.Drawing.Point(295, 35);
            this.ListaCodConsultas.Name = "ListaCodConsultas";
            this.ListaCodConsultas.Size = new System.Drawing.Size(161, 212);
            this.ListaCodConsultas.TabIndex = 1;
            this.ListaCodConsultas.SelectedIndexChanged += new System.EventHandler(this.ListaCodConsultas_SelectedIndexChanged);
            // 
            // frmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConfiguraciones";
            this.Text = "frmConfiguraciones";
            this.Load += new System.EventHandler(this.frmConfiguraciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.ListBox ListaTipos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnModificar2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.TextBox txtCodCons;
        private System.Windows.Forms.ListBox ListaCodConsultas;
    }
}