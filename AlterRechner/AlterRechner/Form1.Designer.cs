
namespace AlterRechner
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
            this.Years = new System.Windows.Forms.RadioButton();
            this.Months = new System.Windows.Forms.RadioButton();
            this.Days = new System.Windows.Forms.RadioButton();
            this.Hours = new System.Windows.Forms.RadioButton();
            this.seconds = new System.Windows.Forms.RadioButton();
            this.minutes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ageOutput = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Years
            // 
            this.Years.AutoSize = true;
            this.Years.Location = new System.Drawing.Point(23, 26);
            this.Years.Name = "Years";
            this.Years.Size = new System.Drawing.Size(51, 17);
            this.Years.TabIndex = 0;
            this.Years.TabStop = true;
            this.Years.Text = "Jahre";
            this.Years.UseVisualStyleBackColor = true;
            this.Years.CheckedChanged += new System.EventHandler(this.Years_CheckedChanged);
            // 
            // Months
            // 
            this.Months.AutoSize = true;
            this.Months.Location = new System.Drawing.Point(80, 26);
            this.Months.Name = "Months";
            this.Months.Size = new System.Drawing.Size(61, 17);
            this.Months.TabIndex = 1;
            this.Months.TabStop = true;
            this.Months.Text = "Monate";
            this.Months.UseVisualStyleBackColor = true;
            this.Months.CheckedChanged += new System.EventHandler(this.Months_CheckedChanged);
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(147, 26);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(50, 17);
            this.Days.TabIndex = 2;
            this.Days.TabStop = true;
            this.Days.Text = "Tage";
            this.Days.UseVisualStyleBackColor = true;
            this.Days.CheckedChanged += new System.EventHandler(this.Days_CheckedChanged);
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(203, 26);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(65, 17);
            this.Hours.TabIndex = 3;
            this.Hours.TabStop = true;
            this.Hours.Text = "Stunden";
            this.Hours.UseVisualStyleBackColor = true;
            this.Hours.CheckedChanged += new System.EventHandler(this.Hours_CheckedChanged);
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Location = new System.Drawing.Point(345, 26);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(74, 17);
            this.seconds.TabIndex = 4;
            this.seconds.TabStop = true;
            this.seconds.Text = "Sekunden";
            this.seconds.UseVisualStyleBackColor = true;
            this.seconds.CheckedChanged += new System.EventHandler(this.seconds_CheckedChanged);
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Location = new System.Drawing.Point(274, 26);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(63, 17);
            this.minutes.TabIndex = 5;
            this.minutes.TabStop = true;
            this.minutes.Text = "Minuten";
            this.minutes.UseVisualStyleBackColor = true;
            this.minutes.CheckedChanged += new System.EventHandler(this.minutes_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Geburtsdatum:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(105, 66);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alter:";
            // 
            // ageOutput
            // 
            this.ageOutput.AutoSize = true;
            this.ageOutput.Location = new System.Drawing.Point(64, 109);
            this.ageOutput.Name = "ageOutput";
            this.ageOutput.Size = new System.Drawing.Size(0, 13);
            this.ageOutput.TabIndex = 9;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(311, 58);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(108, 40);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Berechen";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 144);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.ageOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Months);
            this.Controls.Add(this.Years);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Years;
        private System.Windows.Forms.RadioButton Months;
        private System.Windows.Forms.RadioButton Days;
        private System.Windows.Forms.RadioButton Hours;
        private System.Windows.Forms.RadioButton seconds;
        private System.Windows.Forms.RadioButton minutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ageOutput;
        private System.Windows.Forms.Button calcButton;
    }
}

