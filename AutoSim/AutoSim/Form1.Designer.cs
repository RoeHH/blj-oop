
namespace AutoSim
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
            this.HuppeButton = new System.Windows.Forms.Button();
            this.keyButton = new System.Windows.Forms.Button();
            this.autoInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GeschwindigkeitOutPut = new System.Windows.Forms.RichTextBox();
            this.GangOutPut = new System.Windows.Forms.RichTextBox();
            this.bremseButton = new System.Windows.Forms.Button();
            this.gasButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.psOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HuppeButton
            // 
            this.HuppeButton.Image = global::AutoSim.Properties.Resources.hupe;
            this.HuppeButton.Location = new System.Drawing.Point(34, 162);
            this.HuppeButton.Name = "HuppeButton";
            this.HuppeButton.Size = new System.Drawing.Size(73, 67);
            this.HuppeButton.TabIndex = 1;
            this.HuppeButton.UseVisualStyleBackColor = true;
            this.HuppeButton.Click += new System.EventHandler(this.HuppeButton_Click);
            // 
            // keyButton
            // 
            this.keyButton.Image = global::AutoSim.Properties.Resources.autoAus;
            this.keyButton.Location = new System.Drawing.Point(34, 90);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(82, 66);
            this.keyButton.TabIndex = 0;
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.key_Click);
            // 
            // autoInput
            // 
            this.autoInput.FormattingEnabled = true;
            this.autoInput.Location = new System.Drawing.Point(299, 30);
            this.autoInput.Name = "autoInput";
            this.autoInput.Size = new System.Drawing.Size(121, 21);
            this.autoInput.TabIndex = 2;
            this.autoInput.SelectedIndexChanged += new System.EventHandler(this.autoInput_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Auto Wählen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KM/H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gang";
            // 
            // GeschwindigkeitOutPut
            // 
            this.GeschwindigkeitOutPut.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GeschwindigkeitOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.GeschwindigkeitOutPut.ForeColor = System.Drawing.SystemColors.Menu;
            this.GeschwindigkeitOutPut.Location = new System.Drawing.Point(188, 102);
            this.GeschwindigkeitOutPut.Name = "GeschwindigkeitOutPut";
            this.GeschwindigkeitOutPut.Size = new System.Drawing.Size(208, 96);
            this.GeschwindigkeitOutPut.TabIndex = 7;
            this.GeschwindigkeitOutPut.Text = "";
            // 
            // GangOutPut
            // 
            this.GangOutPut.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GangOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F);
            this.GangOutPut.ForeColor = System.Drawing.SystemColors.Menu;
            this.GangOutPut.Location = new System.Drawing.Point(413, 102);
            this.GangOutPut.Name = "GangOutPut";
            this.GangOutPut.Size = new System.Drawing.Size(91, 96);
            this.GangOutPut.TabIndex = 8;
            this.GangOutPut.Text = "";
            // 
            // bremseButton
            // 
            this.bremseButton.BackColor = System.Drawing.Color.White;
            this.bremseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.bremseButton.Location = new System.Drawing.Point(188, 219);
            this.bremseButton.Name = "bremseButton";
            this.bremseButton.Size = new System.Drawing.Size(208, 156);
            this.bremseButton.TabIndex = 9;
            this.bremseButton.Text = "Bremse";
            this.bremseButton.UseVisualStyleBackColor = false;
            this.bremseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bremseButton_MouseDown);
            this.bremseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bremseButton_MouseUp);
            // 
            // gasButton
            // 
            this.gasButton.BackColor = System.Drawing.Color.White;
            this.gasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.gasButton.Location = new System.Drawing.Point(413, 219);
            this.gasButton.Name = "gasButton";
            this.gasButton.Size = new System.Drawing.Size(87, 156);
            this.gasButton.TabIndex = 10;
            this.gasButton.Text = "Gas";
            this.gasButton.UseVisualStyleBackColor = false;
            this.gasButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gasButton_MouseDown);
            this.gasButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gasButton_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "PS:";
            // 
            // psOut
            // 
            this.psOut.AutoSize = true;
            this.psOut.Location = new System.Drawing.Point(458, 33);
            this.psOut.Name = "psOut";
            this.psOut.Size = new System.Drawing.Size(0, 13);
            this.psOut.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.psOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gasButton);
            this.Controls.Add(this.bremseButton);
            this.Controls.Add(this.GangOutPut);
            this.Controls.Add(this.GeschwindigkeitOutPut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoInput);
            this.Controls.Add(this.HuppeButton);
            this.Controls.Add(this.keyButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.Button HuppeButton;
        private System.Windows.Forms.ComboBox autoInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox GeschwindigkeitOutPut;
        private System.Windows.Forms.RichTextBox GangOutPut;
        private System.Windows.Forms.Button bremseButton;
        private System.Windows.Forms.Button gasButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label psOut;
    }
}

