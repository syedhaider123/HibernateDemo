using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Sample.CustomerService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Helper
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly("DataAccess");

            //ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            //return sessionFactory.OpenSession();

            ISessionFactory sessionFactory = Fluently.Configure()

               .Database(MsSqlConfiguration.MsSql2008

                 .ConnectionString("Server=sqltest;Database=HibernateDatabase;User Id=sa;Password=assistant;").ShowSql()

               )

                

                
                              .Mappings(m => {

                                               m.HbmMappings.AddFromAssembly(Assembly.GetExecutingAssembly());

                                           m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly());

                                        })




               .ExposeConfiguration(cfg => new SchemaExport(cfg)

                .Create(false, false))

               .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }


    }
}
