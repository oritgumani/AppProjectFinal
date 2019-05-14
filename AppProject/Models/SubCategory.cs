using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppProject.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string SubName { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
