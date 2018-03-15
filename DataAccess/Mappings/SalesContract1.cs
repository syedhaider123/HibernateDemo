using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class SalesContract1 {
        public SalesContract1() { }
        public virtual int ScNo { get; set; }
        public virtual IList<SalesContract2> SalesContract2s { get; set; }
        public virtual System.DateTime ScDate { get; set; }
        public virtual System.Nullable<byte> RevisionNo { get; set; }
        public virtual short CustCode { get; set; }
        public virtual short BuyerCode { get; set; }
        public virtual System.DateTime ValidUpto { get; set; }
        public virtual string Remarks { get; set; }
        public virtual short UserNo { get; set; }
        public virtual System.DateTime EntryDate { get; set; }
        public virtual string Approved { get; set; }
        public virtual System.Nullable<System.DateTime> ApprovedDate { get; set; }
        public virtual System.Nullable<short> ApprovedBy { get; set; }
        public virtual System.Nullable<System.DateTime> UnapprovedDate { get; set; }
        public virtual System.Nullable<short> UnapprovedBy { get; set; }
        public virtual string BatchUpdate { get; set; }
    }
}
