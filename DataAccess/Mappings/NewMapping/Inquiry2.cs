using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class Inquiry2 {
        public Inquiry2() {
			inquiry_printing = new List<InquiryPrinting>();
			inquiry_processing = new List<InquiryProcessing>();
			inquiry_stitching = new List<InquiryStitching>();
			inquiry_weaving = new List<InquiryWeaving>();
			inquiry_yarn = new List<InquiryYarn>();
        }
        public virtual int record_id { get; set; }
        public virtual Inquiry1 inquiry1 { get; set; }
        public virtual byte revision_no { get; set; }
        public virtual string b_item_no { get; set; }
        public virtual short b_item_revision_no { get; set; }
        public virtual string fabric_code { get; set; }
        public virtual string quality_code { get; set; }
        public virtual string o_color_code { get; set; }
        public virtual double quantity { get; set; }
        public virtual byte unit { get; set; }
        public virtual DateTime? ship_date { get; set; }
        public virtual DateTime? exp_ship_date { get; set; }
        public virtual int? gy_no { get; set; }
        public virtual int? gy_tran2_record_id { get; set; }
        public virtual int? patternMasterId { get; set; }
        public virtual IList<InquiryPrinting> inquiry_printing { get; set; }
        public virtual IList<InquiryProcessing> inquiry_processing { get; set; }
        public virtual IList<InquiryStitching> inquiry_stitching { get; set; }
        public virtual IList<InquiryWeaving> inquiry_weaving { get; set; }
        public virtual IList<InquiryYarn> inquiry_yarn { get; set; }
    }
}
