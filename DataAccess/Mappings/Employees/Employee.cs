using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class Employee {
        public Employee() { }
        public virtual int Empid { get; set; }
        public virtual IList<Employeeproject> Employeeprojects { get; set; }
        public virtual IList<Employeedetail> Employeedetails { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Post { get; set; }
    }
}
