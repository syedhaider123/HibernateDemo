using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MCustomer1 {
        public MCustomer1() {
			//m_customer5 = new List<MCustomer5>();
			//m_customer6 = new List<MCustomer6>();
        }
        public virtual short cust_code { get; set; }
        public virtual string old_cust_code { get; set; }
        public virtual string cust_name { get; set; }
        public virtual string address { get; set; }
        public virtual short city_code { get; set; }
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
        public virtual byte? cust_type { get; set; }
        public virtual short user_no { get; set; }
        public virtual string flag { get; set; }
        public virtual string buyer_type { get; set; }
        public virtual string quota_applicable { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual short? consolidator_code { get; set; }
        public virtual int credit_days { get; set; }
        public virtual short? bank_code { get; set; }
        public virtual string beneficiary { get; set; }
        public virtual string pre_paid { get; set; }
        public virtual byte? agency_code { get; set; }
        public virtual int? payment_terms_id { get; set; }
        //public virtual IList<MCustomer5> m_customer5 { get; set; }
        //public virtual IList<MCustomer6> m_customer6 { get; set; }
    }
}
