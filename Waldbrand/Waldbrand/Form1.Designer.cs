
namespace Waldbrand
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
            this.outPut = new System.Windows.Forms.TextBox();
            this.startSim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.breiteInPut = new System.Windows.Forms.NumericUpDown();
            this.tiefeInPut = new System.Windows.Forms.NumericUpDown();
            this.entzündungInPut = new System.Windows.Forms.NumericUpDown();
            this.wachstumInPut = new System.Windows.Forms.NumericUpDown();
            this.delayValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.breiteInPut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiefeInPut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entzündungInPut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wachstumInPut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // outPut
            // 
            this.outPut.Location = new System.Drawing.Point(12, 161);
            this.outPut.Multiline = true;
            this.outPut.Name = "outPut";
            this.outPut.ReadOnly = true;
            this.outPut.Size = new System.Drawing.Size(776, 277);
            this.outPut.TabIndex = 0;
            this.outPut.WordWrap = false;
            // 
            // startSim
            // 
            this.startSim.Location = new System.Drawing.Point(12, 90);
            this.startSim.Name = "startSim";
            this.startSim.Size = new System.Drawing.Size(776, 65);
            this.startSim.TabIndex = 5;
            this.startSim.Text = "Start";
            this.startSim.UseVisualStyleBackColor = true;
            this.startSim.Click += new System.EventHandler(this.startSim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Breite des Waldes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiefe des Waldes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wachstum in %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Entzündung in %";
            // 
            // breiteInPut
            // 
            this.breiteInPut.Location = new System.Drawing.Point(120, 23);
            this.breiteInPut.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.breiteInPut.Name = "breiteInPut";
            this.breiteInPut.Size = new System.Drawing.Size(120, 20);
            this.breiteInPut.TabIndex = 10;
            this.breiteInPut.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tiefeInPut
            // 
            this.tiefeInPut.Location = new System.Drawing.Point(120, 47);
            this.tiefeInPut.Name = "tiefeInPut";
            this.tiefeInPut.Size = new System.Drawing.Size(120, 20);
            this.tiefeInPut.TabIndex = 11;
            this.tiefeInPut.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // entzündungInPut
            // 
            this.entzündungInPut.Location = new System.Drawing.Point(123, 43);
            this.entzündungInPut.Name = "entzündungInPut";
            this.entzündungInPut.Size = new System.Drawing.Size(120, 20);
            this.entzündungInPut.TabIndex = 12;
            this.entzündungInPut.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.entzündungInPut.ValueChanged += new System.EventHandler(this.entzündungInPut_ValueChanged);
            // 
            // wachstumInPut
            // 
            this.wachstumInPut.Location = new System.Drawing.Point(123, 19);
            this.wachstumInPut.Name = "wachstumInPut";
            this.wachstumInPut.Size = new System.Drawing.Size(120, 20);
            this.wachstumInPut.TabIndex = 13;
            this.wachstumInPut.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.wachstumInPut.ValueChanged += new System.EventHandler(this.wachstumInPut_ValueChanged);
            // 
            // delayValue
            // 
            this.delayValue.Location = new System.Drawing.Point(330, 19);
            this.delayValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.delayValue.Name = "delayValue";
            this.delayValue.Size = new System.Drawing.Size(120, 20);
            this.delayValue.TabIndex = 15;
            this.delayValue.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Delay";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.breiteInPut);
            this.groupBox1.Controls.Add(this.tiefeInPut);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 72);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statische Variabeln";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wachstumInPut);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.delayValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.entzündungInPut);
            this.groupBox2.Location = new System.Drawing.Point(269, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 72);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veränderbare Variabeln";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startSim);
            this.Controls.Add(this.outPut);
            this.Name = "Form1";
            this.Text = "Waldbrand";
            ((System.ComponentModel.ISupportInitialize)(this.breiteInPut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiefeInPut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entzündungInPut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wachstumInPut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outPut;
        private System.Windows.Forms.Button startSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown breiteInPut;
        private System.Windows.Forms.NumericUpDown tiefeInPut;
        private System.Windows.Forms.NumericUpDown entzündungInPut;
        private System.Windows.Forms.NumericUpDown wachstumInPut;
        private System.Windows.Forms.NumericUpDown delayValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

