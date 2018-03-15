using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using DataAccess; 



public partial class Inquiry1Map : ClassMap<Inquiry1> {
    
    public Inquiry1Map() {
			Table("inquiry1");
			LazyLoad();
			Id(x => x.inquiry_no).GeneratedBy.Identity().Column("inquiry_no");
			Map(x => x.revision_no).Column("revision_no").Not.Nullable();
			Map(x => x.inquiry_date).Column("inquiry_date").Not.Nullable();
			Map(x => x.validity_date).Column("validity_date");
			Map(x => x.cust_code).Column("cust_code").Not.Nullable();
			Map(x => x.crm_name).Column("crm_name");
			Map(x => x.post).Column("post");
			Map(x => x.post_date).Column("post_date");
			Map(x => x.remarks).Column("remarks");
			Map(x => x.weave_remarks).Column("weave_remarks");
			Map(x => x.process_remarks).Column("process_remarks");
			Map(x => x.stitch_remarks).Column("stitch_remarks");
			Map(x => x.print_remarks).Column("print_remarks");
			Map(x => x.a_user_code1).Column("a_user_code1");
			Map(x => x.a_user_code2).Column("a_user_code2");
			Map(x => x.a_user_code3).Column("a_user_code3");
			Map(x => x.a_user_code4).Column("a_user_code4");
			Map(x => x.weave_post).Column("weave_post");
			Map(x => x.process_post).Column("process_post");
			Map(x => x.stitch_post).Column("stitch_post");
			Map(x => x.print_post).Column("print_post");
			Map(x => x.weave_post_date).Column("weave_post_date");
			Map(x => x.process_post_date).Column("process_post_date");
			Map(x => x.stitch_post_date).Column("stitch_post_date");
			Map(x => x.print_post_date).Column("print_post_date");
			Map(x => x.approved).Column("approved");
			Map(x => x.approve_date).Column("approve_date");
			Map(x => x.canceled_by).Column("canceled_by");
			Map(x => x.canceled).Column("canceled").Not.Nullable();
			Map(x => x.cancel_date).Column("cancel_date");
			Map(x => x.entry_date).Column("entry_date");
			Map(x => x.user_no).Column("user_no").Not.Nullable();
			Map(x => x.safety_order).Column("safety_order").Not.Nullable();
			Map(x => x.location_code).Column("location_code");
			Map(x => x.old_location_codeC31).Column("old_location_codeC31");
			Map(x => x.lead_time).Column("lead_time");
			Map(x => x.ct_revision).Column("ct_revision");
			HasMany(x => x.inquiry2).KeyColumn("inquiry_no");
			HasMany(x => x.inquiry3).KeyColumn("inquiry_no");
    }
}
