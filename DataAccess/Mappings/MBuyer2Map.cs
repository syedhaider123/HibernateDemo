using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MBuyer2Map : ClassMap<MBuyer2> {
    
    public MBuyer2Map() {
			Table("m_buyer2");
			LazyLoad();
			Id(x => x.person_code).GeneratedBy.Assigned().Column("person_code");
			References(x => x.m_buyer1).Column("buyer_code");
			Map(x => x.gender).Column("gender").Not.Nullable();
			Map(x => x.person_name).Column("person_name").Not.Nullable();
			Map(x => x.designation).Column("designation");
    }
}
