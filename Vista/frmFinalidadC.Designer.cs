namespace Vista
{
    partial class frmFinalidadC
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarF = new System.Windows.Forms.Button();
            this.btnModificarF = new System.Windows.Forms.Button();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.txtTipoF = new System.Windows.Forms.TextBox();
            this.listFinalidad = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnEliminarF);
            this.groupBox3.Controls.Add(this.btnModificarF);
            this.groupBox3.Controls.Add(this.btnAgregarF);
            this.groupBox3.Controls.Add(this.txtTipoF);
            this.groupBox3.Controls.Add(this.listFinalidad);
            this.groupBox3.Location = new System.Drawing.Point(137, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 281);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FINALIDAD CONSULTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Finalidad";
            // 
            // btnEliminarF
            // 
            this.btnEliminarF.Location = new System.Drawing.Point(205, 211);
            this.btnEliminarF.Name = "btnEliminarF";
            this.btnEliminarF.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarF.TabIndex = 3;
            this.btnEliminarF.Text = "Eliminar";
            this.btnEliminarF.UseVisualStyleBackColor = true;
            this.btnEliminarF.Click += new System.EventHandler(this.btnEliminarF_Click);
            // 
            // btnModificarF
            // 
            this.btnModificarF.Location = new System.Drawing.Point(110, 211);
            this.btnModificarF.Name = "btnModificarF";
            this.btnModificarF.Size = new System.Drawing.Size(75, 23);
            this.btnModificarF.TabIndex = 3;
            this.btnModificarF.Text = "Modificar";
            this.btnModificarF.UseVisualStyleBackColor = true;
            this.btnModificarF.Click += new System.EventHandler(this.btnModificarF_Click);
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.Location = new System.Drawing.Point(18, 211);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarF.TabIndex = 3;
            this.btnAgregarF.Text = "Agregar";
            this.btnAgregarF.UseVisualStyleBackColor = true;
            this.btnAgregarF.Click += new System.EventHandler(this.btnAgregarF_Click);
            // 
            // txtTipoF
            // 
            this.txtTipoF.Location = new System.Drawing.Point(18, 94);
            this.txtTipoF.Name = "txtTipoF";
            this.txtTipoF.Size = new System.Drawing.Size(110, 20);
            this.txtTipoF.TabIndex = 2;
            // 
            // listFinalidad
            // 
            this.listFinalidad.FormattingEnabled = true;
            this.listFinalidad.Location = new System.Drawing.Point(295, 35);
            this.listFinalidad.Name = "listFinalidad";
            this.listFinalidad.Size = new System.Drawing.Size(161, 212);
            this.listFinalidad.TabIndex = 1;
            this.listFinalidad.SelectedIndexChanged += new System.EventHandler(this.listFinalidad_SelectedIndexChanged);
            // 
            // frmFinalidadC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmFinalidadC";
            this.Text = "frmFinalidadC";
            this.Load += new System.EventHandler(this.frmFinalidadC_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarF;
        private System.Windows.Forms.Button btnModificarF;
        private System.Windows.Forms.Button btnAgregarF;
        private System.Windows.Forms.TextBox txtTipoF;
        private System.Windows.Forms.ListBox listFinalidad;
    }
}