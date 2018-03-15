using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class GyTrans2 {
        public virtual int record_id { get; set; }
        public virtual GyTrans1 gy_trans1 { get; set; }
        public virtual byte revision_no { get; set; }
        public virtual string fabric_code { get; set; }
        public virtual string quality_code { get; set; }
        public virtual string o_color_code { get; set; }
        public virtual byte unit_code { get; set; }
        public virtual double quantity { get; set; }
        public virtual DateTime tentative_date { get; set; }
        public virtual double weaving_alloted { get; set; }
        public virtual double weaving_alloted_pcs { get; set; }
        public virtual double po_defined_qty { get; set; }
        public virtual double inquiry_quantity { get; set; }
        public virtual double weaving_quantity { get; set; }
    }
}
