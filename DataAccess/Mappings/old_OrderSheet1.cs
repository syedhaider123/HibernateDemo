using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataAccess {
    
    public partial class old_OrderSheet1 {
        public OrderSheet1() {
			//order_followup = new List<OrderFollowup>();
			//order_status = new List<OrderStatus>();
			//os_scheduling = new List<OsScheduling>();
			//shipment_detail_os = new List<ShipmentDetailOs>();
			//shipment_detail_os_hist = new List<ShipmentDetailOsHist>();
        }
        public virtual int os_no { get; set; }
        [JsonIgnore]
        public virtual MBuyer1 m_buyer1 { get; set; }
        [JsonIgnore]
        public virtual MShippingMarks m_shipping_marks { get; set; }
        public virtual DateTime? os_date { get; set; }
        public virtual byte revision_no { get; set; }
        public virtual DateTime? revision_date { get; set; }
        public virtual string po_no { get; set; }
        public virtual DateTime? po_date { get; set; }
        public virtual string po_no_buyer { get; set; }
        public virtual DateTime? po_date_buyer { get; set; }
        public virtual string quota_code { get; set; }
        public virtual short cust_code { get; set; }
        public virtual string factory_inquiry { get; set; }
        public virtual int gy_no { get; set; }
        public virtual string remarks { get; set; }
        public virtual string spec_sheet { get; set; }
        public virtual string other_document { get; set; }
        public virtual string cancelled { get; set; }
        public virtual string printed { get; set; }
        public virtual string post { get; set; }
        public virtual string closed { get; set; }
        public virtual string partial_shipment { get; set; }
        public virtual string completed { get; set; }
        public virtual string po_assigned { get; set; }
        public virtual short user_no { get; set; }
        public virtual DateTime? post_date { get; set; }
        public virtual short? posted_by { get; set; }
        public virtual DateTime entry_date { get; set; }
        public virtual int lot_no { get; set; }
        public virtual string yarn_p_request { get; set; }
        public virtual short? closed_by { get; set; }
        public virtual DateTime? closed_on { get; set; }
        public virtual string transfer_check { get; set; }
        public virtual string po_no_old { get; set; }
        public virtual DateTime? po_date_old { get; set; }
        public virtual short? edited_by { get; set; }
        public virtual DateTime? edited_date { get; set; }
        public virtual int so_no { get; set; }
        public virtual int? sc_no { get; set; }
        public virtual int? sc_rev { get; set; }
        public virtual short? cancelled_by { get; set; }
        public virtual DateTime? cancelled_on { get; set; }
        public virtual string auto_update { get; set; }
        public virtual string Oracle_Update { get; set; }
        public virtual string Sales_Order { get; set; }
        public virtual string Open_Order { get; set; }
        public virtual byte? Location_code { get; set; }
        public virtual int? Edi_ref { get; set; }
        public virtual string Label_print { get; set; }
        [JsonIgnore]
        public virtual IList<OrderFollowup> order_followup { get; set; }
        [JsonIgnore]
        public virtual IList<OrderStatus> order_status { get; set; }
        [JsonIgnore]
        public virtual IList<OsScheduling> os_scheduling { get; set; }
        [JsonIgnore]
        public virtual IList<ShipmentDetailOs> shipment_detail_os { get; set; }
        [JsonIgnore]
        public virtual IList<ShipmentDetailOsHist> shipment_detail_os_hist { get; set; }
    }
}
