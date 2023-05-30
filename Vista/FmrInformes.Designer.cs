namespace Vista
{
    partial class FmrInformes
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
            this.cbbConsultas = new System.Windows.Forms.CheckBox();
            this.cbbProcedimientos = new System.Windows.Forms.CheckBox();
            this.cbbFacturas = new System.Windows.Forms.CheckBox();
            this.Fechas = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbConsultas
            // 
            this.cbbConsultas.AutoSize = true;
            this.cbbConsultas.Location = new System.Drawing.Point(41, 127);
            this.cbbConsultas.Name = "cbbConsultas";
            this.cbbConsultas.Size = new System.Drawing.Size(96, 17);
            this.cbbConsultas.TabIndex = 0;
            this.cbbConsultas.Text = "Rips Consultas";
            this.cbbConsultas.UseVisualStyleBackColor = true;
            this.cbbConsultas.CheckedChanged += new System.EventHandler(this.cbbConsultas_CheckedChanged);
            // 
            // cbbProcedimientos
            // 
            this.cbbProcedimientos.AutoSize = true;
            this.cbbProcedimientos.Location = new System.Drawing.Point(41, 180);
            this.cbbProcedimientos.Name = "cbbProcedimientos";
            this.cbbProcedimientos.Size = new System.Drawing.Size(122, 17);
            this.cbbProcedimientos.TabIndex = 0;
            this.cbbProcedimientos.Text = "Rips Procedimientos";
            this.cbbProcedimientos.UseVisualStyleBackColor = true;
            this.cbbProcedimientos.CheckedChanged += new System.EventHandler(this.cbbProcedimientos_CheckedChanged);
            // 
            // cbbFacturas
            // 
            this.cbbFacturas.AutoSize = true;
            this.cbbFacturas.Location = new System.Drawing.Point(41, 233);
            this.cbbFacturas.Name = "cbbFacturas";
            this.cbbFacturas.Size = new System.Drawing.Size(91, 17);
            this.cbbFacturas.TabIndex = 0;
            this.cbbFacturas.Text = "Rips Facturas";
            this.cbbFacturas.UseVisualStyleBackColor = true;
            this.cbbFacturas.CheckedChanged += new System.EventHandler(this.cbbFacturas_CheckedChanged);
            // 
            // Fechas
            // 
            this.Fechas.Location = new System.Drawing.Point(41, 66);
            this.Fechas.Name = "Fechas";
            this.Fechas.Size = new System.Drawing.Size(200, 20);
            this.Fechas.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbProcedimientos);
            this.panel1.Controls.Add(this.Fechas);
            this.panel1.Controls.Add(this.cbbConsultas);
            this.panel1.Controls.Add(this.cbbFacturas);
            this.panel1.Location = new System.Drawing.Point(100, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 284);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Rips";
            // 
            // FmrInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 630);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmrInformes";
            this.Text = "FmrInformes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbbConsultas;
        private System.Windows.Forms.CheckBox cbbProcedimientos;
        private System.Windows.Forms.CheckBox cbbFacturas;
        private System.Windows.Forms.DateTimePicker Fechas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}