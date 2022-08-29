namespace pryGordilloSP1H1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalidad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCultivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMantenimiento,
            this.tsmConsulta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMantenimiento
            // 
            this.tsmMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalidad,
            this.tsmCultivo,
            this.tsmProduccion,
            this.tsmSalir});
            this.tsmMantenimiento.Name = "tsmMantenimiento";
            this.tsmMantenimiento.Size = new System.Drawing.Size(148, 29);
            this.tsmMantenimiento.Text = "Mantenimiento";
            // 
            // tsmLocalidad
            // 
            this.tsmLocalidad.Name = "tsmLocalidad";
            this.tsmLocalidad.Size = new System.Drawing.Size(270, 34);
            this.tsmLocalidad.Text = "Localidad";
            this.tsmLocalidad.Click += new System.EventHandler(this.tsmLocalidad_Click);
            // 
            // tsmCultivo
            // 
            this.tsmCultivo.Name = "tsmCultivo";
            this.tsmCultivo.Size = new System.Drawing.Size(270, 34);
            this.tsmCultivo.Text = "Cultivos";
            this.tsmCultivo.Click += new System.EventHandler(this.tsmCultivo_Click);
            // 
            // tsmProduccion
            // 
            this.tsmProduccion.Name = "tsmProduccion";
            this.tsmProduccion.Size = new System.Drawing.Size(270, 34);
            this.tsmProduccion.Text = "Producción";
            this.tsmProduccion.Click += new System.EventHandler(this.tsmProduccion_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(270, 34);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(97, 29);
            this.tsmConsulta.Text = "Consulta";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalidad;
        private System.Windows.Forms.ToolStripMenuItem tsmCultivo;
        private System.Windows.Forms.ToolStripMenuItem tsmProduccion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmConsulta;
    }
}

