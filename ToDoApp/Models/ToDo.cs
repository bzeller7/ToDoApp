﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class ToDo
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Category { get; set; }

        [Required]
        public string Priority { get; set; }

        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
    }
}
