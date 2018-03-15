using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class MUnit {
        public MUnit() { }
        public virtual byte UnitCode { get; set; }
        public virtual string UnitName { get; set; }
        public virtual string ShortName { get; set; }
        public virtual string OrderInquiry { get; set; }
        public virtual string Conversion1 { get; set; }
        public virtual string Conversion2 { get; set; }
        public virtual string Operate { get; set; }
        public virtual string Alternate { get; set; }
        public virtual short UserNo { get; set; }
        public virtual System.DateTime EntryDate { get; set; }
    }
}
