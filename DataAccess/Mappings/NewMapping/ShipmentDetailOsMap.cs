using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class ShipmentDetailOsMap : ClassMap<ShipmentDetailOs> {
    
    public ShipmentDetailOsMap() {
			Table("shipment_detail_os");
			LazyLoad();
			Id(x => x.record_id).GeneratedBy.Identity().Column("record_id");
			References(x => x.order_sheet1).Column("os_no");
			References(x => x.m_ports).Column("port_code");
			References(x => x.m_shipment_packing).Column("s_packing_code");
			Map(x => x.revision_no).Column("revision_no").Not.Nullable();
			Map(x => x.b_item_no).Column("b_item_no");
			Map(x => x.shipment_date).Column("shipment_date").Not.Nullable();
			Map(x => x.shipment_date_po).Column("shipment_date_po");
			Map(x => x.window_date).Column("window_date");
			Map(x => x.shipment_qty).Column("shipment_qty").Not.Nullable();
			Map(x => x.weaving_alloted).Column("weaving_alloted").Not.Nullable();
			Map(x => x.po_defined_qty).Column("po_defined_qty").Not.Nullable();
			Map(x => x.weaving_date).Column("weaving_date");
			Map(x => x.processing_date).Column("processing_date");
			Map(x => x.trims_acc_date).Column("trims_acc_date");
			Map(x => x.stitching_date).Column("stitching_date");
			Map(x => x.sch_shipment_date).Column("sch_shipment_date");
			Map(x => x.dyes_chem_date).Column("dyes_chem_date");
			Map(x => x.yarn_arrange_date).Column("yarn_arrange_date");
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.sch_revision_no).Column("sch_revision_no").Not.Nullable();
			Map(x => x.sch_revision_date).Column("sch_revision_date");
    }
}
