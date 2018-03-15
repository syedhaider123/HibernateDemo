using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDTO
    {
        public OrderDTO()
        {

        }

 
        [JsonIgnore]
        public   string port_code { get; set; }
        [JsonIgnore]
        public   string port_name { get; set; }
        [JsonIgnore]
        public short buyer_code { get; set; }
        [JsonIgnore]
        public int InquiryNo { get; set; }
        
        public double Quantity { get; set  ; }
        [JsonIgnore]
        public string QualityCode { get; set; }
        [JsonIgnore]
        public string ColorCode { get; set; }
        [JsonIgnore]
        public string Remarks { get; set; }
        
        public string PoNo { get; set; }
         
        public string GyNo { get; set; }
        [JsonIgnore]
        public string PatternCode { get; set; }
        [JsonIgnore]
        public string StyleCode { get; set; }
         
        public string Post { get; set; }
        [JsonIgnore]
        public short CustCode { get; set; }
        [JsonIgnore]
        public byte Unit { get; set; }
        
        public string CustomerName { get; set; }
        [JsonIgnore]
        public string BuyerName { get; set; }

        public string ApproveDate { get; set; }

        [JsonIgnore]
        public DateTime InquireDate { get; set; }
        [JsonIgnore]
        public DateTime LeadTime { get; set; }
        [JsonIgnore]
        public DateTime ShipDate { get; set; }
       
        public String OrderDate { get; set; }
        [JsonIgnore]
        public int Count { get; set; }
        [JsonIgnore]
        public String Inquired
        {
            get {

                TimeSpan inquireDateTimeSpan = DateTime.Today.Date - this.InquireDate;
                 return inquireDateTimeSpan.TotalDays.ToString() + "Days Ago" ;

            }  set {; }
        }
         
        public string ProductDesc { get; set; }
        [JsonIgnore]
        public string ResponseCode { get; set; }

        
        public  int os_no { get; set; }
        [JsonIgnore]
        public   DateTime? os_date { get; set; }
        [JsonIgnore]
        public   byte OrderSheet1revision_no { get; set; }
        [JsonIgnore]
        public   byte OrderSheet2revision_no { get; set; }
        [JsonIgnore]
        public   DateTime? revision_date { get; set; }
        [JsonIgnore]
        public   string po_no { get; set; }
        [JsonIgnore]
        public   DateTime? po_date { get; set; }
        [JsonIgnore]
        public   string po_no_buyer { get; set; }
        [JsonIgnore]
        public   DateTime? po_date_buyer { get; set; }
        [JsonIgnore]
        public   string quota_code { get; set; }
        [JsonIgnore]
        public   short cust_code { get; set; }
        [JsonIgnore]
        public   string factory_inquiry { get; set; }
        [JsonIgnore]
        public   int gy_no { get; set; }
        [JsonIgnore]
        public   string remarks { get; set; }
        [JsonIgnore]
        public   string spec_sheet { get; set; }
        [JsonIgnore]
        public   string other_document { get; set; }
        [JsonIgnore]
        public   string cancelled { get; set; }
        [JsonIgnore]
        public   string printed { get; set; }
        [JsonIgnore]
        public   string post { get; set; }
        [JsonIgnore]
        public   string closed { get; set; }
        [JsonIgnore]
        public   string partial_shipment { get; set; }
        [JsonIgnore]
        public   string completed { get; set; }
        [JsonIgnore]
        public   string po_assigned { get; set; }
        [JsonIgnore]
        public   short user_no { get; set; }
        [JsonIgnore]
        public   DateTime? post_date { get; set; }
        [JsonIgnore]
        public   short? posted_by { get; set; }
        [JsonIgnore]
        public   DateTime entry_date { get; set; }
        [JsonIgnore]
        public   int lot_no { get; set; }
        [JsonIgnore]
        public   string yarn_p_request { get; set; }
        [JsonIgnore]
        public   short? closed_by { get; set; }
        [JsonIgnore]
        public   DateTime? closed_on { get; set; }
        [JsonIgnore]
        public   string transfer_check { get; set; }
        [JsonIgnore]
        public   string po_no_old { get; set; }
        [JsonIgnore]
        public   DateTime? po_date_old { get; set; }
        [JsonIgnore]
        public   short? edited_by { get; set; }
        [JsonIgnore]
        public   DateTime? edited_date { get; set; }
        [JsonIgnore]
        public   int so_no { get; set; }
        [JsonIgnore]
        public   int? sc_no { get; set; }
        [JsonIgnore]
        public   int? sc_rev { get; set; }
        [JsonIgnore]
        public   short? cancelled_by { get; set; }
        [JsonIgnore]
        public   DateTime? cancelled_on { get; set; }
        [JsonIgnore]
        public   string auto_update { get; set; }
        [JsonIgnore]
        public   string Oracle_Update { get; set; }
        [JsonIgnore]
        public   string Sales_Order { get; set; }
        [JsonIgnore]
        public   string Open_Order { get; set; }
        [JsonIgnore]
        public   byte? Location_code { get; set; }
        [JsonIgnore]
        public   int? Edi_ref { get; set; }
        [JsonIgnore]
        public   string Label_print { get; set; }
        [JsonIgnore]

        public   int item_sno { get; set; }
        [JsonIgnore]
        public   MCurrency m_currency { get; set; }
        [JsonIgnore]
        public   string b_item_no { get; set; }
        [JsonIgnore]
        public   short b_item_revision_no { get; set; }
        [JsonIgnore]
        public   string fabric_code { get; set; }
         
        public   string quality_code { get; set; }
        [JsonIgnore]
        public   string b_reference_no { get; set; }
        [JsonIgnore]
        public   string o_color_code { get; set; }
        [JsonIgnore]
        public   double order_quantity { get; set; }
        [JsonIgnore]
        public   double increased { get; set; }
        [JsonIgnore]
        public   double decreased { get; set; }
        [JsonIgnore]
        public   double unit_price { get; set; }
        [JsonIgnore]
        public   string package_code { get; set; }
        [JsonIgnore]
        public   string packing_code { get; set; }
        [JsonIgnore]
        public   string dyeing_work_order { get; set; }
        [JsonIgnore]
        public   string stitching_work_order { get; set; }
        [JsonIgnore]
        public   string b_item_old { get; set; }
        [JsonIgnore]
        public   byte b_item_revision_old { get; set; }
        [JsonIgnore]
        public   string old_b_item_no { get; set; }
        [JsonIgnore]
        public   string old_b_reference_no { get; set; }
        [JsonIgnore]
        public   double dwo_cancel_pcs { get; set; }
         
        public   double order_qty_pcs { get; set; }
        [JsonIgnore]
        public   double stitched_qty_pcs { get; set; }
        [JsonIgnore]
        public   int? pattern_master_id { get; set; }
        [JsonIgnore]
        public   int record_id { get; set; }
        [JsonIgnore]
        public   OrderSheet1 order_sheet1 { get; set; }
        [JsonIgnore]
        public   MPorts m_ports { get; set; }
        [JsonIgnore]
        public   MShipmentPacking m_shipment_packing { get; set; }
        [JsonIgnore]
        public   DateTime shipment_date { get; set; }
       
        public   string shipment_date_po { get; set; }
        [JsonIgnore]
        public   DateTime? window_date { get; set; }
        [JsonIgnore]
        public   double shipment_qty { get; set; }
        [JsonIgnore]
        public   double weaving_alloted { get; set; }
        [JsonIgnore]
        public   double po_defined_qty { get; set; }
        [JsonIgnore]
        public   DateTime? weaving_date { get; set; }
        [JsonIgnore]
        public   DateTime? processing_date { get; set; }
        [JsonIgnore]
        public   DateTime? trims_acc_date { get; set; }
        [JsonIgnore]
        public   DateTime? stitching_date { get; set; }
        [JsonIgnore]
        public   DateTime? sch_shipment_date { get; set; }
        [JsonIgnore]
        public   DateTime? dyes_chem_date { get; set; }
        [JsonIgnore]
        public   DateTime? yarn_arrange_date { get; set; }
        [JsonIgnore]
        public   byte sch_revision_no { get; set; }
        [JsonIgnore]
        public   DateTime? sch_revision_date { get; set; }


    }



}
