using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MPortsMap : ClassMap<MPorts> {
    
    public MPortsMap() {
			Table("m_ports");
			LazyLoad();
			Id(x => x.port_code).GeneratedBy.Assigned().Column("port_code");
			Map(x => x.record_id).Column("record_id").Not.Nullable();
			Map(x => x.port_name).Column("port_name").Not.Nullable().Unique();
			Map(x => x.country_code).Column("country_code").Not.Nullable();
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			Map(x => x.rnd_claimable).Column("rnd_claimable").Not.Nullable();
			Map(x => x.notify_id1).Column("notify_id1");
			Map(x => x.notify_id2).Column("notify_id2");
			HasMany(x => x.shipment_detail_os).KeyColumn("port_code");
			HasMany(x => x.shipment_detail_os_hist).KeyColumn("port_code");
			//HasMany(x => x.shipment_detail_proj).KeyColumn("port_code");
    }
}
