using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class OrderSheet1Map : ClassMap<OrderSheet1> {
        
        public OrderSheet1Map() {
			Table("order_sheet1");
			ReadOnly();
			LazyLoad();
			Id(x => x.OsNo).GeneratedBy.Identity().Column("os_no");
			References(x => x.MBuyer1).Column("buyer_code");
			//References(x => x.MShippingMark).Column("s_marks_code");
			Map(x => x.OsDate).Column("os_date");
			Map(x => x.RevisionNo).Not.Nullable().Column("revision_no");
			Map(x => x.RevisionDate).Column("revision_date");
			Map(x => x.PoNo).Column("po_no");
			Map(x => x.PoDate).Column("po_date");
			Map(x => x.PoNoBuyer).Column("po_no_buyer");
			Map(x => x.PoDateBuyer).Column("po_date_buyer");
			Map(x => x.QuotaCode).Column("quota_code");
			Map(x => x.CustCode).Not.Nullable().Column("cust_code");
			Map(x => x.FactoryInquiry).Column("factory_inquiry");
			Map(x => x.GyNo).Column("gy_no");
			Map(x => x.Remarks).Column("remarks");
			Map(x => x.SpecSheet).Column("spec_sheet");
			Map(x => x.OtherDocument).Column("other_document");
			Map(x => x.Cancelled).Not.Nullable().Column("cancelled");
			Map(x => x.Printed).Not.Nullable().Column("printed");
			Map(x => x.Post).Not.Nullable().Column("post");
			Map(x => x.Closed).Not.Nullable().Column("closed");
			Map(x => x.PartialShipment).Column("partial_shipment");
			Map(x => x.Completed).Not.Nullable().Column("completed");
			Map(x => x.PoAssigned).Not.Nullable().Column("po_assigned");
			Map(x => x.UserNo).Not.Nullable().Column("user_no");
			Map(x => x.PostDate).Column("post_date");
			Map(x => x.PostedBy).Column("posted_by");
			Map(x => x.EntryDate).Not.Nullable().Column("entry_date");
			Map(x => x.LotNo).Not.Nullable().Column("lot_no");
			Map(x => x.YarnPRequest).Not.Nullable().Column("yarn_p_request");
			Map(x => x.ClosedBy).Column("closed_by");
			Map(x => x.ClosedOn).Column("closed_on");
			Map(x => x.TransferCheck).Not.Nullable().Column("transfer_check");
			Map(x => x.PoNoOld).Column("po_no_old");
			Map(x => x.PoDateOld).Column("po_date_old");
			Map(x => x.EditedBy).Column("edited_by");
			Map(x => x.EditedDate).Column("edited_date");
			Map(x => x.SoNo).Not.Nullable().Column("so_no");
			Map(x => x.ScNo).Column("sc_no");
			Map(x => x.ScRev).Column("sc_rev");
			Map(x => x.CancelledBy).Column("cancelled_by");
			Map(x => x.CancelledOn).Column("cancelled_on");
			Map(x => x.AutoUpdate).Not.Nullable().Column("auto_update");
			Map(x => x.OracleUpdate).Column("Oracle_Update");
			Map(x => x.SalesOrder).Column("Sales_Order");
			Map(x => x.OpenOrder).Column("Open_Order");
			Map(x => x.LocationCode).Column("Location_code");
			Map(x => x.EdiRef).Column("Edi_ref");
			Map(x => x.LabelPrint).Column("Label_print");
			HasMany(x => x.OrderFollowups);
			HasMany(x => x.OrderStatuses);
			HasMany(x => x.OsSchedulings);
			HasMany(x => x.ShipmentDetailOs);
			HasMany(x => x.ShipmentDetailOsHists);
        }
    }
}
