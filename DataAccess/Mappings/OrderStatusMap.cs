using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class OrderStatusMap : ClassMap<OrderStatus> {
    
    public OrderStatusMap() {
			Table("order_status");
			LazyLoad();
			CompositeId().KeyProperty(x => x.os_no, "os_no")
			             .KeyProperty(x => x.package_code, "package_code");
			References(x => x.order_sheet1).Column("os_no");
			//References(x => x.m_package_code1).Column("package_code");
			Map(x => x.record_id).Column("record_id").Not.Nullable();
			Map(x => x.order_quantity).Column("order_quantity").Not.Nullable();
			Map(x => x.defined_quantity).Column("defined_quantity").Not.Nullable();
			Map(x => x.delivered_quantity).Column("delivered_quantity").Not.Nullable();
			Map(x => x.ready_quantity).Column("ready_quantity").Not.Nullable();
			Map(x => x.order_qty_os).Column("order_qty_os").Not.Nullable();
			Map(x => x.defined_qty_os).Column("defined_qty_os").Not.Nullable();
			Map(x => x.delivered_qty_os).Column("delivered_qty_os").Not.Nullable();
			Map(x => x.stitch_quantity).Column("stitch_quantity").Not.Nullable();
			Map(x => x.stitch_completed).Column("stitch_completed").Not.Nullable();
			Map(x => x.post).Column("post").Not.Nullable();
			Map(x => x.abnormal).Column("abnormal").Not.Nullable();
			Map(x => x.complete).Column("complete").Not.Nullable();
			Map(x => x.weighment_qty).Column("weighment_qty").Not.Nullable();
			Map(x => x.stitch_quantity_bp).Column("stitch_quantity_bp").Not.Nullable();
			Map(x => x.delivered_quantity1).Column("delivered_quantity1").Not.Nullable();
    }
}
