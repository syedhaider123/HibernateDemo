using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MShippingMarks {
        public MShippingMarks() {
			order_sheet1 = new List<OrderSheet1>();
        }
        public virtual int s_marks_code { get; set; }
        public virtual string s_marks_desc { get; set; }
        public virtual short user_no { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual IList<OrderSheet1> order_sheet1 { get; set; }
    }
}
