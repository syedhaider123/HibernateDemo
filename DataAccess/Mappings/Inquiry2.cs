using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class Inquiry2 {
        public Inquiry2() { }
        public virtual int RecordId { get; set; }
        public virtual Inquiry1 Inquiry1 { get; set; }
        public virtual MUnit Units { get; set; }
        public virtual byte RevisionNo { get; set; }
        public virtual string BItemNo { get; set; }
        public virtual short BItemRevisionNo { get; set; }
        public virtual string FabricCode { get; set; }
        public virtual string QualityCode { get; set; }
        public virtual string OColorCode { get; set; }
        public virtual decimal Quantity { get; set; }
        public virtual byte Unit { get; set; }
        public virtual System.Nullable<System.DateTime> ShipDate { get; set; }
        public virtual System.Nullable<System.DateTime> ExpShipDate { get; set; }
        public virtual System.Nullable<int> GyNo { get; set; }
        public virtual System.Nullable<int> GyTran2RecordId { get; set; }
        public virtual System.Nullable<int> Patternmasterid { get; set; }
    }
}
