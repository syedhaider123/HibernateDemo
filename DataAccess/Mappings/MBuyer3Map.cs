using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MBuyer3Map : ClassMap<MBuyer3> {
    
    public MBuyer3Map() {
			Table("m_buyer3");
			LazyLoad();
			Id(x => x.record_id).GeneratedBy.Identity().Column("record_id");
			References(x => x.m_buyer1).Column("buyer_code");
			Map(x => x.bank_name).Column("bank_name").Not.Nullable();
			Map(x => x.bank_address).Column("bank_address").Not.Nullable();
    }
}
