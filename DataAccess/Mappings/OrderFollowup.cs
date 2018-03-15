using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class OrderFollowup {
        public virtual int record_id { get; set; }
        public virtual OrderSheet1 order_sheet1 { get; set; }
        public virtual DateTime s_detail_date { get; set; }
        public virtual string remarks { get; set; }
        public virtual short user_no { get; set; }
        public virtual DateTime entry_date { get; set; }
    }
}
