using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class MCustomer1 {
        public MCustomer1() { }
        public virtual short CustCode { get; set; }
        public virtual IList<Inquiry1> Inquiry1 { get; set; }
        public virtual string OldCustCode { get; set; }
        public virtual string CustName { get; set; }
        public virtual string Address { get; set; }
        public virtual short CityCode { get; set; }
        public virtual byte CountryCode { get; set; }
        public virtual string Zip { get; set; }
        public virtual string State { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Email { get; set; }
        public virtual string Uan { get; set; }
        public virtual string Url { get; set; }
        public virtual string GlCode { get; set; }
        public virtual string Remarks { get; set; }
        public virtual System.Nullable<byte> CustType { get; set; }
        public virtual short UserNo { get; set; }
        public virtual string Flag { get; set; }
        public virtual string BuyerType { get; set; }
        public virtual string QuotaApplicable { get; set; }
        public virtual System.DateTime EntryDate { get; set; }
        public virtual System.Nullable<short> ConsolidatorCode { get; set; }
        public virtual int CreditDays { get; set; }
        public virtual System.Nullable<short> BankCode { get; set; }
        public virtual string Beneficiary { get; set; }
        public virtual string PrePaid { get; set; }
        public virtual System.Nullable<byte> AgencyCode { get; set; }
        public virtual System.Nullable<int> PaymentTermsId { get; set; }
      
    }
}
