using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Employees
    {
        private int empId;
        private string name ;
        private string surName ;

      
        public virtual int EmpID
        {
          get { return empId; }

          set { empId = value; }
        }

        public virtual string Name { get { return name; } set { name = value; } }
        public virtual string SurName { get { return surName; } set {surName = value; } }
    }
}
