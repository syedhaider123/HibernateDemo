using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class ShipmentDetailOs {
        public virtual int record_id { get; set; }
        public virtual OrderSheet1 order_sheet1 { get; set; }
        //public virtual MPorts m_ports { get; set; }
        //public virtual MShipmentPacking m_shipment_packing { get; set; }
        public virtual byte revision_no { get; set; }
        public virtual string b_item_no { get; set; }
        public virtual DateTime shipment_date { get; set; }
        public virtual DateTime? shipment_date_po { get; set; }
        public virtual DateTime? window_date { get; set; }
        public virtual double shipment_qty { get; set; }
        public virtual double weaving_alloted { get; set; }
        public virtual double po_defined_qty { get; set; }
        public virtual DateTime? weaving_date { get; set; }
        public virtual DateTime? processing_date { get; set; }
        public virtual DateTime? trims_acc_date { get; set; }
        public virtual DateTime? stitching_date { get; set; }
        public virtual DateTime? sch_shipment_date { get; set; }
        public virtual DateTime? dyes_chem_date { get; set; }
        public virtual DateTime? yarn_arrange_date { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual short user_no { get; set; }
        public virtual byte sch_revision_no { get; set; }
        public virtual DateTime? sch_revision_date { get; set; }
    }
}
