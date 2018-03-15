using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class EmployeeprojectMap : ClassMap<Employeeproject> {
        
        public EmployeeprojectMap() {
			Table("EmployeeProjects");
			ReadOnly();
			LazyLoad();
			Id(x => x.Empprojectid).GeneratedBy.Identity().Column("EmpProjectID");
			References(x => x.Employee).Column("EmpID");
			Map(x => x.Projectname).Column("ProjectName");
        }
    }
}
