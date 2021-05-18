﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTEST.Models
{
    public class Hobby
    {
        [Key]
        public int id { get; set; }
        public string hobby { get; set; }
        public Candidat candidat { get; set; }

    }
}