using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class MProductDesc {
        public MProductDesc() { }
        public virtual int SerialNo { get; set; }
        public virtual IList<Inquiry1> Inquiry1 { get; set; }
        public virtual string BuyerRefAbbr { get; set; }
        public virtual string ProductDesc { get; set; }
        public virtual short CustCode { get; set; }
        public virtual short UserNo { get; set; }
        public virtual System.DateTime EntryDate { get; set; }
    }
}
