using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeCF.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirsName + " " + LastName; }
        }
    }
}
