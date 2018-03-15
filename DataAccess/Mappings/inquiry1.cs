using System; 
using System.Collections.Generic; 
using System.Text; 
using System;
using Newtonsoft.Json;

namespace DataAccess {
    
    public class Inquiry1 {
        public Inquiry1() { }

        public virtual int InquiryNo { get; set; }
        public virtual byte RevisionNo { get; set; }
        public virtual System.DateTime InquiryDate { get; set; }
        public virtual System.Nullable<System.DateTime> ValidityDate { get; set; }
        public virtual short CustCode { get; set; }
        public virtual string CrmName { get; set; }
        

        public virtual string Post { get; set; }
        public virtual System.Nullable<System.DateTime> PostDate { get; set; }
        public virtual string Remarks { get; set; }
        public virtual string WeaveRemarks { get; set; }
        public virtual string ProcessRemarks { get; set; }
        public virtual string StitchRemarks { get; set; }
        public virtual string PrintRemarks { get; set; }
        public virtual System.Nullable<short> AUserCode1 { get; set; }
        public virtual System.Nullable<short> AUserCode2 { get; set; }
        public virtual System.Nullable<short> AUserCode3 { get; set; }
        public virtual System.Nullable<short> AUserCode4 { get; set; }
        public virtual string WeavePost { get; set; }
        public virtual string ProcessPost { get; set; }
        public virtual string StitchPost { get; set; }
        public virtual string PrintPost { get; set; }
        public virtual System.Nullable<System.DateTime> WeavePostDate { get; set; }
        public virtual System.Nullable<System.DateTime> ProcessPostDate { get; set; }
        public virtual System.Nullable<System.DateTime> StitchPostDate { get; set; }
        public virtual System.Nullable<System.DateTime> PrintPostDate { get; set; }
        public virtual string Approved { get; set; }
        public virtual System.Nullable<System.DateTime> ApproveDate { get; set; }
        public virtual System.Nullable<short> CanceledBy { get; set; }
        public virtual string Canceled { get; set; }
        public virtual System.Nullable<System.DateTime> CancelDate { get; set; }
        public virtual System.Nullable<System.DateTime> EntryDate { get; set; }
        public virtual short UserNo { get; set; }
        public virtual string SafetyOrder { get; set; }
        public virtual System.Nullable<byte> LocationCode { get; set; }
        public virtual System.Nullable<byte> OldLocationCodec31 { get; set; }
        public virtual System.Nullable<byte> LeadTime { get; set; }
        public virtual System.Nullable<byte> CtRevision { get; set; }
        [JsonIgnore]
        public virtual MCustomer1 CustomerInfo { get; set; }
        [JsonIgnore]
        public virtual MProductDesc ProductDesciption { get; set; }
        [JsonIgnore]
        public virtual IList<Inquiry2> Inquiry2s { get; set; }
        //[JsonIgnore]
        //public virtual IList<MProductDesc> ProductDesciption { get; set; }
    }
}
