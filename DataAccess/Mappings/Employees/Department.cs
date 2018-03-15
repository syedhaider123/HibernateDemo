using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class Department {
        public Department() { }
        public virtual int Departmentid { get; set; }
        public virtual IList<Student> Students { get; set; }
        public virtual string Departmentname { get; set; }
    }
}
