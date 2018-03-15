using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class SalesContract2Map : ClassMap<SalesContract2> {
        
        public SalesContract2Map() {
			Table("sales_contract2");
			ReadOnly();
			LazyLoad();
			Id(x => x.SerialNo).GeneratedBy.Identity().Column("serial_no");
			References(x => x.SalesContract1).Column("sc_no");
			Map(x => x.RevisionNo).Column("revision_no");
			Map(x => x.BItemNo).Not.Nullable().Column("b_item_no");
			Map(x => x.UnitCode).Not.Nullable().Column("unit_code");
			Map(x => x.CurrencyCode).Not.Nullable().Column("currency_code");
			Map(x => x.RatePerPackage).Not.Nullable().Column("rate_per_package");
			Map(x => x.Post).Not.Nullable().Column("post");
			Map(x => x.CommodityCode).Column("commodity_code");
			HasMany(x => x.SalesContract3s);
			//HasMany(x => x.SalesContract4s);
        }
    }
}
