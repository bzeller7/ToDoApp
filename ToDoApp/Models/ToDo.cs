using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class ToDo
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Priority { get; set; }

        public DateTime DueDate { get; set; }
    }
}
