
namespace Tannenbaum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Stammbreite = new System.Windows.Forms.NumericUpDown();
            this.Kronenhöhe = new System.Windows.Forms.NumericUpDown();
            this.Stammhöhe = new System.Windows.Forms.NumericUpDown();
            this.draw = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Stammbreite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kronenhöhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stammhöhe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stammbreite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kronenhöhe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stammhöhe";
            // 
            // Stammbreite
            // 
            this.Stammbreite.Location = new System.Drawing.Point(83, 18);
            this.Stammbreite.Name = "Stammbreite";
            this.Stammbreite.Size = new System.Drawing.Size(120, 20);
            this.Stammbreite.TabIndex = 4;
            this.Stammbreite.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Kronenhöhe
            // 
            this.Kronenhöhe.Location = new System.Drawing.Point(83, 85);
            this.Kronenhöhe.Name = "Kronenhöhe";
            this.Kronenhöhe.Size = new System.Drawing.Size(120, 20);
            this.Kronenhöhe.TabIndex = 5;
            this.Kronenhöhe.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Stammhöhe
            // 
            this.Stammhöhe.Location = new System.Drawing.Point(83, 49);
            this.Stammhöhe.Name = "Stammhöhe";
            this.Stammhöhe.Size = new System.Drawing.Size(120, 20);
            this.Stammhöhe.TabIndex = 6;
            this.Stammhöhe.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(220, 18);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(257, 87);
            this.draw.TabIndex = 7;
            this.draw.Text = "Tanne Zeichnen";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 111);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(465, 493);
            this.textBoxResult.TabIndex = 8;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 616);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.Stammhöhe);
            this.Controls.Add(this.Kronenhöhe);
            this.Controls.Add(this.Stammbreite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Stammbreite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kronenhöhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stammhöhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Stammbreite;
        private System.Windows.Forms.NumericUpDown Kronenhöhe;
        private System.Windows.Forms.NumericUpDown Stammhöhe;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

