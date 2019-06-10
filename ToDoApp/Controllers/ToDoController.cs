using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoContext context;

        public ToDoController(ToDoContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<ToDo> toDos = TaskDB.GetToDos(context);
            return View(toDos);
        }

        public IActionResult CreateTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTask(ToDo task)
        {
            if (ModelState.IsValid)
            {
                TaskDB.AddTask(task, context);

            }
            return View(task);
        }
        [HttpGet]
        public IActionResult EditTask(int id)
        {
            ToDo item = TaskDB.GetTask(context, id);
            return View(item);
        }

    }
}