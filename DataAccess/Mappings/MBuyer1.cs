using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MBuyer1 {
        public MBuyer1() {
			m_buyer2 = new List<MBuyer2>();
			m_buyer3 = new List<MBuyer3>();
			order_sheet1 = new List<OrderSheet1>();
			///projection1 = new List<Projection1>();
        }
        public virtual short buyer_code { get; set; }
        //public virtual MBuyerGrades m_buyer_grades { get; set; }
        public virtual string buyer_name { get; set; }
        public virtual string address { get; set; }
        public virtual short? city_code { get; set; }
        public virtual byte country_code { get; set; }
        public virtual string zip { get; set; }
        public virtual string state { get; set; }
        public virtual string phone { get; set; }
        public virtual string fax { get; set; }
        public virtual string email { get; set; }
        public virtual string uan { get; set; }
        public virtual string url { get; set; }
        public virtual string gl_code { get; set; }
        public virtual string remarks { get; set; }
        public virtual short user_no { get; set; }
        public virtual string flag { get; set; }
        public virtual string buyer_type { get; set; }
        public virtual string print_cust_po { get; set; }
        public virtual string quota_applicable { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual string container_seal_required { get; set; }
        public virtual string partial_ship_allow { get; set; }
        public virtual int? agent_serial { get; set; }
        public virtual IList<MBuyer2> m_buyer2 { get; set; }
        public virtual IList<MBuyer3> m_buyer3 { get; set; }
        public virtual IList<OrderSheet1> order_sheet1 { get; set; }
        //public virtual IList<Projection1> projection1 { get; set; }
    }
}
