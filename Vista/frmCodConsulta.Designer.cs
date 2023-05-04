namespace Vista
{
    partial class frmCodConsulta
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnModificar2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.txtCodCons = new System.Windows.Forms.TextBox();
            this.ListaCodConsultas = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnEliminar2);
            this.groupBox2.Controls.Add(this.btnModificar2);
            this.groupBox2.Controls.Add(this.btnAgregar2);
            this.groupBox2.Controls.Add(this.txtCodCons);
            this.groupBox2.Controls.Add(this.ListaCodConsultas);
            this.groupBox2.Location = new System.Drawing.Point(138, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 281);
            this.groupBox2.TabIndex = 2;
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
            // frmCodConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCodConsulta";
            this.Text = "frmCodConsulta";
            this.Load += new System.EventHandler(this.frmCodConsulta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnModificar2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.TextBox txtCodCons;
        private System.Windows.Forms.ListBox ListaCodConsultas;
    }
}