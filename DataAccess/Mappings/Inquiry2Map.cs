using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class Inquiry2Map : ClassMap<Inquiry2> {
        
        public Inquiry2Map() {
			Table("inquiry2");
			ReadOnly();
			LazyLoad();
			Id(x => x.RecordId).GeneratedBy.Identity().Column("record_id");
			References(x => x.Inquiry1).Column("inquiry_no");
			Map(x => x.RevisionNo).Not.Nullable().Column("revision_no");
			Map(x => x.BItemNo).Column("b_item_no");
			Map(x => x.BItemRevisionNo).Not.Nullable().Column("b_item_revision_no");
			Map(x => x.FabricCode).Column("fabric_code");
			Map(x => x.QualityCode).Not.Nullable().Column("quality_code");
			Map(x => x.OColorCode).Not.Nullable().Column("o_color_code");
			Map(x => x.Quantity).Not.Nullable().Column("quantity");
			Map(x => x.Unit).Not.Nullable().Column("unit");
			Map(x => x.ShipDate).Column("ship_date");
			Map(x => x.ExpShipDate).Column("exp_ship_date");
			Map(x => x.GyNo).Column("gy_no");
			Map(x => x.GyTran2RecordId).Column("gy_tran2_record_id");
			Map(x => x.Patternmasterid).Column("patternMasterId");
			 
        }
    }
}
