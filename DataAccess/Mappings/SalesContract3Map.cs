using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class SalesContract3Map : ClassMap<SalesContract3> {
        
        public SalesContract3Map() {
			Table("sales_contract3");
			ReadOnly();
			LazyLoad();
			Id(x => x.RecordId).GeneratedBy.Identity().Column("record_id");
			References(x => x.SalesContract2).Column("serial_no");
			Map(x => x.ScNo).Not.Nullable().Column("sc_no");
			Map(x => x.RevisionNo).Column("revision_no");
			Map(x => x.QualityCode).Not.Nullable().Column("quality_code");
			Map(x => x.OColorCode).Not.Nullable().Column("o_color_code");
			Map(x => x.Patternmasterid).Column("patternMasterId");
			Map(x => x.Quantity).Not.Nullable().Column("quantity");
			Map(x => x.UnitPrice).Not.Nullable().Column("unit_price");
        }
    }
}
