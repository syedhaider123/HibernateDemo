using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MShipmentPacking {
        public MShipmentPacking() {
			shipment_detail_os = new List<ShipmentDetailOs>();
			shipment_detail_os_hist = new List<ShipmentDetailOsHist>();
			//shipment_detail_proj = new List<ShipmentDetailProj>();
        }
        public virtual byte s_packing_code { get; set; }
        public virtual string s_packing_name { get; set; }
        public virtual short user_no { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual IList<ShipmentDetailOs> shipment_detail_os { get; set; }
        public virtual IList<ShipmentDetailOsHist> shipment_detail_os_hist { get; set; }
       // public virtual IList<ShipmentDetailProj> shipment_detail_proj { get; set; }
    }
}
