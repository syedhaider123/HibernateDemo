using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MShipmentPackingMap : ClassMap<MShipmentPacking> {
    
    public MShipmentPackingMap() {
			Table("m_shipment_packing");
			LazyLoad();
			Id(x => x.s_packing_code).GeneratedBy.Assigned().Column("s_packing_code");
			Map(x => x.s_packing_name).Column("s_packing_name").Not.Nullable();
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			HasMany(x => x.shipment_detail_os).KeyColumn("s_packing_code");
			HasMany(x => x.shipment_detail_os_hist).KeyColumn("s_packing_code");
			//HasMany(x => x.shipment_detail_proj).KeyColumn("s_packing_code");
    }
}
