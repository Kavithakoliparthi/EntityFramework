using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    public class Container
    {

        public int ID { get; set; }
        public string ContainerName { get; set; }

        public virtual Product product {get;set;}   
    }
}
