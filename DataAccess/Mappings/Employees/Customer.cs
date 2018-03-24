using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess
{
    
    public class Customer {
        public Customer() { }
        public virtual int Customerid { get; set; }
        public virtual string Customername { get; set; }
    }
}
