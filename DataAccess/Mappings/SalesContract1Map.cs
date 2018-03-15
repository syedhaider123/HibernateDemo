using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class SalesContract1Map : ClassMap<SalesContract1> {
        
        public SalesContract1Map() {
			Table("sales_contract1");
			ReadOnly();
			LazyLoad();
			Id(x => x.ScNo).GeneratedBy.Identity().Column("sc_no");
			Map(x => x.ScDate).Not.Nullable().Column("sc_date");
			Map(x => x.RevisionNo).Column("revision_no");
			Map(x => x.CustCode).Not.Nullable().Column("cust_code");
			Map(x => x.BuyerCode).Not.Nullable().Column("buyer_code");
			Map(x => x.ValidUpto).Not.Nullable().Column("valid_upto");
			Map(x => x.Remarks).Column("remarks");
			Map(x => x.UserNo).Not.Nullable().Column("user_no");
			Map(x => x.EntryDate).Not.Nullable().Column("entry_date");
			Map(x => x.Approved).Not.Nullable().Column("approved");
			Map(x => x.ApprovedDate).Column("approved_date");
			Map(x => x.ApprovedBy).Column("approved_by");
			Map(x => x.UnapprovedDate).Column("unapproved_date");
			Map(x => x.UnapprovedBy).Column("unapproved_by");
			Map(x => x.BatchUpdate).Column("batch_update");
			HasMany(x => x.SalesContract2s);
        }
    }
}
