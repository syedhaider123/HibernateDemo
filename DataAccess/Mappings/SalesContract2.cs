using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class SalesContract2 {
        public SalesContract2() { }
        public virtual int SerialNo { get; set; }
        public virtual SalesContract1 SalesContract1 { get; set; }
        public virtual IList<SalesContract3> SalesContract3s { get; set; }
       // public virtual IList<SalesContract4> SalesContract4s { get; set; }
        public virtual System.Nullable<byte> RevisionNo { get; set; }
        public virtual string BItemNo { get; set; }
        public virtual short UnitCode { get; set; }
        public virtual byte CurrencyCode { get; set; }
        public virtual string RatePerPackage { get; set; }
        public virtual string Post { get; set; }
        public virtual System.Nullable<short> CommodityCode { get; set; }
    }
}
