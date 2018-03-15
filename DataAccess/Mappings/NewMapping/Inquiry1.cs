using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class Inquiry1 {
        public Inquiry1() {
			inquiry2 = new List<Inquiry2>();
			inquiry3 = new List<Inquiry3>();
        }
        public virtual int inquiry_no { get; set; }
        public virtual byte revision_no { get; set; }
        public virtual DateTime inquiry_date { get; set; }
        public virtual DateTime? validity_date { get; set; }
        public virtual short cust_code { get; set; }
        public virtual string crm_name { get; set; }
        public virtual string post { get; set; }
        public virtual DateTime? post_date { get; set; }
        public virtual string remarks { get; set; }
        public virtual string weave_remarks { get; set; }
        public virtual string process_remarks { get; set; }
        public virtual string stitch_remarks { get; set; }
        public virtual string print_remarks { get; set; }
        public virtual short? a_user_code1 { get; set; }
        public virtual short? a_user_code2 { get; set; }
        public virtual short? a_user_code3 { get; set; }
        public virtual short? a_user_code4 { get; set; }
        public virtual string weave_post { get; set; }
        public virtual string process_post { get; set; }
        public virtual string stitch_post { get; set; }
        public virtual string print_post { get; set; }
        public virtual DateTime? weave_post_date { get; set; }
        public virtual DateTime? process_post_date { get; set; }
        public virtual DateTime? stitch_post_date { get; set; }
        public virtual DateTime? print_post_date { get; set; }
        public virtual string approved { get; set; }
        public virtual DateTime? approve_date { get; set; }
        public virtual short? canceled_by { get; set; }
        public virtual string canceled { get; set; }
        public virtual DateTime? cancel_date { get; set; }
        public virtual DateTime? entry_date { get; set; }
        public virtual short user_no { get; set; }
        public virtual string safety_order { get; set; }
        public virtual byte? location_code { get; set; }
        public virtual byte? old_location_codeC31 { get; set; }
        public virtual byte? lead_time { get; set; }
        public virtual byte? ct_revision { get; set; }
        public virtual IList<Inquiry2> inquiry2 { get; set; }
        public virtual IList<Inquiry3> inquiry3 { get; set; }
    }
}
