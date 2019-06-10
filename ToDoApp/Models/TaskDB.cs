using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class TaskDB
    {
        public static ToDo AddTask(ToDo task
                            , ToDoContext context)
        {
            context.ToDos.Add(task);
            context.SaveChanges();

            return task;

        }
        internal static List<ToDo>GetToDos(ToDoContext context)
        {
            return (from task in context.ToDos
                    select task).ToList();
        }
        public static ToDo GetTask (ToDoContext context, string title)
        {
            ToDo task = context
                            .ToDos
                            .Where(item => item.Title == title)
                            .Single();
            return task;
        }
    }
}
