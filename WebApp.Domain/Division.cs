﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Division
    {
        [Key]
        public string DivisionName { get; set; }
    }
}
