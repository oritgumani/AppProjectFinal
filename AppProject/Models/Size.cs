﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppProject.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public ICollection<ConectTable> Detail { get; set; }
    }
}
