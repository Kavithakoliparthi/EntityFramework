using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class EmpDemo
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities();
            var emp = new Employee()
            {
                EID = 2,
                EName = "srinu"

            };
            context.Employees.Add(emp);
            context.SaveChanges();
        }

    }
}
