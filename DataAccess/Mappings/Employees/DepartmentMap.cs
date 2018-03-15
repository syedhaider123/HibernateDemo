using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class DepartmentMap : ClassMap<Department> {
        
        public DepartmentMap() {
			Table("Departments");
			ReadOnly();
			LazyLoad();
			Id(x => x.Departmentid).GeneratedBy.Identity().Column("DepartmentID");
			Map(x => x.Departmentname).Column("DepartmentName");
			HasMany(x => x.Students);
        }
    }
}
