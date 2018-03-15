using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class Inquiry2Map : ClassMap<Inquiry2> {
    
    public Inquiry2Map() {
			Table("inquiry2");
			LazyLoad();
			Id(x => x.record_id).GeneratedBy.Identity().Column("record_id");
			References(x => x.inquiry1).Column("inquiry_no");
			Map(x => x.revision_no).Column("revision_no").Not.Nullable();
			Map(x => x.b_item_no).Column("b_item_no");
			Map(x => x.b_item_revision_no).Column("b_item_revision_no").Not.Nullable();
			Map(x => x.fabric_code).Column("fabric_code");
			Map(x => x.quality_code).Column("quality_code").Not.Nullable();
			Map(x => x.o_color_code).Column("o_color_code").Not.Nullable();
			Map(x => x.quantity).Column("quantity").Not.Nullable();
			Map(x => x.unit).Column("unit").Not.Nullable();
			Map(x => x.ship_date).Column("ship_date");
			Map(x => x.exp_ship_date).Column("exp_ship_date");
			Map(x => x.gy_no).Column("gy_no");
			Map(x => x.gy_tran2_record_id).Column("gy_tran2_record_id");
			Map(x => x.patternMasterId).Column("patternMasterId");
			HasMany(x => x.inquiry_printing).KeyColumn("record_id");
			HasMany(x => x.inquiry_processing).KeyColumn("record_id");
			HasMany(x => x.inquiry_stitching).KeyColumn("record_id");
			HasMany(x => x.inquiry_weaving).KeyColumn("record_id");
			HasMany(x => x.inquiry_yarn).KeyColumn("record_id");
    }
}
