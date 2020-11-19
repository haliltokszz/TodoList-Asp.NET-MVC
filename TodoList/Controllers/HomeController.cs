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
                new Task{TaskName="Make a Sandwich", isDone=false},
                new Task{TaskName="Make a Bil359 Homework", isDone=true},
                new Task{TaskName="Write a Code", isDone=false},
                new Task{TaskName="Read a book", isDone=true},
                new Task{TaskName="Make breakfast", isDone=true},
                new Task{TaskName="Tidy the room", isDone=false}
            };

            TaskListViewModel model = new TaskListViewModel();
            foreach(var task in tasks)
            {
                model.AddTask(task, task.isDone);
            }
            return View(model);
        }
    }
}