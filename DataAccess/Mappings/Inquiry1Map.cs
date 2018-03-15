using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class Inquiry1Map : ClassMap<Inquiry1> {
        
        public Inquiry1Map() {
			Table("inquiry1");
			ReadOnly();
			LazyLoad();
			Id(x => x.InquiryNo).GeneratedBy.Identity().Column("inquiry_no");
            References(x => x.CustomerInfo).Column("cust_code");
            References(x => x.ProductDesciption).Column("cust_code");
            Map(x => x.RevisionNo).Not.Nullable().Column("revision_no");
			Map(x => x.InquiryDate).Not.Nullable().Column("inquiry_date");
			Map(x => x.ValidityDate).Column("validity_date");
			Map(x => x.CustCode).Not.Nullable().Column("cust_code");
			Map(x => x.CrmName).Column("crm_name");
			Map(x => x.Post).Column("post");
			Map(x => x.PostDate).Column("post_date");
			Map(x => x.Remarks).Column("remarks");
			Map(x => x.WeaveRemarks).Column("weave_remarks");
			Map(x => x.ProcessRemarks).Column("process_remarks");
			Map(x => x.StitchRemarks).Column("stitch_remarks");
			Map(x => x.PrintRemarks).Column("print_remarks");
			Map(x => x.AUserCode1).Column("a_user_code1");
			Map(x => x.AUserCode2).Column("a_user_code2");
			Map(x => x.AUserCode3).Column("a_user_code3");
			Map(x => x.AUserCode4).Column("a_user_code4");
			Map(x => x.WeavePost).Column("weave_post");
			Map(x => x.ProcessPost).Column("process_post");
			Map(x => x.StitchPost).Column("stitch_post");
			Map(x => x.PrintPost).Column("print_post");
			Map(x => x.WeavePostDate).Column("weave_post_date");
			Map(x => x.ProcessPostDate).Column("process_post_date");
			Map(x => x.StitchPostDate).Column("stitch_post_date");
			Map(x => x.PrintPostDate).Column("print_post_date");
			Map(x => x.Approved).Column("approved");
			Map(x => x.ApproveDate).Column("approve_date");
			Map(x => x.CanceledBy).Column("canceled_by");
			Map(x => x.Canceled).Not.Nullable().Column("canceled");
			Map(x => x.CancelDate).Column("cancel_date");
			Map(x => x.EntryDate).Column("entry_date");
			Map(x => x.UserNo).Not.Nullable().Column("user_no");
			Map(x => x.SafetyOrder).Not.Nullable().Column("safety_order");
			Map(x => x.LocationCode).Column("location_code");
			Map(x => x.OldLocationCodec31).Column("old_location_codeC31");
			Map(x => x.LeadTime).Column("lead_time");
			Map(x => x.CtRevision).Column("ct_revision");
            HasMany(x => x.Inquiry2s);
            //HasOne(x => x.CustomerInfo).Fetch.Join().Inverse().KeyColumn("cust_code");
            //HasOne(x => x.ProductDesciption).ForeignKey("CustomerPk");
           // HasOne(x => x.CustomerInfo);



        }
    }
}
