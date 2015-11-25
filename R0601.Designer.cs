namespace R0601
{
    partial class R0601
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
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtRutaXml = new System.Windows.Forms.TextBox();
            this.btnCargarXml = new System.Windows.Forms.Button();
            this.trvXml = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(13, 13);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(46, 13);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Archivo:";
            // 
            // txtRutaXml
            // 
            this.txtRutaXml.Location = new System.Drawing.Point(66, 13);
            this.txtRutaXml.Name = "txtRutaXml";
            this.txtRutaXml.Size = new System.Drawing.Size(412, 20);
            this.txtRutaXml.TabIndex = 1;
            // 
            // btnCargarXml
            // 
            this.btnCargarXml.Location = new System.Drawing.Point(484, 12);
            this.btnCargarXml.Name = "btnCargarXml";
            this.btnCargarXml.Size = new System.Drawing.Size(75, 23);
            this.btnCargarXml.TabIndex = 2;
            this.btnCargarXml.Text = "Cargar";
            this.btnCargarXml.UseVisualStyleBackColor = true;
            this.btnCargarXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // trvXml
            // 
            this.trvXml.Location = new System.Drawing.Point(16, 42);
            this.trvXml.Name = "trvXml";
            this.trvXml.Size = new System.Drawing.Size(543, 281);
            this.trvXml.TabIndex = 3;
            // 
            // R0601
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 335);
            this.Controls.Add(this.trvXml);
            this.Controls.Add(this.btnCargarXml);
            this.Controls.Add(this.txtRutaXml);
            this.Controls.Add(this.lblArchivo);
            this.Name = "R0601";
            this.Text = "R0601 - XmlTree";
            this.Load += new System.EventHandler(this.R0601_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtRutaXml;
        private System.Windows.Forms.Button btnCargarXml;
        private System.Windows.Forms.TreeView trvXml;
    }
}

