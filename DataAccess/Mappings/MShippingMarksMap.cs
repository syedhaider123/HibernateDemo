using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MShippingMarksMap : ClassMap<MShippingMarks> {
    
    public MShippingMarksMap() {
			Table("m_shipping_marks");
			LazyLoad();
			Id(x => x.s_marks_code).GeneratedBy.Identity().Column("s_marks_code");
			Map(x => x.s_marks_desc).Column("s_marks_desc").Not.Nullable().Unique();
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
			HasMany(x => x.order_sheet1).KeyColumn("s_marks_code");
    }
}
