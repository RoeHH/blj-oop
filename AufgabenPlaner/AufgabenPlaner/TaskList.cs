using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenPlaner
{
    class TaskList 
    {
        private List<Task> _tasks = new List<Task>();

        public List<Task> Tasks { get; private set; } = new List<Task>();

        public int Count { get; private set; }

        public TaskList()
        {
            
        }

        public void AddTask(string title, string description, DateTime dueDate, TaskState state)
        {
            _tasks.Add(new Task(title, description, dueDate, state));
            syncTaskLists();
        }

        public void RemoveTask(Task task)
        {
            _tasks.Remove(task);
            syncTaskLists();
        }

        public Task Search(string search)
        {
            foreach (Task task in _tasks)
            {
                if(task.Title == search)
                {
                    return task;
                }
            }
            return null;
        }

        public void Sort(TaskState state)
        {
            Tasks.Clear();
            foreach (Task task in _tasks)
            {
                if(task.State == state)
                {
                    Tasks.Add(task);
                }
            }
        }

        public void syncTaskLists()
        {
            Tasks.Clear();
            foreach (Task task in _tasks)
            {
                Tasks.Add(task);
            }
        }

        public void addComment(Task task,string newComment)
        {
            task.comment.Add(newComment);
            syncTaskLists();
        }
    }
}
