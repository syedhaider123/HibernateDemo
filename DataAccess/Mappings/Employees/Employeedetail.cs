using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class Employeedetail {
        public Employeedetail() { }
        public virtual int Empdetailsid { get; set; }
        public virtual System.Nullable<int> Empid { get; set; }
        public virtual System.Nullable<int> Accountnumber { get; set; }
        public virtual Employee Employees { get; set; }
        public virtual string Accountname { get; set; }
    }
}
