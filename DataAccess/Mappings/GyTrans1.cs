using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataAccess {
    
    public partial class GyTrans1 {
        public GyTrans1() {
			gy_scheduling = new List<GyScheduling>();
			gy_trans2 = new List<GyTrans2>();
        }
        public virtual int gy_no { get; set; }
        public virtual DateTime gy_date { get; set; }
        public virtual byte revision_no { get; set; }
        public virtual DateTime? revision_date { get; set; }
        public virtual string po_no { get; set; }
        public virtual int? factory_inquiry { get; set; }
        public virtual short cust_code { get; set; }
        public virtual string remarks { get; set; }
        public virtual string cancelled { get; set; }
        public virtual string po_assigned { get; set; }
        public virtual short user_no { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual string post { get; set; }
        public virtual DateTime? posted_date { get; set; }
        public virtual short? posted_by { get; set; }
        public virtual short? cancelled_by { get; set; }
        public virtual DateTime? cancelled_date { get; set; }
        [JsonIgnore]
        public virtual IList<GyScheduling> gy_scheduling { get; set; }
        [JsonIgnore]
        public virtual IList<GyTrans2> gy_trans2 { get; set; }
    }
}
