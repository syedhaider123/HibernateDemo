using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class GySchedulingMap : ClassMap<GyScheduling> {
    
    public GySchedulingMap() {
			Table("gy_scheduling");
			LazyLoad();
			Id(x => x.gy_no).GeneratedBy.Identity().Column("gy_no");
			References(x => x.gy_trans1).Column("gy_no");
			Map(x => x.record_id).Column("record_id").Not.Nullable();
			Map(x => x.revision_no).Column("revision_no").Not.Nullable();
			Map(x => x.sch_revision_no).Column("sch_revision_no").Not.Nullable();
			Map(x => x.weaving_date).Column("weaving_date");
			Map(x => x.processing_date).Column("processing_date");
			Map(x => x.trims_acc_date).Column("trims_acc_date");
			Map(x => x.stitching_date).Column("stitching_date");
			Map(x => x.shipment_date).Column("shipment_date");
			Map(x => x.dyes_chem_date).Column("dyes_chem_date");
			Map(x => x.yarn_arrange_date).Column("yarn_arrange_date");
			Map(x => x.remarks).Column("remarks");
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			Map(x => x.flag).Column("flag");
    }
}
