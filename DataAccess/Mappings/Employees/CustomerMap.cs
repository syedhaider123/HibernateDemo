using System; 
using System.Collections.Generic; 
using System.Text;
using DataAccess;
using FluentNHibernate.Mapping;

namespace Sample.CustomerService.Domain {
    
    
    public class CustomerMap : ClassMap<Customer> {
        
        public CustomerMap() {
			Table("Customers");
			ReadOnly();
			LazyLoad();
			Id(x => x.Customerid).GeneratedBy.Identity().Column("CustomerID");
			Map(x => x.Customername).Column("CustomerName");
        }
    }
}
