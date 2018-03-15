using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class EmployeeMap : ClassMap<Employee> {
        
        public EmployeeMap() {
			Table("Employees");
			ReadOnly();
			LazyLoad();
			Id(x => x.Empid).GeneratedBy.Identity().Column("EmpID");
			Map(x => x.Name).Column("Name");
			Map(x => x.Surname).Column("SurName");
			Map(x => x.Post).Column("Post");
			HasMany(x => x.Employeeprojects);
            HasMany(x => x.Employeedetails);

            //Join("", m =>
            //{
            //    m.Fetch.Join();
            //    m.KeyColumn("FieldId");
            //    //m.Map(t => t.DisplayOrder).Nullable();
            //});
        }
    }
}
