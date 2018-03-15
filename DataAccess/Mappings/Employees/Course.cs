using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class Course {
        public Course() { }
        public virtual int Courseid { get; set; }
        public virtual string Coursename { get; set; }
        public virtual System.Nullable<int> Departmentid { get; set; }
    }
}
