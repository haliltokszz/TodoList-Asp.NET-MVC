using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoList.Entities
{
    public class Task
    {
        private static int id = 0;
        public int Id { get; }
        public string TaskName { get; set; }
        public bool isDone { get; set; }

        public Task()
        {
            this.Id = id++;
        }
    }
}