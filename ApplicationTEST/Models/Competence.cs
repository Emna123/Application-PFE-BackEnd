﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationTEST.Models
{
    public class Competence
    {
        [Key]
        public int id { get; set; }
        public string titre { get; set; }
        public string niveau { get; set; }
        public Candidat candidat { get; set; }
        public Offre offre { get; set; }

    }
}