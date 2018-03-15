using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class Employeeproject {
        public Employeeproject() { }
        public virtual int Empprojectid { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual string Projectname { get; set; }
    }
}
