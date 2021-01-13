
namespace FifoPuffer
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
            this.sizeInPut = new System.Windows.Forms.NumericUpDown();
            this.createButton = new System.Windows.Forms.Button();
            this.putButton = new System.Windows.Forms.Button();
            this.outPut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getAllButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.inPut = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sizeInPut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inPut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIFO PUFFER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "P.size";
            // 
            // sizeInPut
            // 
            this.sizeInPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeInPut.Location = new System.Drawing.Point(53, 36);
            this.sizeInPut.Name = "sizeInPut";
            this.sizeInPut.Size = new System.Drawing.Size(120, 20);
            this.sizeInPut.TabIndex = 2;
            this.sizeInPut.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(179, 33);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "P.create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // putButton
            // 
            this.putButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.putButton.Location = new System.Drawing.Point(179, 108);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(75, 23);
            this.putButton.TabIndex = 7;
            this.putButton.Text = "P.put";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.Click += new System.EventHandler(this.putButton_Click);
            // 
            // outPut
            // 
            this.outPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPut.Location = new System.Drawing.Point(110, 211);
            this.outPut.Name = "outPut";
            this.outPut.ReadOnly = true;
            this.outPut.Size = new System.Drawing.Size(135, 20);
            this.outPut.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "P.got";
            // 
            // getAllButton
            // 
            this.getAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAllButton.Location = new System.Drawing.Point(15, 220);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(75, 26);
            this.getAllButton.TabIndex = 12;
            this.getAllButton.Text = "P.getall";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
            // 
            // getButton
            // 
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getButton.Location = new System.Drawing.Point(15, 188);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 26);
            this.getButton.TabIndex = 13;
            this.getButton.Text = "P.get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // inPut
            // 
            this.inPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPut.Location = new System.Drawing.Point(19, 111);
            this.inPut.Name = "inPut";
            this.inPut.Size = new System.Drawing.Size(154, 20);
            this.inPut.TabIndex = 14;
            this.inPut.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 258);
            this.Controls.Add(this.inPut);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.getAllButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.sizeInPut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "FIFO Puffer";
            ((System.ComponentModel.ISupportInitialize)(this.sizeInPut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inPut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sizeInPut;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.TextBox outPut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getAllButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.NumericUpDown inPut;
    }
}

