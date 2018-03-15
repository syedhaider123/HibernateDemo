using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class GyTrans1Map : ClassMap<GyTrans1> {
    
    public GyTrans1Map() {
			Table("gy_trans1");
			LazyLoad();
			Id(x => x.gy_no).GeneratedBy.Identity().Column("gy_no");
			Map(x => x.gy_date).Column("gy_date").Not.Nullable();
			Map(x => x.revision_no).Column("revision_no").Not.Nullable();
			Map(x => x.revision_date).Column("revision_date");
			Map(x => x.po_no).Column("po_no");
			Map(x => x.factory_inquiry).Column("factory_inquiry");
			Map(x => x.cust_code).Column("cust_code").Not.Nullable();
			Map(x => x.remarks).Column("remarks");
			Map(x => x.cancelled).Column("cancelled").Not.Nullable();
			Map(x => x.po_assigned).Column("po_assigned").Not.Nullable();
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			Map(x => x.post).Column("post").Not.Nullable();
			Map(x => x.posted_date).Column("posted_date");
			Map(x => x.posted_by).Column("posted_by");
			Map(x => x.cancelled_by).Column("cancelled_by");
			Map(x => x.cancelled_date).Column("cancelled_date");
			HasMany(x => x.gy_scheduling).KeyColumn("gy_no");
			HasMany(x => x.gy_trans2).KeyColumn("gy_no");
    }
}
