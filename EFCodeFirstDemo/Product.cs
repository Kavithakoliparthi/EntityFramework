using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    public class Product
    {
        //[ForeignKey("container")]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        [Required]
        public virtual Container container { get; set; }
    }
}








//in this we use foreign key (or) Required