using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class Student {
        public Student() { }
        public virtual int Studenid { get; set; }
        public virtual Department Department { get; set; }
        public virtual string Studentname { get; set; }
        public virtual System.Nullable<int> Courseid { get; set; }
    }
}
