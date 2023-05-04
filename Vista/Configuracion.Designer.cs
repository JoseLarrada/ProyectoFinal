namespace Vista
{
    partial class Configuracion
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
            this.btnTipo = new System.Windows.Forms.Button();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.btnFinalidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTipo
            // 
            this.btnTipo.Location = new System.Drawing.Point(324, 99);
            this.btnTipo.Name = "btnTipo";
            this.btnTipo.Size = new System.Drawing.Size(75, 23);
            this.btnTipo.TabIndex = 0;
            this.btnTipo.Text = "Tipo Datos";
            this.btnTipo.UseVisualStyleBackColor = true;
            this.btnTipo.Click += new System.EventHandler(this.btnTipo_Click);
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(294, 148);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(137, 23);
            this.btnCodigo.TabIndex = 0;
            this.btnCodigo.Text = "Codigo Consultas";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // btnFinalidad
            // 
            this.btnFinalidad.Location = new System.Drawing.Point(309, 201);
            this.btnFinalidad.Name = "btnFinalidad";
            this.btnFinalidad.Size = new System.Drawing.Size(107, 23);
            this.btnFinalidad.TabIndex = 1;
            this.btnFinalidad.Text = "Finalidad Consulta";
            this.btnFinalidad.UseVisualStyleBackColor = true;
            this.btnFinalidad.Click += new System.EventHandler(this.btnFinalidad_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalidad);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.btnTipo);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTipo;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.Button btnFinalidad;
    }
}