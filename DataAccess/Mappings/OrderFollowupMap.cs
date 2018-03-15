using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class OrderFollowupMap : ClassMap<OrderFollowup> {
    
    public OrderFollowupMap() {
			Table("order_followup");
			LazyLoad();
			Id(x => x.record_id).GeneratedBy.Identity().Column("record_id");
			References(x => x.order_sheet1).Column("os_no");
			Map(x => x.s_detail_date).Column("s_detail_date").Not.Nullable();
			Map(x => x.remarks).Column("remarks");
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
    }
}
