using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class MProductDescMap : ClassMap<MProductDesc> {
    
    public MProductDescMap() {
			Table("m_product_desc");
			LazyLoad();
			Id(x => x.serial_no).GeneratedBy.Identity().Column("serial_no");
			Map(x => x.buyer_ref_abbr).Column("buyer_ref_abbr").Not.Nullable();
			Map(x => x.product_desc).Column("product_desc").Not.Nullable();
			Map(x => x.cust_code).Column("cust_code").Not.Nullable();
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.entry_date).Column("entry_date").Not.Nullable();
    }
}
