using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class MUnitMap : ClassMap<MUnit> {
        
        public MUnitMap() {
			Table("m_units");
			ReadOnly();
			LazyLoad();
			Id(x => x.UnitCode).GeneratedBy.Assigned().Column("unit_code");
			Map(x => x.UnitName).Not.Nullable().Column("unit_name");
			Map(x => x.ShortName).Not.Nullable().Column("short_name");
			Map(x => x.OrderInquiry).Not.Nullable().Column("order_inquiry");
			Map(x => x.Conversion1).Not.Nullable().Column("conversion1");
			Map(x => x.Conversion2).Not.Nullable().Column("conversion2");
			Map(x => x.Operate).Not.Nullable().Column("operate");
			Map(x => x.Alternate).Column("alternate");
			Map(x => x.UserNo).Not.Nullable().Column("user_no");
			Map(x => x.EntryDate).Not.Nullable().Column("entry_date");
        }
    }
}
