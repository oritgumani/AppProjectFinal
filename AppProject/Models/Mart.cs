using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppProject.Models
{
    public class Mart
    {
        [Key]
        public int MartId { get; set; }
        public ICollection<ConectTable> Detail { get; set; }
        //otomatic update the data when we update the source data
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
