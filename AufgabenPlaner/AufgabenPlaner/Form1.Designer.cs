
namespace AufgabenPlaner
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
            this.task_choser = new System.Windows.Forms.ComboBox();
            this.sort_choser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskTitle = new System.Windows.Forms.TextBox();
            this.dateTimeTask = new System.Windows.Forms.DateTimePicker();
            this.task = new System.Windows.Forms.GroupBox();
            this.archived = new System.Windows.Forms.RadioButton();
            this.wip = new System.Windows.Forms.RadioButton();
            this.done = new System.Windows.Forms.RadioButton();
            this.ToDo = new System.Windows.Forms.RadioButton();
            this.taskDescription = new System.Windows.Forms.TextBox();
            this.editOrNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coments = new System.Windows.Forms.TextBox();
            this.addComment = new System.Windows.Forms.Button();
            this.newComment = new System.Windows.Forms.TextBox();
            this.searchInPut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newTask = new System.Windows.Forms.Button();
            this.task.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // task_choser
            // 
            this.task_choser.FormattingEnabled = true;
            this.task_choser.Location = new System.Drawing.Point(12, 22);
            this.task_choser.Name = "task_choser";
            this.task_choser.Size = new System.Drawing.Size(121, 21);
            this.task_choser.TabIndex = 0;
            this.task_choser.SelectedIndexChanged += new System.EventHandler(this.task_choser_SelectedIndexChanged);
            // 
            // sort_choser
            // 
            this.sort_choser.FormattingEnabled = true;
            this.sort_choser.Location = new System.Drawing.Point(139, 22);
            this.sort_choser.Name = "sort_choser";
            this.sort_choser.Size = new System.Drawing.Size(117, 21);
            this.sort_choser.TabIndex = 1;
            this.sort_choser.SelectedIndexChanged += new System.EventHandler(this.sort_choser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Task:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort:";
            // 
            // taskTitle
            // 
            this.taskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitle.Location = new System.Drawing.Point(6, 19);
            this.taskTitle.Name = "taskTitle";
            this.taskTitle.Size = new System.Drawing.Size(232, 29);
            this.taskTitle.TabIndex = 4;
            // 
            // dateTimeTask
            // 
            this.dateTimeTask.Location = new System.Drawing.Point(6, 123);
            this.dateTimeTask.Name = "dateTimeTask";
            this.dateTimeTask.Size = new System.Drawing.Size(232, 20);
            this.dateTimeTask.TabIndex = 7;
            // 
            // task
            // 
            this.task.BackColor = System.Drawing.SystemColors.Control;
            this.task.Controls.Add(this.archived);
            this.task.Controls.Add(this.wip);
            this.task.Controls.Add(this.done);
            this.task.Controls.Add(this.ToDo);
            this.task.Controls.Add(this.taskDescription);
            this.task.Controls.Add(this.editOrNew);
            this.task.Controls.Add(this.taskTitle);
            this.task.Controls.Add(this.dateTimeTask);
            this.task.Location = new System.Drawing.Point(12, 145);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(244, 222);
            this.task.TabIndex = 8;
            this.task.TabStop = false;
            this.task.Text = "Task";
            // 
            // archived
            // 
            this.archived.AutoSize = true;
            this.archived.Location = new System.Drawing.Point(126, 172);
            this.archived.Name = "archived";
            this.archived.Size = new System.Drawing.Size(67, 17);
            this.archived.TabIndex = 13;
            this.archived.TabStop = true;
            this.archived.Text = "Archived";
            this.archived.UseVisualStyleBackColor = true;
            // 
            // wip
            // 
            this.wip.AutoSize = true;
            this.wip.Location = new System.Drawing.Point(7, 172);
            this.wip.Name = "wip";
            this.wip.Size = new System.Drawing.Size(106, 17);
            this.wip.TabIndex = 12;
            this.wip.TabStop = true;
            this.wip.Text = "Work in Progress";
            this.wip.UseVisualStyleBackColor = true;
            // 
            // done
            // 
            this.done.AutoSize = true;
            this.done.Location = new System.Drawing.Point(127, 149);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(51, 17);
            this.done.TabIndex = 11;
            this.done.TabStop = true;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            // 
            // ToDo
            // 
            this.ToDo.AutoSize = true;
            this.ToDo.Location = new System.Drawing.Point(7, 149);
            this.ToDo.Name = "ToDo";
            this.ToDo.Size = new System.Drawing.Size(52, 17);
            this.ToDo.TabIndex = 10;
            this.ToDo.TabStop = true;
            this.ToDo.Text = "ToDo";
            this.ToDo.UseVisualStyleBackColor = true;
            // 
            // taskDescription
            // 
            this.taskDescription.Location = new System.Drawing.Point(6, 54);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskDescription.Size = new System.Drawing.Size(232, 63);
            this.taskDescription.TabIndex = 9;
            // 
            // editOrNew
            // 
            this.editOrNew.Location = new System.Drawing.Point(7, 192);
            this.editOrNew.Name = "editOrNew";
            this.editOrNew.Size = new System.Drawing.Size(231, 23);
            this.editOrNew.TabIndex = 8;
            this.editOrNew.Text = "Edit Task";
            this.editOrNew.UseVisualStyleBackColor = true;
            this.editOrNew.Click += new System.EventHandler(this.editOrNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coments);
            this.groupBox1.Controls.Add(this.addComment);
            this.groupBox1.Controls.Add(this.newComment);
            this.groupBox1.Location = new System.Drawing.Point(12, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 175);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comment";
            // 
            // coments
            // 
            this.coments.Location = new System.Drawing.Point(6, 19);
            this.coments.Multiline = true;
            this.coments.Name = "coments";
            this.coments.ReadOnly = true;
            this.coments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.coments.Size = new System.Drawing.Size(231, 105);
            this.coments.TabIndex = 2;
            // 
            // addComment
            // 
            this.addComment.Location = new System.Drawing.Point(127, 142);
            this.addComment.Name = "addComment";
            this.addComment.Size = new System.Drawing.Size(111, 23);
            this.addComment.TabIndex = 1;
            this.addComment.Text = "Add Comment";
            this.addComment.UseVisualStyleBackColor = true;
            this.addComment.Click += new System.EventHandler(this.addComment_Click);
            // 
            // newComment
            // 
            this.newComment.Location = new System.Drawing.Point(6, 142);
            this.newComment.Name = "newComment";
            this.newComment.Size = new System.Drawing.Size(115, 20);
            this.newComment.TabIndex = 0;
            // 
            // searchInPut
            // 
            this.searchInPut.Location = new System.Drawing.Point(0, 19);
            this.searchInPut.Name = "searchInPut";
            this.searchInPut.Size = new System.Drawing.Size(156, 20);
            this.searchInPut.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(166, 16);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 12;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchInPut);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Location = new System.Drawing.Point(12, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 50);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // newTask
            // 
            this.newTask.Location = new System.Drawing.Point(16, 105);
            this.newTask.Name = "newTask";
            this.newTask.Size = new System.Drawing.Size(237, 34);
            this.newTask.TabIndex = 14;
            this.newTask.Text = "New Task";
            this.newTask.UseVisualStyleBackColor = true;
            this.newTask.Click += new System.EventHandler(this.newTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 555);
            this.Controls.Add(this.newTask);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.task);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sort_choser);
            this.Controls.Add(this.task_choser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.task.ResumeLayout(false);
            this.task.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox task_choser;
        private System.Windows.Forms.ComboBox sort_choser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskTitle;
        private System.Windows.Forms.DateTimePicker dateTimeTask;
        private System.Windows.Forms.GroupBox task;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newComment;
        private System.Windows.Forms.Button editOrNew;
        private System.Windows.Forms.TextBox coments;
        private System.Windows.Forms.Button addComment;
        private System.Windows.Forms.TextBox taskDescription;
        private System.Windows.Forms.RadioButton archived;
        private System.Windows.Forms.RadioButton wip;
        private System.Windows.Forms.RadioButton done;
        private System.Windows.Forms.RadioButton ToDo;
        private System.Windows.Forms.TextBox searchInPut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button newTask;
    }
}

