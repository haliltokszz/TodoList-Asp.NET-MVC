using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.Entities;
using TodoList.Models;

namespace TodoList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Task> tasks = new List<Task>
            {
                new Task{Id=1, TaskName="Make a Sandwich", isDone=false},
                new Task{Id=2, TaskName="Make a Bil359 Homework", isDone=true},
                new Task{Id=3, TaskName="Write a Code", isDone=false},
                new Task{Id=3, TaskName="Read a book", isDone=true},
                new Task{Id=3, TaskName="Make breakfast", isDone=true},
                new Task{Id=3, TaskName="Tidy the room", isDone=false}
            };

            Task task1 = new Task { Id = 1, TaskName = "Make a Sandwich", isDone = false };

            TaskListViewModel model = new TaskListViewModel();
            foreach(var task in tasks)
            {
                model.AddTask(task, task.isDone);
            }
            return View(model);
        }
    }
}