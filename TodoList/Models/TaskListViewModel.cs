using System.Collections.Generic;
using TodoList.Entities;

namespace TodoList.Models
{
    public class TaskListViewModel
    {
        public List<Task> WillBeDoneTasks { get; set; } = new List<Task>();
        public List<Task> DoneTasks { get; set; } = new List<Task>();

        public void AddTask(Task task, bool isDone)
        {
            if (isDone)
            {
                DoneTasks.Add(task);
            }
            else
            {
                WillBeDoneTasks.Add(task);
            }
        }
    }
}