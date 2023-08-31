
namespace DEMO_EXE
{
    partial class Form1
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
            this.lstListado = new System.Windows.Forms.ListBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListado
            // 
            this.lstListado.FormattingEnabled = true;
            this.lstListado.Location = new System.Drawing.Point(23, 23);
            this.lstListado.Name = "lstListado";
            this.lstListado.Size = new System.Drawing.Size(202, 303);
            this.lstListado.TabIndex = 0;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(303, 168);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(75, 23);
            this.cmdGrabar.TabIndex = 1;
            this.cmdGrabar.Text = "GRABAR";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 353);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.lstListado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListado;
        private System.Windows.Forms.Button cmdGrabar;
    }
}

