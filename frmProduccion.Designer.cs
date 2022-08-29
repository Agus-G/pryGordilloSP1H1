namespace pryGordilloSP1H1
{
    partial class frmConsulta
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
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.lblMostrarNombreLocalidad = new System.Windows.Forms.Label();
            this.lblMostrarNombreCultivo = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombreCultivo = new System.Windows.Forms.Label();
            this.lblNombreLocalidad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMostrarFecha
            // 
            this.lblMostrarFecha.AutoSize = true;
            this.lblMostrarFecha.Location = new System.Drawing.Point(171, 37);
            this.lblMostrarFecha.Name = "lblMostrarFecha";
            this.lblMostrarFecha.Size = new System.Drawing.Size(51, 20);
            this.lblMostrarFecha.TabIndex = 0;
            this.lblMostrarFecha.Text = "label1";
            // 
            // lblMostrarNombreLocalidad
            // 
            this.lblMostrarNombreLocalidad.AutoSize = true;
            this.lblMostrarNombreLocalidad.Location = new System.Drawing.Point(171, 89);
            this.lblMostrarNombreLocalidad.Name = "lblMostrarNombreLocalidad";
            this.lblMostrarNombreLocalidad.Size = new System.Drawing.Size(51, 20);
            this.lblMostrarNombreLocalidad.TabIndex = 1;
            this.lblMostrarNombreLocalidad.Text = "label2";
            // 
            // lblMostrarNombreCultivo
            // 
            this.lblMostrarNombreCultivo.AccessibleDescription = "";
            this.lblMostrarNombreCultivo.AutoSize = true;
            this.lblMostrarNombreCultivo.Location = new System.Drawing.Point(171, 139);
            this.lblMostrarNombreCultivo.Name = "lblMostrarNombreCultivo";
            this.lblMostrarNombreCultivo.Size = new System.Drawing.Size(51, 20);
            this.lblMostrarNombreCultivo.TabIndex = 2;
            this.lblMostrarNombreCultivo.Text = "label3";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(101, 181);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(92, 35);
            this.cmdConsultar.TabIndex = 4;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(65, 240);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblNombreCultivo
            // 
            this.lblNombreCultivo.AccessibleDescription = "";
            this.lblNombreCultivo.AutoSize = true;
            this.lblNombreCultivo.Location = new System.Drawing.Point(65, 139);
            this.lblNombreCultivo.Name = "lblNombreCultivo";
            this.lblNombreCultivo.Size = new System.Drawing.Size(60, 20);
            this.lblNombreCultivo.TabIndex = 7;
            this.lblNombreCultivo.Text = "Cultivo:";
            // 
            // lblNombreLocalidad
            // 
            this.lblNombreLocalidad.AutoSize = true;
            this.lblNombreLocalidad.Location = new System.Drawing.Point(65, 89);
            this.lblNombreLocalidad.Name = "lblNombreLocalidad";
            this.lblNombreLocalidad.Size = new System.Drawing.Size(81, 20);
            this.lblNombreLocalidad.TabIndex = 6;
            this.lblNombreLocalidad.Text = "Localidad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(65, 37);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 20);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 26);
            this.textBox1.TabIndex = 9;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(101, 278);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(92, 31);
            this.cmdCargar.TabIndex = 10;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(376, 330);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreCultivo);
            this.Controls.Add(this.lblNombreLocalidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.lblMostrarNombreCultivo);
            this.Controls.Add(this.lblMostrarNombreLocalidad);
            this.Controls.Add(this.lblMostrarFecha);
            this.Name = "frmConsulta";
            this.Text = "Produccion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.Label lblMostrarNombreLocalidad;
        private System.Windows.Forms.Label lblMostrarNombreCultivo;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombreCultivo;
        private System.Windows.Forms.Label lblNombreLocalidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdCargar;
    }
}