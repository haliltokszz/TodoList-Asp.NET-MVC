using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoList.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool isDone { get; set; }

    }
}