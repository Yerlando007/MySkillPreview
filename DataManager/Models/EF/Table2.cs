﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager.Models.EF
{
    public class Table2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Table1Id { get; set; }
    }
}