using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MCurrencyMap : ClassMap<MCurrency> {
    
    public MCurrencyMap() {
			Table("m_currency");
			LazyLoad();
			Id(x => x.currency_code).GeneratedBy.Assigned().Column("currency_code");
			Map(x => x.currency_name).Column("currency_name").Not.Nullable().Unique();
			Map(x => x.country_code).Column("country_code").Not.Nullable();
			Map(x => x.remarks).Column("remarks");
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.flag).Column("flag");
			Map(x => x.currency_miner).Column("currency_miner");
			Map(x => x.currency_word).Column("currency_word");
			Map(x => x.currency_abbr).Column("currency_abbr").Not.Nullable();
			HasMany(x => x.order_sheet2).KeyColumn("currency_code");
    }
}
