using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class OrderSheet2 {
        public virtual int item_sno { get; set; }
        public virtual MCurrency m_currency { get; set; }
        public virtual int os_no { get; set; }
        public virtual byte revision_no { get; set; }
        public virtual string b_item_no { get; set; }
        public virtual short b_item_revision_no { get; set; }
        public virtual string fabric_code { get; set; }
        public virtual string quality_code { get; set; }
        public virtual string b_reference_no { get; set; }
        public virtual string o_color_code { get; set; }
        public virtual double order_quantity { get; set; }
        public virtual double increased { get; set; }
        public virtual double decreased { get; set; }
        public virtual double unit_price { get; set; }
        public virtual string package_code { get; set; }
        public virtual string packing_code { get; set; }
        public virtual string dyeing_work_order { get; set; }
        public virtual string stitching_work_order { get; set; }
        public virtual string b_item_old { get; set; }
        public virtual byte b_item_revision_old { get; set; }
        public virtual string old_b_item_no { get; set; }
        public virtual string old_b_reference_no { get; set; }
        public virtual double dwo_cancel_pcs { get; set; }
        public virtual double order_qty_pcs { get; set; }
        public virtual double stitched_qty_pcs { get; set; }
        public virtual int? pattern_master_id { get; set; }
    }
}
