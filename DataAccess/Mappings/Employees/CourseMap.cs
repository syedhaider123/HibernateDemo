using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace DataAccess {
    
    
    public class CourseMap : ClassMap<Course> {
        
        public CourseMap() {
			Table("Courses");
			ReadOnly();
			LazyLoad();
			Id(x => x.Courseid).GeneratedBy.Identity().Column("CourseID");
			Map(x => x.Coursename).Column("CourseName");
			Map(x => x.Departmentid).Column("DepartmentID");
        }
    }
}
