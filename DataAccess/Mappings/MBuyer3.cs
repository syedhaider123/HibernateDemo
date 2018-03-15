using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MBuyer3 {
        public virtual int record_id { get; set; }
        public virtual MBuyer1 m_buyer1 { get; set; }
        public virtual string bank_name { get; set; }
        public virtual string bank_address { get; set; }
    }
}
