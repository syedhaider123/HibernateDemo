using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class OrderSheet2Map : ClassMap<OrderSheet2> {
    
    public OrderSheet2Map() {
			Table("order_sheet2");
			LazyLoad();
			Id(x => x.item_sno).GeneratedBy.Identity().Column("item_sno");
			References(x => x.m_currency).Column("currency_code");
			Map(x => x.os_no).Column("os_no").Not.Nullable();
			Map(x => x.revision_no).Column("revision_no").Not.Nullable();
			Map(x => x.b_item_no).Column("b_item_no").Not.Nullable();
			Map(x => x.b_item_revision_no).Column("b_item_revision_no").Not.Nullable();
			Map(x => x.fabric_code).Column("fabric_code");
			Map(x => x.quality_code).Column("quality_code").Not.Nullable();
			Map(x => x.b_reference_no).Column("b_reference_no").Not.Nullable();
			Map(x => x.o_color_code).Column("o_color_code").Not.Nullable();
			Map(x => x.order_quantity).Column("order_quantity").Not.Nullable();
			Map(x => x.increased).Column("increased").Not.Nullable();
			Map(x => x.decreased).Column("decreased").Not.Nullable();
			Map(x => x.unit_price).Column("unit_price").Not.Nullable();
			Map(x => x.package_code).Column("package_code");
			Map(x => x.packing_code).Column("packing_code");
			Map(x => x.dyeing_work_order).Column("dyeing_work_order").Not.Nullable();
			Map(x => x.stitching_work_order).Column("stitching_work_order").Not.Nullable();
			Map(x => x.b_item_old).Column("b_item_old");
			Map(x => x.b_item_revision_old).Column("b_item_revision_old").Not.Nullable();
			Map(x => x.old_b_item_no).Column("old_b_item_no");
			Map(x => x.old_b_reference_no).Column("old_b_reference_no");
			Map(x => x.dwo_cancel_pcs).Column("dwo_cancel_pcs").Not.Nullable();
			Map(x => x.order_qty_pcs).Column("order_qty_pcs").Not.Nullable();
			Map(x => x.stitched_qty_pcs).Column("stitched_qty_pcs").Not.Nullable();
			Map(x => x.pattern_master_id).Column("pattern_master_id");
    }
}
