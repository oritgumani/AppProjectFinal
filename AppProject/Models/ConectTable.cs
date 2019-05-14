using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppProject.Models
{
    public class ConectTable
    {
        [Key]
        public int DetailesId { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int SizeId { get; set; }
        public Size Sizes { get; set; }
        public int ColorId { get; set; }
        public Color Colors { get; set; }
        public int MartId { get; set; }
        public Mart Marts { get; set; }

    }
}
