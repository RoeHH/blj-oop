
namespace ErdeMond
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
            this.inDays = new System.Windows.Forms.RadioButton();
            this.inHours = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.callculate = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reisedauer zum Mond berechnen";
            // 
            // inDays
            // 
            this.inDays.AutoSize = true;
            this.inDays.Location = new System.Drawing.Point(31, 75);
            this.inDays.Name = "inDays";
            this.inDays.Size = new System.Drawing.Size(67, 17);
            this.inDays.TabIndex = 1;
            this.inDays.TabStop = true;
            this.inDays.Text = "in Tagen";
            this.inDays.UseVisualStyleBackColor = true;
            this.inDays.CheckedChanged += new System.EventHandler(this.inDays_CheckedChanged);
            // 
            // inHours
            // 
            this.inHours.AutoSize = true;
            this.inHours.Location = new System.Drawing.Point(122, 75);
            this.inHours.Name = "inHours";
            this.inHours.Size = new System.Drawing.Size(76, 17);
            this.inHours.TabIndex = 2;
            this.inHours.TabStop = true;
            this.inHours.Text = "in Stunden";
            this.inHours.UseVisualStyleBackColor = true;
            this.inHours.CheckedChanged += new System.EventHandler(this.inHours_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Geschwindigkeit in km/h";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(162, 111);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(100, 20);
            this.speed.TabIndex = 4;
            this.speed.TextChanged += new System.EventHandler(this.speed_TextChanged);
            // 
            // callculate
            // 
            this.callculate.Location = new System.Drawing.Point(31, 141);
            this.callculate.Name = "callculate";
            this.callculate.Size = new System.Drawing.Size(231, 51);
            this.callculate.TabIndex = 5;
            this.callculate.Text = "Berechnen";
            this.callculate.UseVisualStyleBackColor = true;
            this.callculate.Click += new System.EventHandler(this.callculate_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(98, 195);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 20);
            this.output.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reisedauer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output);
            this.Controls.Add(this.callculate);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inHours);
            this.Controls.Add(this.inDays);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inDays;
        private System.Windows.Forms.RadioButton inHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.Button callculate;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Label label3;
    }
}

