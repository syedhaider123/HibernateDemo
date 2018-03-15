using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MBuyer1Map : ClassMap<MBuyer1> {
    
    public MBuyer1Map() {
			Table("m_buyer1");
			LazyLoad();
			Id(x => x.buyer_code).GeneratedBy.Assigned().Column("buyer_code");
			//References(x => x.m_buyer_grades).Column("grade_code");
			Map(x => x.buyer_name).Column("buyer_name").Not.Nullable();
			Map(x => x.address).Column("address");
			Map(x => x.city_code).Column("city_code");
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
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.flag).Column("flag");
			Map(x => x.buyer_type).Column("buyer_type");
			Map(x => x.print_cust_po).Column("print_cust_po").Not.Nullable();
			Map(x => x.quota_applicable).Column("quota_applicable").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			Map(x => x.container_seal_required).Column("container_seal_required").Not.Nullable();
			Map(x => x.partial_ship_allow).Column("partial_ship_allow").Not.Nullable();
			Map(x => x.agent_serial).Column("agent_serial");
			HasMany(x => x.m_buyer2).KeyColumn("buyer_code");
			HasMany(x => x.m_buyer3).KeyColumn("buyer_code");
			HasMany(x => x.order_sheet1).KeyColumn("buyer_code");
			//HasMany(x => x.projection1).KeyColumn("buyer_code");
    }
}
