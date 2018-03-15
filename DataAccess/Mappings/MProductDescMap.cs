using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class MProductDescMap : ClassMap<MProductDesc> {
        
        public MProductDescMap() {
			Table("m_product_desc");
			ReadOnly();
			LazyLoad();
			Id(x => x.SerialNo).GeneratedBy.Identity().Column("serial_no");
            //References(x => x.Inquiry1).Column("cust_code");
            Map(x => x.BuyerRefAbbr).Not.Nullable().Column("buyer_ref_abbr");
			Map(x => x.ProductDesc).Not.Nullable().Column("product_desc");
			Map(x => x.CustCode).Not.Nullable().Column("cust_code");
			Map(x => x.UserNo).Not.Nullable().Column("user_no");
			Map(x => x.EntryDate).Not.Nullable().Column("entry_date");
            HasMany(x => x.Inquiry1);


        }
    }
}
