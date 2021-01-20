
namespace Zahlenspeicher
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
            this.addButton = new System.Windows.Forms.Button();
            this.inPut = new System.Windows.Forms.TextBox();
            this.ascend = new System.Windows.Forms.RadioButton();
            this.descend = new System.Windows.Forms.RadioButton();
            this.outPut = new System.Windows.Forms.TextBox();
            this.get = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(129, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // inPut
            // 
            this.inPut.Location = new System.Drawing.Point(12, 12);
            this.inPut.Name = "inPut";
            this.inPut.Size = new System.Drawing.Size(100, 20);
            this.inPut.TabIndex = 1;
            // 
            // ascend
            // 
            this.ascend.AutoSize = true;
            this.ascend.Location = new System.Drawing.Point(12, 73);
            this.ascend.Name = "ascend";
            this.ascend.Size = new System.Drawing.Size(61, 17);
            this.ascend.TabIndex = 2;
            this.ascend.TabStop = true;
            this.ascend.Text = "Ascend";
            this.ascend.UseVisualStyleBackColor = true;
            // 
            // descend
            // 
            this.descend.AutoSize = true;
            this.descend.Location = new System.Drawing.Point(12, 96);
            this.descend.Name = "descend";
            this.descend.Size = new System.Drawing.Size(68, 17);
            this.descend.TabIndex = 3;
            this.descend.TabStop = true;
            this.descend.Text = "Descend";
            this.descend.UseVisualStyleBackColor = true;
            // 
            // outPut
            // 
            this.outPut.Location = new System.Drawing.Point(12, 120);
            this.outPut.Name = "outPut";
            this.outPut.ReadOnly = true;
            this.outPut.Size = new System.Drawing.Size(192, 20);
            this.outPut.TabIndex = 4;
            // 
            // get
            // 
            this.get.Location = new System.Drawing.Point(129, 73);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(75, 23);
            this.get.TabIndex = 5;
            this.get.Text = "get";
            this.get.UseVisualStyleBackColor = true;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 147);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(192, 23);
            this.clear.TabIndex = 6;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 190);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.get);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.descend);
            this.Controls.Add(this.ascend);
            this.Controls.Add(this.inPut);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox inPut;
        private System.Windows.Forms.RadioButton ascend;
        private System.Windows.Forms.RadioButton descend;
        private System.Windows.Forms.TextBox outPut;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Button clear;
    }
}

