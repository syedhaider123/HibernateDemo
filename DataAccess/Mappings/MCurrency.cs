using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MCurrency {
        public MCurrency() {
			order_sheet2 = new List<OrderSheet2>();
        }
        public virtual byte currency_code { get; set; }
        public virtual string currency_name { get; set; }
        public virtual short country_code { get; set; }
        public virtual string remarks { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual short user_no { get; set; }
        public virtual string flag { get; set; }
        public virtual string currency_miner { get; set; }
        public virtual string currency_word { get; set; }
        public virtual string currency_abbr { get; set; }
        public virtual IList<OrderSheet2> order_sheet2 { get; set; }
    }
}
