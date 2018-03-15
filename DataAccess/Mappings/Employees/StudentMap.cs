using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class StudentMap : ClassMap<Student> {
        
        public StudentMap() {
			Table("Students");
			ReadOnly();
			LazyLoad();
			Id(x => x.Studenid).GeneratedBy.Identity().Column("StudenId");
			References(x => x.Department).Column("DepartmentID");
			Map(x => x.Studentname).Column("StudentName");
			Map(x => x.Courseid).Column("CourseID");
        }
    }
}
