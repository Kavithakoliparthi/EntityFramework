using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities();
            var emp = new Employee()
            {
                EID=1,
                EName="anusha"
               
            };
            context.Employees.Add(emp);
            context.SaveChanges();
        }
    }
}
