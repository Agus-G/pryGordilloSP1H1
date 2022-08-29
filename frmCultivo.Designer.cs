namespace pryGordilloSP1H1
{
    partial class frmCultivo
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
            this.txtCodigoCultivo = new System.Windows.Forms.TextBox();
            this.txtCultivo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.cmdCargarCultivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigoCultivo
            // 
            this.txtCodigoCultivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCultivo.Location = new System.Drawing.Point(123, 35);
            this.txtCodigoCultivo.Name = "txtCodigoCultivo";
            this.txtCodigoCultivo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoCultivo.TabIndex = 0;
            // 
            // txtCultivo
            // 
            this.txtCultivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCultivo.Location = new System.Drawing.Point(123, 102);
            this.txtCultivo.Name = "txtCultivo";
            this.txtCultivo.Size = new System.Drawing.Size(100, 26);
            this.txtCultivo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(44, 37);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Location = new System.Drawing.Point(44, 104);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(56, 20);
            this.lblCultivo.TabIndex = 3;
            this.lblCultivo.Text = "Cultivo";
            // 
            // cmdCargarCultivo
            // 
            this.cmdCargarCultivo.AccessibleDescription = "";
            this.cmdCargarCultivo.Location = new System.Drawing.Point(77, 171);
            this.cmdCargarCultivo.Name = "cmdCargarCultivo";
            this.cmdCargarCultivo.Size = new System.Drawing.Size(94, 38);
            this.cmdCargarCultivo.TabIndex = 4;
            this.cmdCargarCultivo.Text = "Cargar";
            this.cmdCargarCultivo.UseVisualStyleBackColor = true;
            this.cmdCargarCultivo.Click += new System.EventHandler(this.cmdCargarCultivo_Click);
            // 
            // frmCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(272, 239);
            this.Controls.Add(this.cmdCargarCultivo);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCultivo);
            this.Controls.Add(this.txtCodigoCultivo);
            this.Name = "frmCultivo";
            this.Text = "Cultivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoCultivo;
        private System.Windows.Forms.TextBox txtCultivo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Button cmdCargarCultivo;
    }
}