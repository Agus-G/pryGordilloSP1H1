namespace pryGordilloSP1H1
{
    partial class frmLocalidad
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
            this.cmdCargarLocalidad = new System.Windows.Forms.Button();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCodigoLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtCodigoLocalidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdCargarLocalidad
            // 
            this.cmdCargarLocalidad.AccessibleDescription = "";
            this.cmdCargarLocalidad.Location = new System.Drawing.Point(80, 158);
            this.cmdCargarLocalidad.Name = "cmdCargarLocalidad";
            this.cmdCargarLocalidad.Size = new System.Drawing.Size(94, 38);
            this.cmdCargarLocalidad.TabIndex = 9;
            this.cmdCargarLocalidad.Text = "Cargar";
            this.cmdCargarLocalidad.UseVisualStyleBackColor = true;
            this.cmdCargarLocalidad.Click += new System.EventHandler(this.cmdCargarLocalidad_Click);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(45, 94);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 20);
            this.lblLocalidad.TabIndex = 8;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblCodigoLocalidad
            // 
            this.lblCodigoLocalidad.AutoSize = true;
            this.lblCodigoLocalidad.Location = new System.Drawing.Point(45, 33);
            this.lblCodigoLocalidad.Name = "lblCodigoLocalidad";
            this.lblCodigoLocalidad.Size = new System.Drawing.Size(59, 20);
            this.lblCodigoLocalidad.TabIndex = 7;
            this.lblCodigoLocalidad.Text = "Codigo";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocalidad.Location = new System.Drawing.Point(140, 92);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 26);
            this.txtLocalidad.TabIndex = 6;
            // 
            // txtCodigoLocalidad
            // 
            this.txtCodigoLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoLocalidad.Location = new System.Drawing.Point(140, 31);
            this.txtCodigoLocalidad.Name = "txtCodigoLocalidad";
            this.txtCodigoLocalidad.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoLocalidad.TabIndex = 5;
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(274, 230);
            this.Controls.Add(this.cmdCargarLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblCodigoLocalidad);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtCodigoLocalidad);
            this.Name = "frmLocalidad";
            this.Text = "Localidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCargarLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCodigoLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtCodigoLocalidad;
    }
}