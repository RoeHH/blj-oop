using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AufgabenPlaner
{
    enum TaskState
    {
        ToDo,
        wip,//Work in Progress
        done,
        archived
    }
    public partial class Form1 : Form
    {
        private TaskList _taskList = new TaskList();
        private bool creatingNew = false;
        private Task activeTask;

        public Form1()
        {
            InitializeComponent();
            sort_choser.Items.Add("ToDo");
            sort_choser.Items.Add("Wip");
            sort_choser.Items.Add("Done");
            sort_choser.Items.Add("Archived");
            sort_choser.Items.Add("All");
            ToDo.Checked = true;
        }
        
        private void updateDropdown()
        {
            task_choser.Items.Clear();
            foreach(Task task in _taskList.Tasks)
            {
                task_choser.Items.Add(task.Title);
            }
        }

        private void newTask_Click(object sender, EventArgs e)
        {
            task.BackColor = Color.Aqua;
            if(_taskList.Tasks.Count != 0)
            {
                taskTitle.Text = "";
                taskDescription.Text = "";
                dateTimeTask.Value = DateTime.Now;
            }
            editOrNew.Text = "Create Task";
            creatingNew = true;
        }

        private void editOrNew_Click(object sender, EventArgs e)
        {
            if (creatingNew)
            {
                if (taskTitle.Text == "")
                {
                    MessageBox.Show("Add a title to the Task");
                    return;
                }
                _taskList.AddTask(taskTitle.Text, taskDescription.Text, dateTimeTask.Value, getTaskState());
                activeTask = _taskList.Search(task_choser.Text);
                creatingNew = false;
                task.BackColor = Color.WhiteSmoke;
                editOrNew.Text = "Edit Task";
            }
            else
            {
                if (taskTitle.Text == "")
                {
                    MessageBox.Show("Add a title to the Task");
                    return;
                }
                Task task = activeTask;
                _taskList.RemoveTask(task);
                _taskList.AddTask(taskTitle.Text, taskDescription.Text, dateTimeTask.Value, getTaskState());
                activeTask = _taskList.Search(task_choser.Text);
            }
            updateDropdown();
        }

        

        private void sort_choser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sort_choser.SelectedItem == "All")
            {
                _taskList.syncTaskLists();
            }
            else
            {
                _taskList.Sort(getTaskStateFromDropdown());
            }
            updateDropdown();
        }

        private void task_choser_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeTask = _taskList.Search(task_choser.Text);
            updateForm(activeTask);
        }

        private void search_Click(object sender, EventArgs e)
        {
            activeTask = _taskList.Search(searchInPut.Text);
            updateForm(activeTask);
        }
        private void addComment_Click(object sender, EventArgs e)
        {
            activeTask = _taskList.Search(taskTitle.Text);
            _taskList.addComment(activeTask, newComment.Text);
            updateForm(activeTask);
        }

        private TaskState getTaskState()
        {
            if (ToDo.Checked)
                return TaskState.ToDo;
            if (done.Checked)
                return TaskState.done;
            if (archived.Checked)
                return TaskState.archived;
            if (wip.Checked)
                return TaskState.wip;
            return TaskState.ToDo;
        }

        private void SetTaskState(TaskState state)
        {
            if (state == TaskState.ToDo)
                ToDo.Checked = true;
            if (state == TaskState.done)
                done.Checked = true;
            if (state == TaskState.archived)
                archived.Checked = true;
            if (state == TaskState.wip)
                wip.Checked = true;
        }

        private TaskState getTaskStateFromDropdown()
        {
            if (sort_choser.SelectedItem == null)
                return TaskState.ToDo;
            if (sort_choser.SelectedItem == "ToDo")
                return TaskState.ToDo;
            if (sort_choser.SelectedItem == "Done")
                return TaskState.done;
            if (sort_choser.SelectedItem == "Archived")
                return TaskState.archived;
            if (sort_choser.SelectedItem == "Wip")
                return TaskState.wip;
            return TaskState.ToDo;
        }

        private void updateForm(Task task)
        {
            taskTitle.Text = task.Title;
            taskDescription.Text = task.Description;
            dateTimeTask.Value = task.DueDate;
            SetTaskState(task.State);
            coments.Text = "";
            foreach (string comment in task.comment)
            {
                coments.Text += $"{comment}\n\r";
            }
        }


    }
}
