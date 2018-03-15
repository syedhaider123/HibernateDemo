using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class OrderSheet1Map : ClassMap<OrderSheet1> {
    
    public OrderSheet1Map() {
			Table("order_sheet1");
			LazyLoad();
			Id(x => x.os_no).GeneratedBy.Identity().Column("os_no");
			References(x => x.m_buyer1).Column("buyer_code");
			References(x => x.m_shipping_marks).Column("s_marks_code");
			Map(x => x.os_date).Column("os_date");
			Map(x => x.revision_no).Column("revision_no").Not.Nullable();
			Map(x => x.revision_date).Column("revision_date");
			Map(x => x.po_no).Column("po_no");
			Map(x => x.po_date).Column("po_date");
			Map(x => x.po_no_buyer).Column("po_no_buyer");
			Map(x => x.po_date_buyer).Column("po_date_buyer");
			Map(x => x.quota_code).Column("quota_code");
			Map(x => x.cust_code).Column("cust_code").Not.Nullable();
			Map(x => x.factory_inquiry).Column("factory_inquiry");
			Map(x => x.gy_no).Column("gy_no");
			Map(x => x.remarks).Column("remarks");
			Map(x => x.spec_sheet).Column("spec_sheet");
			Map(x => x.other_document).Column("other_document");
			Map(x => x.cancelled).Column("cancelled").Not.Nullable();
			Map(x => x.printed).Column("printed").Not.Nullable();
			Map(x => x.post).Column("post").Not.Nullable();
			Map(x => x.closed).Column("closed").Not.Nullable();
			Map(x => x.partial_shipment).Column("partial_shipment");
			Map(x => x.completed).Column("completed").Not.Nullable();
			Map(x => x.po_assigned).Column("po_assigned").Not.Nullable();
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.post_date).Column("post_date");
			Map(x => x.posted_by).Column("posted_by");
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			Map(x => x.lot_no).Column("lot_no").Not.Nullable();
			Map(x => x.yarn_p_request).Column("yarn_p_request").Not.Nullable();
			Map(x => x.closed_by).Column("closed_by");
			Map(x => x.closed_on).Column("closed_on");
			Map(x => x.transfer_check).Column("transfer_check").Not.Nullable();
			Map(x => x.po_no_old).Column("po_no_old");
			Map(x => x.po_date_old).Column("po_date_old");
			Map(x => x.edited_by).Column("edited_by");
			Map(x => x.edited_date).Column("edited_date");
			Map(x => x.so_no).Column("so_no").Not.Nullable();
			Map(x => x.sc_no).Column("sc_no");
			Map(x => x.sc_rev).Column("sc_rev");
			Map(x => x.cancelled_by).Column("cancelled_by");
			Map(x => x.cancelled_on).Column("cancelled_on");
			Map(x => x.auto_update).Column("auto_update").Not.Nullable();
			Map(x => x.Oracle_Update).Column("Oracle_Update");
			Map(x => x.Sales_Order).Column("Sales_Order");
			Map(x => x.Open_Order).Column("Open_Order");
			Map(x => x.Location_code).Column("Location_code");
			Map(x => x.Edi_ref).Column("Edi_ref");
			Map(x => x.Label_print).Column("Label_print");
			HasMany(x => x.order_followup).KeyColumn("os_no");
			HasMany(x => x.order_status).KeyColumn("os_no");
			HasMany(x => x.os_scheduling).KeyColumn("os_no");
			HasMany(x => x.shipment_detail_os).KeyColumn("os_no");
			HasMany(x => x.shipment_detail_os_hist).KeyColumn("os_no");
    }
}
