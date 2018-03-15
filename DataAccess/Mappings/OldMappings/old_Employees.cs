using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Employees
    {
        private int empID;
        private string name ;
        private string surName ;

        public Employees()
        {}

        public virtual int EmpID
        {
          get { return empID; }

          set { empID = value; }
        }

        public virtual string Name { get { return name; } set { name = value; } }
        public virtual string SurName { get { return surName; } set {surName = value; } }
    }
}
