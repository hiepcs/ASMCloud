﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Model
{
    public class BookCategory
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public bool Active { get; set; }
    }
}
