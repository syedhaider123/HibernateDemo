using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class GyTrans2Map : ClassMap<GyTrans2> {
    
    public GyTrans2Map() {
			Table("gy_trans2");
			LazyLoad();
			Id(x => x.record_id).GeneratedBy.Identity().Column("record_id");
			References(x => x.gy_trans1).Column("gy_no");
			Map(x => x.revision_no).Column("revision_no").Not.Nullable();
			Map(x => x.fabric_code).Column("fabric_code");
			Map(x => x.quality_code).Column("quality_code").Not.Nullable();
			Map(x => x.o_color_code).Column("o_color_code").Not.Nullable();
			Map(x => x.unit_code).Column("unit_code").Not.Nullable();
			Map(x => x.quantity).Column("quantity").Not.Nullable();
			Map(x => x.tentative_date).Column("tentative_date").Not.Nullable();
			Map(x => x.weaving_alloted).Column("weaving_alloted").Not.Nullable();
			Map(x => x.weaving_alloted_pcs).Column("weaving_alloted_pcs").Not.Nullable();
			Map(x => x.po_defined_qty).Column("po_defined_qty").Not.Nullable();
			Map(x => x.inquiry_quantity).Column("inquiry_quantity").Not.Nullable();
			Map(x => x.weaving_quantity).Column("weaving_quantity").Not.Nullable();
    }
}
