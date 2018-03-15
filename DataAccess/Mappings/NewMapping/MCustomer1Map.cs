using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MCustomer1Map : ClassMap<MCustomer1> {
    
    public MCustomer1Map() {
			Table("m_customer1");
			LazyLoad();
			Id(x => x.cust_code).GeneratedBy.Assigned().Column("cust_code");
			Map(x => x.old_cust_code).Column("old_cust_code");
			Map(x => x.cust_name).Column("cust_name").Not.Nullable();
			Map(x => x.address).Column("address");
			Map(x => x.city_code).Column("city_code").Not.Nullable();
			Map(x => x.country_code).Column("country_code").Not.Nullable();
			Map(x => x.zip).Column("zip");
			Map(x => x.state).Column("state");
			Map(x => x.phone).Column("phone");
			Map(x => x.fax).Column("fax");
			Map(x => x.email).Column("email");
			Map(x => x.uan).Column("uan");
			Map(x => x.url).Column("url");
			Map(x => x.gl_code).Column("gl_code");
			Map(x => x.remarks).Column("remarks");
			Map(x => x.cust_type).Column("cust_type");
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.flag).Column("flag");
			Map(x => x.buyer_type).Column("buyer_type");
			Map(x => x.quota_applicable).Column("quota_applicable").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			Map(x => x.consolidator_code).Column("consolidator_code");
			Map(x => x.credit_days).Column("credit_days").Not.Nullable();
			Map(x => x.bank_code).Column("bank_code");
			Map(x => x.beneficiary).Column("beneficiary").Not.Nullable();
			Map(x => x.pre_paid).Column("pre_paid").Not.Nullable();
			Map(x => x.agency_code).Column("agency_code");
			Map(x => x.payment_terms_id).Column("payment_terms_id");
			//HasMany(x => x.m_customer5).KeyColumn("cust_code");
			//HasMany(x => x.m_customer6).KeyColumn("cust_code");
    }
}
