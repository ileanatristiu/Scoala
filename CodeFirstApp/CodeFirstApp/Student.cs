﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
   public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedTimestamp { get; set; }

        public Course Course { get; set; }

    }
}
