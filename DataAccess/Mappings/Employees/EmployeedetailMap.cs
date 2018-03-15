using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class EmployeedetailMap : ClassMap<Employeedetail> {
        
        public EmployeedetailMap() {
			Table("EmployeeDetails");
			ReadOnly();
			LazyLoad();
			Id(x => x.Empdetailsid).GeneratedBy.Identity().Column("EmpDetailsID");
            References(x => x.Employees).Column("Empid");
            Map(x => x.Empid).Column("EmpID");
			Map(x => x.Accountnumber).Column("AccountNumber");
			Map(x => x.Accountname).Column("AccountName");
        }
    }
}
