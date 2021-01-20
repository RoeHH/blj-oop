using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabenPlaner
{
    class Task
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime CreationTime { get; private set; }
        public TaskState State { get; private set; }

        public List<string> comment = new List<string>();
        public Task(string title, string description, DateTime dueDate, TaskState state)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            CreationTime = DateTime.Now;
            State = state;
        }
    }
}
