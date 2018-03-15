using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class SysdiagramMap : ClassMap<Sysdiagram> {
        
        public SysdiagramMap() {
			Table("sysdiagrams");
			ReadOnly();
			LazyLoad();
			Id(x => x.DiagramId).GeneratedBy.Identity().Column("diagram_id");
			Map(x => x.Name).Not.Nullable().Column("name");
			Map(x => x.PrincipalId).Not.Nullable().Column("principal_id");
			Map(x => x.Version).Column("version");
			Map(x => x.Definition).Column("definition");
        }
    }
}
