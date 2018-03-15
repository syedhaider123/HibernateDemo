using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class SalesContract3 {
        public SalesContract3() { }
        public virtual int RecordId { get; set; }
        public virtual SalesContract2 SalesContract2 { get; set; }
        public virtual int ScNo { get; set; }
        public virtual System.Nullable<byte> RevisionNo { get; set; }
        public virtual string QualityCode { get; set; }
        public virtual string OColorCode { get; set; }
        public virtual System.Nullable<int> Patternmasterid { get; set; }
        public virtual string Quantity { get; set; }
        public virtual string UnitPrice { get; set; }
    }
}
