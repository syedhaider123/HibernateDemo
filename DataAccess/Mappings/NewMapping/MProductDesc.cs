using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MProductDesc {
        public virtual int serial_no { get; set; }
        public virtual string buyer_ref_abbr { get; set; }
        public virtual string product_desc { get; set; }
        public virtual short cust_code { get; set; }
        public virtual short user_no { get; set; }
        public virtual DateTime entry_date { get; set; }
    }
}
