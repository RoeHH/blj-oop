
namespace RechtecksFlächeBerechenen
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
            this.BerechnenButton = new System.Windows.Forms.Button();
            this.BeendenButton = new System.Windows.Forms.Button();
            this.Ausgabe = new System.Windows.Forms.TextBox();
            this.InputHöhe = new System.Windows.Forms.TextBox();
            this.InputBreite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BerechnenButton
            // 
            this.BerechnenButton.Location = new System.Drawing.Point(568, 89);
            this.BerechnenButton.Name = "BerechnenButton";
            this.BerechnenButton.Size = new System.Drawing.Size(144, 36);
            this.BerechnenButton.TabIndex = 0;
            this.BerechnenButton.Text = "Berechnen";
            this.BerechnenButton.UseVisualStyleBackColor = true;
            this.BerechnenButton.Click += new System.EventHandler(this.BerechnenButton_Click);
            // 
            // BeendenButton
            // 
            this.BeendenButton.Location = new System.Drawing.Point(568, 225);
            this.BeendenButton.Name = "BeendenButton";
            this.BeendenButton.Size = new System.Drawing.Size(144, 36);
            this.BeendenButton.TabIndex = 1;
            this.BeendenButton.Text = "Beenden";
            this.BeendenButton.UseVisualStyleBackColor = true;
            this.BeendenButton.Click += new System.EventHandler(this.BeendenButton_Click);
            // 
            // Ausgabe
            // 
            this.Ausgabe.Location = new System.Drawing.Point(300, 241);
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.ReadOnly = true;
            this.Ausgabe.Size = new System.Drawing.Size(168, 20);
            this.Ausgabe.TabIndex = 2;
            // 
            // InputHöhe
            // 
            this.InputHöhe.Location = new System.Drawing.Point(300, 133);
            this.InputHöhe.Name = "InputHöhe";
            this.InputHöhe.Size = new System.Drawing.Size(168, 20);
            this.InputHöhe.TabIndex = 3;
            this.InputHöhe.TextChanged += new System.EventHandler(this.InputHöhe_TextChanged);
            // 
            // InputBreite
            // 
            this.InputBreite.Location = new System.Drawing.Point(300, 89);
            this.InputBreite.Name = "InputBreite";
            this.InputBreite.Size = new System.Drawing.Size(168, 20);
            this.InputBreite.TabIndex = 4;
            this.InputBreite.TextChanged += new System.EventHandler(this.InputBreite_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Breite des Rechtecks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ausgabe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Höhe des Rechtecks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBreite);
            this.Controls.Add(this.InputHöhe);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.BeendenButton);
            this.Controls.Add(this.BerechnenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BerechnenButton;
        private System.Windows.Forms.Button BeendenButton;
        private System.Windows.Forms.TextBox Ausgabe;
        private System.Windows.Forms.TextBox InputHöhe;
        private System.Windows.Forms.TextBox InputBreite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

