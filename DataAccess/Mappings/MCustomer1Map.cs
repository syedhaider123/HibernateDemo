using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class MCustomer1Map : ClassMap<MCustomer1> {
        
        public MCustomer1Map() {
			Table("m_customer1");
			ReadOnly();
			LazyLoad();
			Id(x => x.CustCode).GeneratedBy.Assigned().Column("cust_code");
            //References(x => x.Inquiry1).Column("cust_code");
            Map(x => x.OldCustCode).Column("old_cust_code");
			Map(x => x.CustName).Not.Nullable().Column("cust_name");
			Map(x => x.Address).Column("address");
			Map(x => x.CityCode).Not.Nullable().Column("city_code");
			Map(x => x.CountryCode).Not.Nullable().Column("country_code");
			Map(x => x.Zip).Column("zip");
			Map(x => x.State).Column("state");
			Map(x => x.Phone).Column("phone");
			Map(x => x.Fax).Column("fax");
			Map(x => x.Email).Column("email");
			Map(x => x.Uan).Column("uan");
			Map(x => x.Url).Column("url");
			Map(x => x.GlCode).Column("gl_code");
			Map(x => x.Remarks).Column("remarks");
			Map(x => x.CustType).Column("cust_type");
			Map(x => x.UserNo).Not.Nullable().Column("user_no");
			Map(x => x.Flag).Column("flag");
			Map(x => x.BuyerType).Column("buyer_type");
			Map(x => x.QuotaApplicable).Not.Nullable().Column("quota_applicable");
			Map(x => x.EntryDate).Not.Nullable().Column("entry_date");
			Map(x => x.ConsolidatorCode).Column("consolidator_code");
			Map(x => x.CreditDays).Not.Nullable().Column("credit_days");
			Map(x => x.BankCode).Column("bank_code");
			Map(x => x.Beneficiary).Not.Nullable().Column("beneficiary");
			Map(x => x.PrePaid).Not.Nullable().Column("pre_paid");
			Map(x => x.AgencyCode).Column("agency_code");
			Map(x => x.PaymentTermsId).Column("payment_terms_id");
            HasMany(x => x.Inquiry1);





        }
    }
}
