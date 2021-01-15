
namespace Instanzenzähler
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.neu = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.outPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // neu
            // 
            this.neu.Location = new System.Drawing.Point(12, 12);
            this.neu.Name = "neu";
            this.neu.Size = new System.Drawing.Size(75, 23);
            this.neu.TabIndex = 0;
            this.neu.Text = "neu";
            this.neu.UseVisualStyleBackColor = true;
            this.neu.Click += new System.EventHandler(this.neu_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(12, 50);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 1;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // outPut
            // 
            this.outPut.AutoSize = true;
            this.outPut.Location = new System.Drawing.Point(101, 22);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(106, 13);
            this.outPut.TabIndex = 2;
            this.outPut.Text = "Anzahle Instanzen: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 86);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.neu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button neu;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label outPut;
    }
}

