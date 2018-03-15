using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MPorts {
        public MPorts() {
			shipment_detail_os = new List<ShipmentDetailOs>();
			shipment_detail_os_hist = new List<ShipmentDetailOsHist>();
			//shipment_detail_proj = new List<ShipmentDetailProj>();
        }
        public virtual string port_code { get; set; }
        public virtual short record_id { get; set; }
        public virtual string port_name { get; set; }
        public virtual short country_code { get; set; }
        public virtual short user_no { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual string rnd_claimable { get; set; }
        public virtual short? notify_id1 { get; set; }
        public virtual short? notify_id2 { get; set; }
        public virtual IList<ShipmentDetailOs> shipment_detail_os { get; set; }
        public virtual IList<ShipmentDetailOsHist> shipment_detail_os_hist { get; set; }
        //public virtual IList<ShipmentDetailProj> shipment_detail_proj { get; set; }
    }
}
