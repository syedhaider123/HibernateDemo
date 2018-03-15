 
using DataAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Json;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HibernateDemo.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        public dynamic GetList(string value)
        {
            ISession session = Helper.OpenSession();
            IList dataEmployee = session.CreateCriteria(typeof(Employees)).List();
            string strserialize = JsonConvert.SerializeObject(dataEmployee);
            return strserialize.Replace(@"\""", @"""");
        }


        [HttpGet]
        public dynamic GetList()
        {
            ISession session = Helper.OpenSession();

           var orders3 = session.QueryOver<Inquiry1>().Fetch(o => o.CustomerInfo);

            //var orders2 = session.CreateCriteria<Inquiry1>().SetResultTransformer(Transformers.DistinctRootEntity).List();

            string strserialize = JsonConvert.SerializeObject(orders3);
            return strserialize.Replace(@"\""", @"""");
        }

      

        [HttpGet]
        public dynamic GetAllInquiry()
        {
            ISession session = Helper.OpenSession();
            IList dataEmployee = session.CreateCriteria(typeof(Employees)).List();
            string strserialize = JsonConvert.SerializeObject(dataEmployee);
            return strserialize;
        }

        [HttpGet]
        public dynamic GetAllProducts()
        {
            ISession session = Helper.OpenSession();
            IList dataEmployee = session.CreateCriteria(typeof(MCustomer1)).List();


            Inquiry1 employee  = null;
            Inquiry2 employeeProject = null;
            var pointLists = session.QueryOver<Inquiry1>(() => employee)
                                   .JoinQueryOver<Inquiry2>(ppPoints => ppPoints.Inquiry2s, () => employeeProject)
                               .List().Where(s => s.Post == "U").Take(2);


            Inquiry1 productAlias = null;
            Inquiry2 productReviewAlias = null;


            IList<LeadDTO> highestReviews =
    session.QueryOver<Inquiry1>(() => productAlias)
        .JoinQueryOver(pr => pr.Inquiry2s, () => productReviewAlias)

            //IList<LeadDTO> products = session.QueryOver<Inquiry1>(() => employee)
            //                       .JoinQueryOver<Inquiry2>(inquiry2Object => inquiry2Object.Inquiry2s, () => inquiry2Object)

    .SelectList(list => list
        .Select(pr => pr.InquiryNo).WithAlias(() => productAlias.InquiryNo)
        .Select(pr => pr.Post).WithAlias(() => productAlias.Post)
        .Select(pr => pr.CustCode).WithAlias(() => productAlias.CustCode)
        .Select(pr => pr.Inquiry2s).WithAlias(() => productAlias.Inquiry2s)
        .Select(pr => pr.Inquiry2s).WithAlias(() => productAlias.Inquiry2s)

        )

    .TransformUsing(Transformers.AliasToBean<LeadDTO>())
    .List<LeadDTO>();

            //    Inquiry1 tblOfficer = null;
            //    Inquiry2 tblPerson = null;
            //    var results = session.QueryOver<Inquiry1>(() => tblOfficer).Where(a =>a.Post =="U")
            //      .JoinQueryOver(p => p.Inquiry2s, () => tblPerson)
            //       .SelectList(list => list
            //        .Select(() => tblOfficer.InquiryNo)
            //        .Select(() => tblPerson.Quantity)
            //       ).List<Inquiry1>();



            //    Inquiry1 clientAlias = null;

            //    var query = session.QueryOver<Inquiry1>(() => clientAlias)
            //            .Select(
            //                Projections.Distinct(
            //                    Projections.ProjectionList()
            //                        .Add(Projections.Property<Inquiry1>(x => x.InquiryNo).As("Id"))
            //                        .Add(Projections.Property<Inquiry1>(x => x.Post).As("Post"))
            //                //.Add(Projections.Property<Inquiry1>(x => x.Surname).As("Surname"))
            //                //.Add(Projections.Property<Inquiry1>(x => x.GivenName).As("GivenName"))
            //                //.Add(Projections.Property<Inquiry1>(x => x.EmailAddress).As("EmailAddress"))
            //                //.Add(Projections.Property<Inquiry1>(x => x.MobilePhone).As("MobilePhone"))
            //                )
            //            )
            //           .TransformUsing(Transformers.AliasToBeanConstructor(
            //    typeof(LeadDTO).GetConstructors().First()))
            //.List<LeadDTO>();
            //.OrderBy(() => clientAlias.Surname).Asc
            //.ThenBy(() => clientAlias.GivenName).Asc;

            string strserialize = JsonConvert.SerializeObject(highestReviews);

            //LeadDTO dto = null;
            //var schoolList = session.QueryOver
            //         .SelectList(i => i
            //         .Select(p => p.Name).WithAlias(() => dto.Name)
            //         .Select(p => p.Lat).WithAlias(() => dto.Lat)
            //         .Select(p => p.Lng).WithAlias(() => dto.Lng)
            //       )
            //       .Where(w => w.Lat != null && w.Lng != null)
            //       .TransformUsing(LeadDTO.AliasToBean<LeadDTO>())
            //       .List<LeadDTO>();

            //avaScriptSerializer().Serialize(dataEmployee);

            //Employee ppointAlias = null;
            //Employeedetail ppFileAlias = null;
            //var pointList = session.QueryOver<Employee>(() => ppointAlias)
            //                       .JoinQueryOver<Employeedetail>(ppPoint => ppPoint.EmployeeDetails, () => ppFileAlias)
            //                        .List();

            //Inquiry1 ppointAlias = null;
            //MProductDesc ppFileAlias = null;
            //var pointList = session.QueryOver<Inquiry1>(() => ppointAlias)
            //                       .JoinQueryOver<MProductDesc>(ppPoint => ppPoint.ProductInfo, () => ppFileAlias)
            //                        .List();





            //Employee employee  = null;
            //Employeeproject employeeProject = null;
            //var pointLists = session.QueryOver<Employee>(() => employee)
            //                       .JoinQueryOver<Employeeproject>(ppPoints => ppPoints.Employeeprojects, () => employeeProject)
            //                   .List();



            //var employeeDetailsObject = pointLists[0].Employeedetails;
            //var employeeProjectDetails = pointLists[0].Employeeprojects;
            // ppointAlias.AccountName = employeeDetailsObject.


            //MCSDModule Queries


            //Inquiry1 inquiry1Alias = null;
            //Inquiry2 inquiry2Alias = null;
            //var query = session.QueryOver<Inquiry1>(() => inquiry1Alias)
            //                       .JoinQueryOver<Inquiry2>(k=>k. () => inquiry2Alias)
            //                        .List();


            //  var _query =    session.QueryOver<Inquiry1>()
            //.JoinQueryOver(employeeGroup => employeeGroup.Inquiry2s)
            //.Take(100)   // The same as top in SQL, if you don't want load all of entities
            //.List();

            //        var query = session.QueryOver<Inquiry1>(() => inquiry1Alias)
            //.joinAlias(() => inquiry1Alias.favorites, () => personfavouriteAlias)
            //.joinAlias(() => personAlias.companies, () => personCompanyAlias)
            //.joinAlias(() => personfavouriteAlias.Favourite, () => favouriteAlias)
            //.joinAlias(() => personCompanyAlias.Company, () => companyAlias)

             //string strserialize = JsonConvert.SerializeObject(highestReviews);
            return strserialize;
        }

      


        [HttpGet]
        public dynamic GetAllLeadsById(int inquiryNo)
        {

            ISession session = Helper.OpenSession();


            LeadDTO result = null;
            Inquiry1 employee = null;
            Inquiry2 employeeProject = null;
            MCustomer1 customer = null;


            var linq = from inquiry in session.Query<Inquiry1>()
                       join customers in session.Query<MCustomer1>().DefaultIfEmpty()
                       on inquiry.CustCode equals customers.CustCode
                       join inquiryObj in session.Query<Inquiry2>()
                       on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                       join productDesc in session.Query<MProductDesc>()
                       on customers.CustCode equals productDesc.CustCode

                       where inquiry.Post == "U" && inquiry.InquiryNo == inquiryNo
                       select new LeadDTO
                       {
                           InquiryNo = inquiry.InquiryNo,
                           Post = inquiry.Post,
                           CustomerName = customers.CustName,
                           Quantity = inquiryObj.Quantity,
                           Unit = inquiryObj.Unit,
                           ProductDesc = productDesc.ProductDesc,
                           ResponseCode = "Ok",
                           InquireDate  = inquiry.InquiryDate.ToShortDateString(),

                       };


            var pointLists = session.QueryOver<Inquiry1>(() => employee).Where(x => employee.Post == "U")
                                   .JoinQueryOver<Inquiry2>(ppPoints => ppPoints.Inquiry2s, () => employeeProject)
                                   //.JoinQueryOver<MCustomer1>(x => employee.CustomerInfo, () => customer)

                            .SelectList(list => list
                            .Select(pr => pr.InquiryNo).WithAlias(() => result.InquiryNo)
                            .Select(pr => pr.Post).WithAlias(() => result.Post)
                            .Select(pr => pr.CustCode).WithAlias(() => result.CustCode)
                            .Select(() => employeeProject.Quantity).WithAlias(() => result.Quantity)
                            .Select(() => employeeProject.Unit).WithAlias(() => result.Unit)
                            .Select(() => customer.CustName).WithAlias(() => result.CustomerName)

                            )
                        .TransformUsing(Transformers.AliasToBean<LeadDTO>())
                          .List<LeadDTO>();

            string strserialize = JsonConvert.SerializeObject(pointLists);
            return strserialize.Replace(@"\""", @"""");

        }


        [HttpGet]
        public dynamic GetAllCustomers()
        {
            ISession session = Helper.OpenSession();
            IList dataEmployee = session.CreateCriteria(typeof(MCustomer1)).List();

            LeadDTO result = null;
            Inquiry1 employee = null;
            Inquiry2 employeeProject = null;
            MCustomer1 customer = null;


            var pointLists = session.QueryOver<Inquiry1>(() => employee)
                                  //.JoinAlias(x => x.CustomerInfo, () => customer, JoinType.RightOuterJoin).Where(p => employee.Post == "u")
                            //.JoinQueryOver<MCustomer1>(x => employee.CustomerInfo, () => customer,JoinType.RightOuterJoin)


                            .SelectList(list => list
                            .Select(pr => pr.InquiryNo).WithAlias(() => result.InquiryNo)
                            .Select(pr => pr.Post).WithAlias(() => result.Post)
                            .Select(pr => pr.CustCode).WithAlias(() => result.CustCode)
                            //.Select(() => employeeProject.Quantity).WithAlias(() => result.Quantity)
                            //.Select(() => employeeProject.Unit).WithAlias(() => result.Unit)
                            .Select(() => customer.CustName).WithAlias(() => result.CustomerName)
                             
                            )
                        .TransformUsing(Transformers.AliasToBean<LeadDTO>())
                          .List<LeadDTO>();


            IQueryOver<Inquiry1, MCustomer1> catQuery = null;
      
         //  .Left.JoinQueryOver(c => c.CustomerInfo);
            


            string strserialize = JsonConvert.SerializeObject(catQuery);
            return strserialize.Replace(@"\""", @"""");

        }


        [HttpGet]
        public dynamic GetAllEmployees()
        {
            ISession session = Helper.OpenSession();
            //IList inquiry1Object = session.CreateCriteria(typeof(Inquiry1)).List();


            // IList customerObject = session.CreateCriteria(typeof(MCustomer1)).List();

            //IList inquiry2Object = session.CreateCriteria(typeof(Inquiry2)).List();

            //IList productObject = session.CreateCriteria(typeof(MProductDesc)).List();


            //   var customers = session.QueryOver<MCustomer1>() .Where(x => x.CustCode == 8);

            // IList dataEmployeeDetails = session.CreateCriteria(typeof(Employeedetail)).List();



            LeadDTO result = null;
            Inquiry1 _inquiry1 = null;
            Inquiry2 _inquiry2 = null;
            MCustomer1 customer = null;
            MProductDesc productDesc = null;


            var pointLists = session.QueryOver<Inquiry1>(() => _inquiry1).Where(x=>_inquiry1.Post=="P")
                .JoinAlias(x => x.Inquiry2s, () => _inquiry2, JoinType.InnerJoin)
                //.JoinAlias(x => x.CustomerInfo, () => customer, JoinType.RightOuterJoin)
                .JoinAlias(x => x.ProductDesciption, () => productDesc, JoinType.RightOuterJoin)
                            


                            .SelectList(list => list
                            .Select(pr => pr.InquiryNo).WithAlias(() => result.InquiryNo)
                            .Select(pr => pr.Post).WithAlias(() => result.Post)
                            .Select(pr => pr.CustCode).WithAlias(() => result.CustCode)
                            .Select(() => _inquiry2.Quantity).WithAlias(() => result.Quantity)
                            .Select(() => _inquiry2.Unit).WithAlias(() => result.Unit)
                            .Select(() => customer.CustName).WithAlias(() => result.CustomerName)
                            .Select(() => productDesc.ProductDesc).WithAlias(() => result.ProductDesc)

                            )
                        .TransformUsing(Transformers.AliasToBean<LeadDTO>())
                          .List<LeadDTO>();




            //var pointLists = session.QueryOver<Inquiry1>(() => employee)

            //                      .JoinQueryOver<MCustomer1>(x => employee.CustomerInfo, () => customer) 


            //               .SelectList(list => list


            //               .Select(() => customer.CustName).WithAlias(() => result.CustomerName)

            //               )
            //           .TransformUsing(Transformers.AliasToBean<LeadDTO>())
            //             .List<LeadDTO>();


            //Inquiry1 component = null;
            //var foundEntity = session
            //   .QueryOver<Inquiry1>()
            //   .JoinAlias(x => x.CustomerInfo ,() => component, JoinType.LeftOuterJoin)
            //   .Where(g => component.Post == "U")
            //   .SingleOrDefault();

            //string strserialize = JsonConvert.SerializeObject(dataEmployee);
            string strserialize = JsonConvert.SerializeObject(pointLists);
            //string strserialize = JsonConvert.SerializeObject(dataEmployeeDetails);
            return strserialize.Replace(@"\""", @"""");

        }


        [HttpGet]
        public dynamic GetAllEmployeesMock()
        {
            ISession session = Helper.OpenSession();


            EmployeeDTO empDTO = null;
            Employee _inquiry1 = null;
            Employeedetail empDetails = null;
            Employeeproject empProjects = null;
            

            var pointLists = session.QueryOver<Employee>(() => _inquiry1).Where (P =>P.Post =="p")
                .JoinAlias(x => x.Employeedetails, () => empDetails, JoinType.InnerJoin)
            //.JoinAlias(x => x.CustomerInfo, () => customer, JoinType.RightOuterJoin)

            .SelectList(list => list
                            .Select(pr => pr.Empid).WithAlias(() => empDTO.Empid)
                            .Select(pr => pr.Post).WithAlias(() => empDTO.Post)
                            .Select(pr => pr.Name).WithAlias(() => empDTO.Name)
                            .Select(pp => empDetails.Accountname).WithAlias(() => empDTO.Name)

                            )
                        .TransformUsing(Transformers.AliasToBean<EmployeeDTO>())
                          .List<EmployeeDTO>();

            string strserialize = JsonConvert.SerializeObject(pointLists);
            return strserialize.Replace(@"\""", @"""");
        }


        [HttpGet]
        public dynamic GetAllLeads()
        {
            ISession session = Helper.OpenSession();

            LeadDTO result = null;
            Inquiry1 _inquiry1 = null;
            Inquiry2 _inquiry2 = null;
            MCustomer1 customer = null;
            MProductDesc productDesc = null;

            //Testing Code

            Inquiry1 employee = null;
            Inquiry2 employeeProject = null;
            //var pointLists = session.QueryOver<Inquiry1>(() => employee)
            //                       .JoinQueryOver<Inquiry2>(ppPoints => ppPoints.Inquiry2s, () => employeeProject)
            //                   .List().Where(s => s.Post == "U").Take(2);


            //IList<Inquiry1> precedingOrMatchingResult = session.QueryOver<Inquiry1>().List();


            //MCustomer1 cust = precedingOrMatchingResult[0].CustomerInfo;






            //IList dataEmployee = session.Query<Inquiry1>().ToList();


            //var testQuery = session.QueryOver<Inquiry1>(() => _inquiry1)
            //     .JoinAlias(p => p.Inquiry2s, () => _inquiry2,JoinType.InnerJoin);
            //.JoinAlias(p => p.Contacts, () => contactAlias)
            //.Where(p => p.Post == "U");



            //var pointLists = session.QueryOver<Inquiry1>(() => _inquiry1)
            //    .JoinAlias(x => x.Inquiry2s, () => _inquiry2, JoinType.InnerJoin)
            //    .Where(X => _inquiry1.Post == "U");

            //var customerInfo = session.QueryOver<Inquiry1>(() => _inquiry1)
            //    .JoinAlias(effort => effort.Inquiry2s, () => _inquiry2 , JoinType.FullJoin)
            //    .JoinAlias(effort => effort.CustomerInfo, () => customer, JoinType.FullJoin)
            //   .JoinAlias(effort => effort.ProductDesciption, () => productDesc, JoinType.FullJoin)


            //    .SelectList(list => list
            //                .Select(pr => pr.InquiryNo).WithAlias(() => result.InquiryNo)
            //                .Select(pr => pr.Post).WithAlias(() => result.Post)
            //                .Select(pr => pr.CustCode).WithAlias(() => result.CustCode)
            //                .Select(() => _inquiry2.Quantity).WithAlias(() => result.Quantity)
            //                .Select(() => _inquiry2.Unit).WithAlias(() => result.Unit)
            //                .Select(() => customer.CustName).WithAlias(() => result.CustomerName)
            //                .Select(() => productDesc.ProductDesc).WithAlias(() => result.ProductDesc)

            //                )
            //            .TransformUsing(Transformers.AliasToBean<LeadDTO>())
            //              .List<LeadDTO>();

            /*
            var dtoParents = session.QueryOver<Inquiry1>(() => _inquiry1).Where(p => p.Post == "P")
            //.JoinQueryOver(x => _inquiry1.Inquiry2s, () => _inquiry2, JoinType.FullJoin)
            // .JoinQueryOver(x => _inquiry1.ProductDesciption, () => productDesc, JoinType.LeftOuterJoin)
            //.JoinAlias(x => _inquiry1.CustomerInfo, () => customer, JoinType.RightOuterJoin)
            
            .SelectList(list => list
                        .Select(pr => pr.InquiryNo).WithAlias(() => result.InquiryNo)
                        .Select(pr => pr.Post).WithAlias(() => result.Post)
                        .Select(pr => pr.CustCode).WithAlias(() => result.CustCode)
                        //.Select(() => _inquiry2.Quantity).WithAlias(() => result.Quantity)
                        //.Select(() => _inquiry2.Unit).WithAlias(() => result.Unit)
                        .Select(() => customer.CustName).WithAlias(() => result.CustomerName)
                        //.Select(() => productDesc.ProductDesc).WithAlias(() => result.ProductDesc)
                        )
            .TransformUsing(Transformers.AliasToBean<LeadDTO>())
           .List<LeadDTO>();
            */

            

            ///

            Inquiry1 aAlias = null;
            Inquiry2 ss_inquiry2 = null;
            MCustomer1 bAlias = null;
            LeadDTO resultAlias = null;

            IList<LeadDTO> final_result = session.QueryOver<Inquiry1>(() => aAlias)
           .Inner.JoinQueryOver(p => aAlias.Inquiry2s, () => ss_inquiry2)
            .Inner.JoinQueryOver(p => aAlias.CustomerInfo, () => bAlias)

    .SelectList(list => list
        .Select(() => aAlias.InquiryNo).WithAlias(() => resultAlias.InquiryNo)
        .Select(() => aAlias.Post).WithAlias(() => resultAlias.Post)
        .Select(() => ss_inquiry2.Quantity).WithAlias(() => resultAlias.Quantity)
        .Select(() => ss_inquiry2.Unit).WithAlias(() => resultAlias.Unit)
        .Select(() => bAlias.CustName).WithAlias(() => resultAlias.CustomerName)
        ).Where(x => aAlias.Post == "U")
    .TransformUsing(Transformers.AliasToBean<LeadDTO>())
    .List<LeadDTO>();
            ///



            Inquiry1 oit = null;
            MCustomer1 it = null;

            Inquiry1 user = null;
            MCustomer1 membership = null;

            LeadDTO dto = null;
            var users = session.QueryOver(() => user)
                .JoinAlias(u => u.CustomerInfo, () => membership)
                //.JoinQueryOver<OrgUnitMembership>(u => u.OrgUnitMemberships)
                .SelectList(list => list
                    //.Select(() => user.InquiryNo)
                    //.Select(() => user.InquiryNo)
                    //.Select(() => user.Post))
                    .Select(() => membership.CustName).WithAlias(() => dto.CustomerName)
                    .Select(() => membership.CustCode).WithAlias(() => dto.CustCode))
    .TransformUsing(Transformers.AliasToBean<LeadDTO>())
    .List<LeadDTO>();



            string strserialize = JsonConvert.SerializeObject(users);
            
            if (strserialize != null)
                return Request.CreateResponse(HttpStatusCode.OK, strserialize);
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound
                                    , "No Leads found");

        }


        [HttpGet]
        public dynamic GetAllLeadsMockUp()
        {


            Inquiry1 aAlias = null;
            Inquiry2 ss_inquiry2 = null;
            MCustomer1 bAlias = null;
            LeadDTO resultAlias = null;
            ISession session = Helper.OpenSession();

            /*
            IList<LeadDTO> final_result = session.QueryOver<Inquiry1>(() => aAlias)
           .Inner.JoinQueryOver(p => aAlias.Inquiry2s, () => ss_inquiry2)

           //.Right.JoinQueryOver(p => aAlias.CustomerInfo, () => bAlias)

    .SelectList(list => list
        .Select(() => aAlias.InquiryNo).WithAlias(() => resultAlias.InquiryNo)
        .Select(() => aAlias.Post).WithAlias(() => resultAlias.Post)
        .Select(() => ss_inquiry2.Quantity).WithAlias(() => resultAlias.Quantity)
        .Select(() => ss_inquiry2.Unit).WithAlias(() => resultAlias.Unit)
        //.Select(() => bAlias.CustName).WithAlias(() => resultAlias.CustomerName)
        )
    .TransformUsing(Transformers.AliasToBean<LeadDTO>())
    .List<LeadDTO>();
    */


           
            var results = session.QueryOver<Inquiry1>()
                 .JoinAlias(o => o.CustomerInfo, () => bAlias)
                 .Select(Projections.ProjectionList()
                  .Add(Projections.Property<Inquiry1>(o => o.InquiryNo).WithAlias(() => resultAlias.InquiryNo))
                  .Add(Projections.Property<Inquiry1>(o => o.Post).WithAlias(() => resultAlias.Post))
                  //.Add(Projections.Property<MCustomer1>(() => items.Id).WithAlias(() => resultAlias.CustomerName))
                  //.Add(Projections.Property<MCustomer1>(p => bAlias.CustName).WithAlias(() => resultAlias.CustomerName))
                 //.Add(Projections.Count(() => items.Id).WithAlias(() => orderDto.ItemCount))
                 ) 
                 .TransformUsing(Transformers.AliasToBean<LeadDTO>())
                .List<LeadDTO>();

            string strserialize = JsonConvert.SerializeObject(results.Count());

            if (strserialize != null)
                return Request.CreateResponse(HttpStatusCode.OK, strserialize);
            else return Request.CreateErrorResponse(HttpStatusCode.NotFound
                                    , "No Leads found");

        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsMock()
        {

            ISession session = Helper.OpenSession();

            LeadDTO result = null;
            Inquiry1 employee = null;
            Inquiry2 _inquiry2 = null;
            MCustomer1 customer = null;
            MProductDesc products = null;

            LeadDTO resultDTO = null;
            Student student = null;
            Course course = null;

             

         var linq = from inquiry in session.Query<Inquiry1>()
                    join customers in session.Query<MCustomer1>()
                    on inquiry.CustCode equals customers.CustCode
                    join inquiryObj in session.Query<Inquiry2>()
                    on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                    join productDesc in session.Query<MProductDesc>()
                    on customers.CustCode equals productDesc.CustCode
                    where inquiry.Post == "U"

                    select new LeadDTO
                    {
                        InquiryNo = inquiry.InquiryNo,
                        Post = inquiry.Post,
                        CustomerName = customers.CustName,
                        Quantity = inquiryObj.Quantity,
                        Unit = inquiryObj.Unit,
                        ProductDesc = productDesc.ProductDesc,
                        InquireDate = inquiry.InquiryDate.ToShortDateString()

                        //InquireDate = inquiry.InquiryDate
                        //ResponseCode = "Ok",
                        //InquireDate = inquiry.InquiryDate,

                    };

            var metaData = new
            {
                page = "1",
                pages = "1",
                perpage = "-1",
                total = linq.Count(),
                sort = "asc",
                field = "InquiryNo",
            };

            var Ans = new { meta = metaData,  data = linq };
            
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.OK, Ans);


        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsMock(DateTime ? dateTo, DateTime ? dateFrom, string  status)
        {

            ISession session = Helper.OpenSession();

            

            if (dateTo.HasValue && dateFrom.HasValue && !string.IsNullOrEmpty(status))
            {

                var linq = from inquiry in session.Query<Inquiry1>()
                           join customers in session.Query<MCustomer1>()
                           on inquiry.CustCode equals customers.CustCode
                           join inquiryObj in session.Query<Inquiry2>()
                           on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                           join productDesc in session.Query<MProductDesc>()
                           on customers.CustCode equals productDesc.CustCode
                           join units in session.Query<MUnit>()
                           on inquiryObj.Unit equals units.UnitCode
                           where   inquiry.Post == status &&  (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date)
                           group inquiryObj by new
                           {
                               inquiry.InquiryNo,
                               inquiry.InquiryDate,
                               customers.CustName,
                               productDesc.ProductDesc,
                               inquiryObj.Unit,
                               units.UnitName,
                               inquiry.Post,
                               inquiryObj.ShipDate,
                               inquiry.ValidityDate,
                               inquiry.Remarks,
                               units.Conversion1,
                               inquiry.CustCode


                           } into g


                           select new LeadDTO
                           {
                               InquiryNo = g.Key.InquiryNo,
                               Quantity = g.Sum(s => s.Quantity * Convert.ToInt32(g.Key.Conversion1)),
                               CustomerName = g.Key.CustName,
                               InquireDate = g.Key.InquiryDate.ToShortDateString(),
                               ProductDesc = g.Key.ProductDesc,
                               Unit = g.Key.Unit,
                               UnitName = g.Key.UnitName,
                               Post = g.Key.Post,
                               ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                               ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                               Remarks = g.Key.Remarks,
                               CustCode = g.Key.CustCode

                               
                           };
                                                                                      
    



                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };

                
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, Ans);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }


        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsMockByPostAnalysis(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();



            if (dateTo.HasValue && dateFrom.HasValue && !string.IsNullOrEmpty(status))
            {

                var linq = from inquiry in session.Query<Inquiry1>()
                           join customers in session.Query<MCustomer1>()
                           on inquiry.CustCode equals customers.CustCode
                           join inquiryObj in session.Query<Inquiry2>()
                           on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                           join productDesc in session.Query<MProductDesc>()
                           on customers.CustCode equals productDesc.CustCode
                           join units in session.Query<MUnit>()
                           on inquiryObj.Unit equals units.UnitCode
                           where inquiry.Post == status && (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date)
                           group inquiryObj by new
                           {
                               inquiry.InquiryNo,
                               inquiry.InquiryDate,
                               customers.CustName,
                               productDesc.ProductDesc,
                               inquiryObj.Unit,
                               units.UnitName,
                               inquiry.Post,
                               inquiryObj.ShipDate,
                               inquiry.ValidityDate,
                               inquiry.Remarks,
                               units.Conversion1


                           } into g


                           select new LeadDTO
                           {
                               InquiryNo = g.Key.InquiryNo,
                               Quantity = g.Sum(s => s.Quantity * Convert.ToInt32(g.Key.Conversion1)),
                               CustomerName = g.Key.CustName,
                               InquireDate = g.Key.InquiryDate.ToShortDateString(),
                               ProductDesc = g.Key.ProductDesc,
                               Unit = g.Key.Unit,
                               UnitName = g.Key.UnitName,
                               Post = g.Key.Post,
                               ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                               ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                               Remarks = g.Key.Remarks
                           };




                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, Ans);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsMockByPostNegotiating(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();



            if (dateTo.HasValue && dateFrom.HasValue && !string.IsNullOrEmpty(status))
            {

                var linq = from inquiry in session.Query<Inquiry1>()
                           join customers in session.Query<MCustomer1>()
                           on inquiry.CustCode equals customers.CustCode
                           join inquiryObj in session.Query<Inquiry2>()
                           on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                           join productDesc in session.Query<MProductDesc>()
                           on inquiry.CustCode equals productDesc.CustCode
                           join units in session.Query<MUnit>()
                           on inquiryObj.Unit equals units.UnitCode
                           join salescontract in session.Query<SalesContract3>()
                           on inquiryObj.QualityCode equals salescontract.QualityCode


                           where inquiry.Post == status && (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date)
                           group new { inquiryObj, salescontract }
                           by new
                           {
                               inquiry.InquiryNo,
                               inquiry.InquiryDate,
                               customers.CustName,
                               productDesc.ProductDesc,
                               inquiryObj.Unit,
                               units.UnitName,
                               inquiry.Post,
                               inquiryObj.ShipDate,
                               inquiry.Remarks,
                               units.Conversion1,
                               salescontract.ScNo,
                               inquiryObj.GyNo





                           } into g


                           select new LeadDTO
                           {
                               InquiryNo = g.Key.InquiryNo,
                               Quantity = g.Sum(s => s.inquiryObj.Quantity * Convert.ToDecimal(g.Key.Conversion1)),
                               UnitPrice = g.Sum(s => Convert.ToDecimal(s.salescontract.UnitPrice)),
                               CustomerName = g.Key.CustName,
                               InquireDate = g.Key.InquiryDate.ToShortDateString(),
                               ProductDesc = g.Key.ProductDesc,
                               Unit = g.Key.Unit,
                               UnitName = g.Key.UnitName,
                               Post = g.Key.Post,
                               ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                               //ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                               Remarks = g.Key.Remarks,
                               sc_no = g.Key.ScNo,
                               gy_no = g.Key.GyNo.HasValue ? g.Key.GyNo.Value : 0

                           };  
                 
 


                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, Ans);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsMockByPostWon(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();



            if (dateTo.HasValue && dateFrom.HasValue && !string.IsNullOrEmpty(status))
            {

                var linq = from inquiry in session.Query<Inquiry1>()
                           join customers in session.Query<MCustomer1>()
                           on inquiry.CustCode equals customers.CustCode
                           join inquiryObj in session.Query<Inquiry2>()
                           on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                           join productDesc in session.Query<MProductDesc>()
                           on customers.CustCode equals productDesc.CustCode
                           join units in session.Query<MUnit>()
                           on inquiryObj.Unit equals units.UnitCode
                           join orderSheet in session.Query<OrderSheet1>()
                           on inquiry.InquiryNo equals Convert.ToInt32(orderSheet.FactoryInquiry)

                           where inquiry.Post == status && (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date) && orderSheet.PoNo !=null
                           group new { inquiryObj }
                            by new
                            {
                                inquiry.InquiryNo,
                                inquiry.InquiryDate,
                                customers.CustName,
                                productDesc.ProductDesc,
                                inquiryObj.Unit,
                                units.UnitName,
                                inquiry.Post,
                                inquiryObj.ShipDate,
                                inquiry.ValidityDate,
                                inquiry.Remarks,
                                units.Conversion1,
 

                            } into g


                           select new LeadDTO
                           {
                               InquiryNo = g.Key.InquiryNo,
                               Quantity = g.Sum(s => s.inquiryObj.Quantity * Convert.ToInt32(g.Key.Conversion1)),
                               CustomerName = g.Key.CustName,
                               InquireDate = g.Key.InquiryDate.ToShortDateString(),
                               ProductDesc = g.Key.ProductDesc,
                               Unit = g.Key.Unit,
                               UnitName = g.Key.UnitName,
                               Post = g.Key.Post,
                               ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                               ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                               Remarks = g.Key.Remarks
                           };
 

                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, Ans);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }


        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsMockByPostLost(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();



            if (dateTo.HasValue && dateFrom.HasValue && !string.IsNullOrEmpty(status))
            {

                var linq = status == "U" ? from inquiry in session.Query<Inquiry1>()
                                           join customers in session.Query<MCustomer1>()
                                           on inquiry.CustCode equals customers.CustCode
                                           join inquiryObj in session.Query<Inquiry2>()
                                           on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                                           join productDesc in session.Query<MProductDesc>()
                                           on customers.CustCode equals productDesc.CustCode
                                           join units in session.Query<MUnit>()
                                           on inquiryObj.Unit equals units.UnitCode
                                           where inquiry.Post == status && (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date)
                                           group inquiryObj by new
                                           {
                                               inquiry.InquiryNo,
                                               inquiry.InquiryDate,
                                               customers.CustName,
                                               productDesc.ProductDesc,
                                               inquiryObj.Unit,
                                               units.UnitName,
                                               inquiry.Post,
                                               inquiryObj.ShipDate,
                                               inquiry.ValidityDate,
                                               inquiry.Remarks,
                                               units.Conversion1


                                           } into g


                                           select new LeadDTO
                                           {
                                               InquiryNo = g.Key.InquiryNo,
                                               Quantity = g.Sum(s => s.Quantity * Convert.ToInt32(g.Key.Conversion1)),
                                               CustomerName = g.Key.CustName,
                                               InquireDate = g.Key.InquiryDate.ToShortDateString(),
                                               ProductDesc = g.Key.ProductDesc,
                                               Unit = g.Key.Unit,
                                               UnitName = g.Key.UnitName,
                                               Post = g.Key.Post,
                                               ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                                               ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                                               Remarks = g.Key.Remarks
                                           } : status == "P" ? from inquiry in session.Query<Inquiry1>()
                                                               join customers in session.Query<MCustomer1>()
                                                               on inquiry.CustCode equals customers.CustCode
                                                               join inquiryObj in session.Query<Inquiry2>()
                                                               on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                                                               join productDesc in session.Query<MProductDesc>()
                                                               on customers.CustCode equals productDesc.CustCode
                                                               join units in session.Query<MUnit>()
                                                               on inquiryObj.Unit equals units.UnitCode



                                                               where inquiry.Post == status && (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date) && inquiry.InquiryNo == 37417


                                                               group new { inquiryObj }
                                                                by new
                                                                {
                                                                    inquiry.InquiryNo,
                                                                    inquiry.InquiryDate,
                                                                    customers.CustName,
                                                                    productDesc.ProductDesc,
                                                                    inquiryObj.Unit,
                                                                    units.UnitName,
                                                                    inquiry.Post,
                                                                    inquiryObj.ShipDate,
                                                                    inquiry.ValidityDate,
                                                                    inquiry.Remarks,
                                                                    units.Conversion1,



                                                                } into g


                                                               select new LeadDTO
                                                               {
                                                                   InquiryNo = g.Key.InquiryNo,
                                                                   Quantity = g.Sum(s => s.inquiryObj.Quantity * Convert.ToInt32(g.Key.Conversion1)),
                                                                   CustomerName = g.Key.CustName,
                                                                   InquireDate = g.Key.InquiryDate.ToShortDateString(),
                                                                   ProductDesc = g.Key.ProductDesc,
                                                                   Unit = g.Key.Unit,
                                                                   UnitName = g.Key.UnitName,
                                                                   Post = g.Key.Post,
                                                                   ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                                                                   ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                                                                   Remarks = g.Key.Remarks
                                                               } : status == "P Neg" ? from inquiry in session.Query<Inquiry1>()
                                                                                       join customers in session.Query<MCustomer1>()
                                                                                       on inquiry.CustCode equals customers.CustCode
                                                                                       join inquiryObj in session.Query<Inquiry2>()
                                                                                       on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                                                                                       join productDesc in session.Query<MProductDesc>()
                                                                                       on customers.CustCode equals productDesc.CustCode
                                                                                       join units in session.Query<MUnit>()
                                                                                       on inquiryObj.Unit equals units.UnitCode
                                                                                       join orderSheet in session.Query<OrderSheet1>()
                                                                                       on inquiry.InquiryNo equals Convert.ToInt32(orderSheet.FactoryInquiry)
                                                                                       join salescontract in session.Query<SalesContract1>()
                                                                                       on inquiry.CustCode equals salescontract.CustCode
                                                                                       join salescontract2 in session.Query<SalesContract2>()
                                                                                       on salescontract.ScNo equals salescontract2.SalesContract1.ScNo
                                                                                       join salescontract3 in session.Query<SalesContract3>()
                                                                                       on salescontract2.SalesContract1.ScNo equals salescontract3.ScNo


                                                                                       where inquiry.Post == "P" && (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date)
                                                                                       group new { inquiryObj, salescontract3 }
                                                                                        by new
                                                                                        {
                                                                                            inquiry.InquiryNo,
                                                                                            inquiry.InquiryDate,
                                                                                            customers.CustName,
                                                                                            productDesc.ProductDesc,
                                                                                            inquiryObj.Unit,
                                                                                            units.UnitName,
                                                                                            inquiry.Post,
                                                                                            inquiryObj.ShipDate,
                                                                                            inquiry.ValidityDate,
                                                                                            inquiry.Remarks,
                                                                                            units.Conversion1,




                                                                                        } into g


                                                                                       select new LeadDTO
                                                                                       {
                                                                                           InquiryNo = g.Key.InquiryNo,
                                                                                           Quantity = g.Sum(s => s.inquiryObj.Quantity * Convert.ToInt32(g.Key.Conversion1)),
                                                                                           UnitPrice = g.Sum(s => Convert.ToDecimal(s.salescontract3.UnitPrice)),
                                                                                           CustomerName = g.Key.CustName,
                                                                                           InquireDate = g.Key.InquiryDate.ToShortDateString(),
                                                                                           ProductDesc = g.Key.ProductDesc,
                                                                                           Unit = g.Key.Unit,
                                                                                           UnitName = g.Key.UnitName,
                                                                                           Post = g.Key.Post,
                                                                                           ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                                                                                           ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                                                                                           Remarks = g.Key.Remarks

                                                                                       } : from inquiry in session.Query<Inquiry1>()
                                                                                           join customers in session.Query<MCustomer1>()
                                                                                           on inquiry.CustCode equals customers.CustCode
                                                                                           join inquiryObj in session.Query<Inquiry2>()
                                                                                           on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                                                                                           join productDesc in session.Query<MProductDesc>()
                                                                                           on customers.CustCode equals productDesc.CustCode
                                                                                           join units in session.Query<MUnit>()
                                                                                           on inquiryObj.Unit equals units.UnitCode
                                                                                           join orderSheet in session.Query<OrderSheet1>()
                                                                                           on inquiry.InquiryNo equals Convert.ToInt32(orderSheet.FactoryInquiry)

                                                                                           where inquiry.Post == status && (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date)
                                                                                           group new { inquiryObj }
                                                                                            by new
                                                                                            {
                                                                                                inquiry.InquiryNo,
                                                                                                inquiry.InquiryDate,
                                                                                                customers.CustName,
                                                                                                productDesc.ProductDesc,
                                                                                                inquiryObj.Unit,
                                                                                                units.UnitName,
                                                                                                inquiry.Post,
                                                                                                inquiryObj.ShipDate,
                                                                                                inquiry.ValidityDate,
                                                                                                inquiry.Remarks,
                                                                                                units.Conversion1,






                                                                                            } into g


                                                                                           select new LeadDTO
                                                                                           {
                                                                                               InquiryNo = g.Key.InquiryNo,
                                                                                               Quantity = g.Sum(s => s.inquiryObj.Quantity * Convert.ToInt32(g.Key.Conversion1)),
                                                                                               CustomerName = g.Key.CustName,
                                                                                               InquireDate = g.Key.InquiryDate.ToShortDateString(),
                                                                                               ProductDesc = g.Key.ProductDesc,
                                                                                               Unit = g.Key.Unit,
                                                                                               UnitName = g.Key.UnitName,
                                                                                               Post = g.Key.Post,
                                                                                               ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                                                                                               ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                                                                                               Remarks = g.Key.Remarks
                                                                                           };




                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, Ans);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }


        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsGYMock(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();



            if (dateTo.HasValue && dateFrom.HasValue && !string.IsNullOrEmpty(status))
            {


                var linq = from inquiry in session.Query<GyTrans1>()
                           join customers in session.Query<MCustomer1>()
                           on inquiry.cust_code equals customers.CustCode
                           join inquiryObj in session.Query<GyTrans2>()
                           on inquiry.gy_no equals inquiryObj.gy_trans1.gy_no
                           join productDesc in session.Query<MProductDesc>()
                           on customers.CustCode equals productDesc.CustCode
                           join units in session.Query<MUnit>()
                           on inquiryObj.unit_code equals units.UnitCode
                           where inquiry.post == status && (inquiry.gy_date.Date >= dateFrom.Value.Date && inquiry.gy_date.Date <= dateTo.Value.Date)
                           group inquiryObj by new
                           {
                               //inquiry.InquiryNo,
                               //inquiry.InquiryDate,
                               
                               GYDate =inquiry.gy_date,
                               customers.CustName,
                               productDesc.ProductDesc,
                               inquiryObj.unit_code,
                               units.UnitName,
                               inquiry.post,
                               units.Conversion1


                           } into g


                           select new LeadDTO
                           {
                               //InquiryNo = g.Key.InquiryNo,
                               Quantity = g.Sum(s => Convert.ToDecimal(s.quantity) * Convert.ToDecimal(g.Key.Conversion1)),
                               CustomerName = g.Key.CustName,
                               GYDate = g.Key.GYDate.ToShortDateString(),
                               ProductDesc = g.Key.ProductDesc,
                               Unit = g.Key.unit_code,
                               UnitName = g.Key.UnitName,
                               Post = g.Key.post,
                               //ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                               //ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                               //Remarks = g.Key.Remarks
                           };



                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, Ans);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }

        [HttpGet]
        public dynamic GetAllLeadsMockByID(int id)
        {

            ISession session = Helper.OpenSession();

            LeadDTO result = null;
            Inquiry1 employee = null;
            Inquiry2 _inquiry2 = null;
            MCustomer1 customer = null;
            MProductDesc products = null;
            

            LeadDTO resultDTO = null;
            Student student = null;
            Course course = null;


            #region TBR
            //var pointLists = session.QueryOver<Inquiry1>(() => employee).Where(a => a.Post == "U")
            //.Left.JoinAlias(() => employee.CustomerInfo,() => customer)


            //var pointLists = session.QueryOver<Inquiry1>(() => employee)
            // .JoinAlias(x => x.Inquiry2s, () => _inquiry2, JoinType.InnerJoin)
            //  .JoinAlias(x => x.CustomerInfo, () => customer, JoinType.LeftOuterJoin)
            //  //.JoinQueryOver(x => x.ProductDesciption, () => products, JoinType.FullJoin)

            //  .JoinAlias(x => x.ProductDesciption, () => products, JoinType.InnerJoin)
            //         .SelectList(
            //    list => list
            //    .SelectGroup(b => b.Id)
            //    .SelectGroup(b => b.Title)
            //    .SelectCount(b => comment.Id)
            //)

            //.JoinAlias(x => x.ProductDesciption, () => products, JoinType.RightOuterJoin)



            //var pointLists = session.QueryOver<Inquiry1>().Where(a => a.Post == "U")
            //            .Inner.JoinAlias(b => b.Inquiry2s, () => _inquiry2)
            //            .Inner.JoinAlias(b => b.CustomerInfo, () => customer)
            //.Inner.JoinAlias(b => b.ProductDesciption, () => products)

            //var pointLists = session.QueryOver<MProductDesc>()
            // Inner Join
            //.Inner.JoinAlias(p => p.Inquiry2s ,()=> _inquiry2)
            // left outer join
            //.Right.JoinAlias(p => p.ProductDesciption, () => products)
            //.Inner.JoinAlias(p => p.CustomerInfo, () => customer)
            //.Left.JoinAlias(() => products => products)

            //.SelectList(list => list
            //.Select(pr => pr.InquiryNo).WithAlias(() => result.InquiryNo)
            //.Select(pr => pr.Post).WithAlias(() => result.Post)
            //.Select(pr => pr.CustCode).WithAlias(() => result.CustCode)
            //.Select(() => _inquiry2.Quantity).WithAlias(() => result.Quantity)
            //.Select(() => _inquiry2.Unit).WithAlias(() => result.Unit)
            //.Select(() => _inquiry2.).WithAlias(() => result.Unit)
            //.Select(() => customer.CustName).WithAlias(() => result.CustomerName)
            //.Select(() => products.ProductDesc).WithAlias(() => result.ProductDesc)

            //)
            //.TransformUsing(Transformers.AliasToBean<LeadDTO>())
            //.List<LeadDTO>();
            #endregion

            /*
            var linq = from inquiry in session.Query<Inquiry1>()
                       join customers in session.Query<MCustomer1>()
                       on inquiry.CustCode equals customers.CustCode
                       join inquiryObj in session.Query<Inquiry2>()
                       on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                       join productDesc in session.Query<MProductDesc>()
                       on customers.CustCode equals productDesc.CustCode
                      
                       where inquiry.Post == "U" && inquiry.InquiryNo == id

                       select new LeadDTO
                       {
                           InquiryNo = inquiry.InquiryNo,
                           InquireDate = inquiry.InquiryDate.ToShortDateString(),
                           ShipDate = inquiryObj.ShipDate.Value.ToShortDateString(),
                           Post = inquiry.Post,
                           PostStatus = inquiry.Post == "U" ? "Open"  : "Close",
                           CustomerName = customers.CustName,
                           Quantity = inquiryObj.Quantity,
                           Unit = inquiryObj.Unit,
                           ProductDesc = productDesc.ProductDesc,
                           QualityCode = inquiryObj.QualityCode,
                           ColorCode = inquiryObj.OColorCode,
                           LeadTime = "0",
                           
                       };*/




            var linq = from inquiry in session.Query<Inquiry1>()
                       join customers in session.Query<MCustomer1>()
                       on inquiry.CustCode equals customers.CustCode
                       join inquiryObj in session.Query<Inquiry2>()
                       on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                       join productDesc in session.Query<MProductDesc>()
                       on customers.CustCode equals productDesc.CustCode
                       where inquiry.InquiryNo == id 
                       //where inquiry.Post == status && (inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date)
                       group inquiryObj by new
                       {
                           inquiry.PostDate,
                           inquiry.InquiryNo,
                           inquiry.InquiryDate,
                           customers.CustName,
                           inquiry.CustCode,
                           productDesc.ProductDesc,
                           inquiryObj.Unit,
                           inquiry.Post,
                           inquiryObj.ShipDate,
                           inquiry.ValidityDate,
                           inquiryObj.QualityCode,
                           inquiryObj.OColorCode,


                       } into g


                       select new LeadDTO
                       {
                           CustCode = g.Key.CustCode,
                           InquiryNo = g.Key.InquiryNo,
                           Quantity = g.Sum(s => s.Quantity),
                           CustomerName = g.Key.CustName,
                           InquireDate = g.Key.InquiryDate.ToShortDateString(),
                           ProductDesc = g.Key.ProductDesc,
                           Post = g.Key.Post,
                           ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                           ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : "",
                           PostDate = g.Key.PostDate.HasValue ? g.Key.PostDate.Value.ToShortDateString() : "",
                           QualityCode = g.Key.QualityCode,
                           ColorCode = g.Key.OColorCode,


                       };




            var metaData = new
            {
                page = "1",
                pages = "1",
                perpage = "-1",
                total = linq.Count(),
                sort = "asc",
                field = "InquiryNo",
            };

            var Ans = new { meta = metaData, data = linq };

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.OK, Ans);

            
        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllOrdersMock()
        {

            ISession session = Helper.OpenSession();

            OrderDTO result = null;
            OrderSheet1 employee = null;
            OrderSheet2 _inquiry2 = null;
            MCustomer1 customer = null;
            MProductDesc products = null;
            GyTrans1 gy1 = null;
            GyTrans2 gy2 = null;


            var linq = from inquiry in session.Query<OrderSheet1>()
                       join customers in session.Query<MCustomer1>()
                       on inquiry.CustCode equals customers.CustCode
                       join inquiryObj in session.Query<OrderSheet2>()
                       on inquiry.OsNo equals inquiryObj.os_no
                       join shipmentDetails in session.Query<ShipmentDetailOs>()
                       on inquiry.OsNo equals shipmentDetails.order_sheet1.OsNo
                       join inquirys in session.Query<GyTrans1>()
                       on inquiry.GyNo equals inquirys.gy_no.ToString()
                       where inquiry.Post == "U" && inquiry.OsNo == 119356

                      
                       select new OrderDTO
                       {
                           Post = inquiry.Post,
                           GyNo = inquiry.GyNo,
                           CustomerName = customers.CustName,
                           order_qty_pcs = inquiryObj.order_qty_pcs,
                           quality_code = inquiryObj.quality_code,
                           shipment_date_po = shipmentDetails.shipment_date_po.Value.ToShortDateString(),
                           PoNo = inquiry.PoNo,
                           OrderDate = inquiry.OsDate.Value.ToShortDateString()
                           
                           //Quantity = inquiryObj.Quantity,
                           //Unit = inquiryObj.Unit,
                           //ProductDesc = productDesc.ProductDesc,
                           //ResponseCode = "Ok",
                           //InquireDate = inquiry.,
                           //StyleCode = 

                       };



            var metaData = new
            {
                page = "1",
                pages = "1",
                perpage = "-1",
                total = linq.Count(),
                sort = "asc",
                field = "InquiryNo",
            };

            var Ans = new { meta = metaData, data = linq };

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.OK, Ans);


        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllOrdersMock(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();

            var linq = from inquiry in session.Query<OrderSheet1>()
                       join customers in session.Query<MCustomer1>()
                       on inquiry.CustCode equals customers.CustCode
                       join productDescription in session.Query<MProductDesc>()
                       on inquiry.CustCode equals productDescription.CustCode
                       join inquiryObj in session.Query<OrderSheet2>()
                       on inquiry.OsNo equals inquiryObj.os_no
                       join shipmentDetails in session.Query<ShipmentDetailOs>()
                       on inquiry.OsNo equals shipmentDetails.order_sheet1.OsNo
                       join inquirys in session.Query<GyTrans1>()
                       on inquiry.GyNo equals inquirys.gy_no.ToString()
                       where inquiry.Post == status && inquiry.OsDate.Value.Date >= dateFrom.Value.Date && inquiry.OsDate.Value.Date <= dateTo.Value.Date
                       group inquiryObj by new
                       {
                           inquiry.OsNo,
                           inquiry.PoDate,
                           inquiry.Post,
                           inquiry.GyNo,
                           customers.CustName,
                           inquiryObj.order_qty_pcs,
                           inquiry.OsDate,
                           inquiry.PoNo,
                           inquiryObj.quality_code,
                           shipmentDetails.shipment_date_po,
                           productDescription.ProductDesc

                           

                       } into g

                       select new OrderDTO
                       {
                           os_no = g.Key.OsNo,
                           Post = g.Key.Post,
                           Quantity = g.Sum(s => s.order_qty_pcs),
                           GyNo = g.Key.GyNo,
                           CustomerName = g.Key.CustName,
                           order_qty_pcs = g.Key.order_qty_pcs,
                           quality_code = g.Key.quality_code,
                           shipment_date_po = g.Key.shipment_date_po.HasValue ? g.Key.shipment_date_po.Value.ToShortDateString():"",
                           PoNo = g.Key.PoNo,
                           OrderDate = g.Key.OsDate.HasValue ?g.Key.OsDate.Value.ToShortDateString():"",
                           ProductDesc=g.Key.ProductDesc

                           //Post = g.Key.InquiryNo,
                           //Quantity = g.Sum(s => s.Quantity),
                           //CustomerName = g.Key.CustName,
                           //InquireDate = g.Key.InquiryDate.ToShortDateString(),
                           //ProductDesc = g.Key.ProductDesc,
                           //Unit = g.Key.Unit,
                           //UnitName = g.Key.UnitName,
                           //Post = g.Key.Post,
                           //ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                           //ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : ""

                           //Quantity = inquiryObj.Quantity,
                           //Unit = inquiryObj.Unit,
                           //ProductDesc = productDesc.ProductDesc,
                           //ResponseCode = "Ok",
                           //InquireDate = inquiry.,
                           //StyleCode = 

                       };



            var metaData = new
            {
                page = "1",
                pages = "1",
                perpage = "-1",
                total = linq.Count(),
                sort = "asc",
                field = "InquiryNo",
            };

            var Ans = new { meta = metaData, data = linq };

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.OK, Ans);


        }


        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllOrdersGYMock(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();

            var linq = from inquiry in session.Query<OrderSheet1>()
                       join customers in session.Query<MCustomer1>()
                       on inquiry.CustCode equals customers.CustCode
                       join productDescription in session.Query<MProductDesc>()
                       on inquiry.CustCode equals productDescription.CustCode
                       join inquiryObj in session.Query<OrderSheet2>()
                       on inquiry.OsNo equals inquiryObj.os_no
                       join shipmentDetails in session.Query<ShipmentDetailOs>()
                       on inquiry.OsNo equals shipmentDetails.order_sheet1.OsNo
                       join inquirys in session.Query<GyTrans1>()
                       on inquiry.GyNo equals inquirys.gy_no.ToString()
                       where inquiry.Post == status && inquiry.OsDate.Value.Date >= dateFrom.Value.Date && inquiry.OsDate.Value.Date <= dateTo.Value.Date
                       group inquiryObj by new
                       {
                           inquiry.OsNo,
                           inquiry.PoDate,
                           inquiry.Post,
                           inquiry.GyNo,
                           customers.CustName,
                           inquiryObj.order_qty_pcs,
                           inquiry.OsDate,
                           inquiry.PoNo,
                           inquiryObj.quality_code,
                           shipmentDetails.shipment_date_po,
                           productDescription.ProductDesc



                       } into g

                       select new OrderDTO
                       {
                           os_no = g.Key.OsNo,
                           Post = g.Key.Post,
                           Quantity = g.Sum(s => s.order_qty_pcs),
                           GyNo = g.Key.GyNo,
                           CustomerName = g.Key.CustName,
                           order_qty_pcs = g.Key.order_qty_pcs,
                           quality_code = g.Key.quality_code,
                           shipment_date_po = g.Key.shipment_date_po.HasValue ? g.Key.shipment_date_po.Value.ToShortDateString() : "",
                           PoNo = g.Key.PoNo,
                           OrderDate = g.Key.OsDate.HasValue ? g.Key.OsDate.Value.ToShortDateString() : "",
                           ProductDesc = g.Key.ProductDesc

                           //Post = g.Key.InquiryNo,
                           //Quantity = g.Sum(s => s.Quantity),
                           //CustomerName = g.Key.CustName,
                           //InquireDate = g.Key.InquiryDate.ToShortDateString(),
                           //ProductDesc = g.Key.ProductDesc,
                           //Unit = g.Key.Unit,
                           //UnitName = g.Key.UnitName,
                           //Post = g.Key.Post,
                           //ShipDate = g.Key.ShipDate.HasValue ? g.Key.ShipDate.Value.ToShortDateString() : "",
                           //ValidityDate = g.Key.ValidityDate.HasValue ? g.Key.ValidityDate.Value.ToShortDateString() : ""

                           //Quantity = inquiryObj.Quantity,
                           //Unit = inquiryObj.Unit,
                           //ProductDesc = productDesc.ProductDesc,
                           //ResponseCode = "Ok",
                           //InquireDate = inquiry.,
                           //StyleCode = 

                       };



            var metaData = new
            {
                page = "1",
                pages = "1",
                perpage = "-1",
                total = linq.Count(),
                sort = "asc",
                field = "InquiryNo",
            };

            var Ans = new { meta = metaData, data = linq };

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.OK, Ans);


        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllOrdersMockByID(int id)
        {

            ISession session = Helper.OpenSession();

           
            var linq = from inquiry in session.Query<OrderSheet1>()
                       join customers in session.Query<MCustomer1>()
                       on inquiry.CustCode equals customers.CustCode
                       join inquiryObj in session.Query<OrderSheet2>()
                       on inquiry.OsNo equals inquiryObj.os_no
                       join shipmentDetails in session.Query<ShipmentDetailOs>() 
                       on inquiry.OsNo equals shipmentDetails.order_sheet1.OsNo
                       join inquirys in session.Query<GyTrans1>()
                       on inquiry.GyNo equals inquirys.gy_no.ToString()
                       join buyer in session.Query<MBuyer1>()
                       on inquiry.MBuyer1.buyer_code equals buyer.buyer_code
                       join ports in session.Query<MPorts>()
                       on shipmentDetails.m_ports.port_code equals ports.port_code
                       join lead in session.Query<Inquiry1>()
                       on Convert.ToInt32(inquiry.FactoryInquiry) equals lead.InquiryNo


                       where inquiry.OsNo == id

                       //select new OrderDTO
                       //{
                       //    CustomerName = customers.CustName,
                       //    Post = inquiry.Post,
                       //    sc_no = inquiry.ScNo,
                       //    BuyerName = buyer.buyer_name,
                       //    Remarks = inquiry.Remarks,
                       //    order_qty_pcs  = inquiryObj.order_qty_pcs,
                       //    buyer_code = inquiry.MBuyer1.buyer_code,
                       //    fabric_code= inquiryObj.fabric_code,
                       //    os_no = inquiryObj.os_no,
                       //    OrderSheet1revision_no = inquiry.RevisionNo,
                       //    OrderSheet2revision_no = inquiryObj.revision_no,
                       //    PoNo = inquiry.PoNo,
                       //    port_code = shipmentDetails.m_ports.port_code,
                       //    port_name = ports.port_name,
                       //    factory_inquiry = inquiry.FactoryInquiry,
                       //    item_sno = inquiryObj.item_sno,
                       //    shipment_qty = shipmentDetails.shipment_qty,
                       //    shipment_date_po = shipmentDetails.shipment_date_po.HasValue ? shipmentDetails.shipment_date_po.Value.ToShortDateString():"",
                       //    ApproveDate = lead.ApproveDate.HasValue ? lead.ApproveDate.Value.ToShortDateString():""




                       //    //pattern_master_id
                       //    //GyNo = inquiry.GyNo
                       //    // Post = inquiry.Post,
                       //    // CustomerName = customers.CustName,
                       //    //Quantity = inquiryObj.Quantity,
                       //    //Unit = inquiryObj.Unit,
                       //    //ProductDesc = productDesc.ProductDesc,
                       //    //ResponseCode = "Ok",
                       //    //InquireDate = inquiry.InquiryDate,
                       //    //StyleCode = 

                       //};


            group inquiryObj by new
            {
                 customers.CustName,
                 inquiry.Post,
                 inquiry.ScNo,
                 buyer.buyer_name,
                 inquiry.Remarks,
                 inquiryObj.order_qty_pcs,
                 inquiry.MBuyer1.buyer_code,
                 fabric_code= inquiryObj.fabric_code,
                 inquiryObj.os_no,
                 inquiry.RevisionNo,
                 inquiryObj.revision_no,
                 inquiry.PoNo,
                 shipmentDetails.m_ports.port_code,
                 ports.port_name,
                 inquiry.FactoryInquiry,
                 inquiryObj.item_sno,
                 shipmentDetails.shipment_qty,
                 shipmentDetails.shipment_date_po,
                 lead.ApproveDate,

                //inquiry.PostDate,
                //inquiry.InquiryNo,
                //inquiry.InquiryDate,
                //customers.CustName,
                //inquiry.CustCode,
                //productDesc.ProductDesc,
                //inquiryObj.Unit,
                //inquiry.Post,
                //inquiryObj.ShipDate,
                //inquiry.ValidityDate,
                //inquiryObj.QualityCode,
                //inquiryObj.OColorCode,


            } into g


                       select new OrderDTO
                       {
                          
                           Post = g.Key.Post,
                           sc_no = g.Key.ScNo.HasValue ?g.Key.ScNo.Value:0,
                           BuyerName = g.Key.buyer_name,
                           Remarks = g.Key.Remarks,
                           order_qty_pcs = g.Key.order_qty_pcs,
                           buyer_code = g.Key.buyer_code,
                           fabric_code = g.Key.fabric_code,
                           os_no = g.Key.os_no,
                           OrderSheet1revision_no = g.Key.RevisionNo,
                           OrderSheet2revision_no = g.Key.revision_no,
                           PoNo = g.Key.PoNo,
                           port_code = g.Key.port_code,
                           port_name = g.Key.port_name,
                           factory_inquiry = g.Key.FactoryInquiry,
                           item_sno = g.Key.item_sno,
                           shipment_qty = g.Key.shipment_qty,
                           shipment_date_po = g.Key.shipment_date_po.HasValue ? g.Key.shipment_date_po.Value.ToShortDateString() : "",
                           ApproveDate = g.Key.ApproveDate.HasValue ? g.Key.ApproveDate.Value.ToShortDateString() : ""

                       };



            var metaData = new
            {
                page = "1",
                pages = "1",
                perpage = "-1",
                total = "350",
                sort = "asc",
                field = "InquiryNo",
            };

            var Ans = new { meta = metaData, data = linq };

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.OK, Ans);
        }



        [HttpGet]
        public dynamic GetAllLeadsTesting()
        {

            ISession session = Helper.OpenSession();

            LeadDTO result = null;
          
            LeadDTO resultDTO = null;
            Student student = null;
            Course course = null;


            var linq = from inquiry in session.Query<Inquiry1>()
                       join customers in session.Query<MCustomer1>()
                       on inquiry.CustCode equals customers.CustCode
                       join inquiryObj in session.Query<Inquiry2>()
                       on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                       join productDesc in session.Query<MProductDesc>()
                       on customers.CustCode equals productDesc.CustCode
                       where inquiry.Post == "P"

                       select new LeadDTO
                       {
                           //InquiryNo = inquiry.InquiryNo,
                           //Post = inquiry.Post,
                           CustomerName = customers.CustName,
                           //Quantity = inquiryObj.Quantity,
                           //Unit = inquiryObj.Unit,
                           ProductDesc = productDesc.ProductDesc,
                           //ResponseCode = "Ok",
                           //InquireDate = inquiry.InquiryDate,

                       };

            Inquiry1 inquiry1Alias = null;
            Inquiry2 inquiry2Alias = null;
            MCustomer1 customer = null;
            MProductDesc products = null;


            

            var q = (from request in session.Query<OrderSheet1>()
                     join detail in session.Query<OrderSheet2>() on request.OsNo equals detail.os_no
                     join customers in session.Query<MCustomer1>() on request.CustCode equals customers.CustCode
                     //join GYTran in session.Query<GyTrans1>() on request.GyNo equals GYTran.gy_no
                     join shipmentDetails in session.Query<ShipmentDetailOs>() 
                     on request.OsNo equals shipmentDetails.order_sheet1.OsNo

                     select new OrderDTO
                     {
                      //   gy_no = GYTran.gy_no,
                         os_no = request.OsNo,
                         os_date =request.OsDate,
                         CustomerName = customers.CustName,
                         order_qty_pcs = detail.order_qty_pcs,
                         quality_code = detail.quality_code,
                         shipment_date_po = shipmentDetails.shipment_date_po.Value.ToShortDateString()
                         //Quantity = inquiryObj.Quantity,
                         //Unit = inquiryObj.Unit,
                         //ProductDesc = productDesc.ProductDesc,
                         //ResponseCode = "Ok",
                         //InquireDate = inquiry.InquiryDate,

                     });

            //select request).ToList();

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.OK, q.Count());

        }


        [HttpGet]
        public int InsertList(string value)
        {
            ISession session = Helper.OpenSession();

            Employees emp = new Employees();

            emp.Name = "Adam";
            emp.SurName = "Roy";
            session.Save(emp);
            session.Close();

            return 900;
        }


        [HttpGet]
        public dynamic TestService()
        {
            ISession session = Helper.OpenSession();

            Inquiry1 historyAlias = null;
            Inquiry2 historyAlias2 = null;
            MProductDesc productAlias = null;

            //IList<IDictionary> results = session.QueryOver<Inquiry1>(() => historyAlias)
            //    .JoinQueryOver(pr => pr.Inquiry2s, () => historyAlias2)
            //        //.Where(th => th.UserNo == 121)
            //    .TransformUsing(Transformers.AliasToEntityMap)
            //    //.Take(10)
            //    .List<IDictionary>();



            //   var a = session.Query<MProductDesc>().Select(
            //s => new LeadDTO
            //{
            //    InquiryNo = s.SerialNo,
            //    Post = s.ProductDesc
            //}
            //   ).ToList();




            //      session.Query<MProductDesc>.Where(i => i.Cancelled == false)
            //.GroupBy(i => i.Product)
            //.Select(g => new TopSellingProduct
            //{
            //    Product = g.Key,
            //    SaleCount = g.Count(),
            //    TotalValue = g.Sum(i => i.Value)
            //})
            //.OrderByDescending(g => g.TotalValue)
            //.Take(10);

            //var ret = session.Query<MProductDesc>().GroupBy(x => x.CustCode)
            //    select new LeadDTO {

            //    };



            var linq = from inquiry in session.Query<Inquiry1>()
                        join customers in session.Query<MCustomer1>() 
                        on inquiry.CustCode equals customers.CustCode 
                        join inquiryObj in session.Query<Inquiry2>() 
                        on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo into g
                        join productDesc in session.Query<MProductDesc>()
                        on inquiry.CustCode equals productDesc.CustCode
                        where inquiry.Post == "U"
                        select new LeadDTO

                                        {
                                               InquiryNo = inquiry.InquiryNo,
                                               //Count = g.Sum(x => (int)x.CustCode),
                                               Quantity = g.Sum(x => x.Quantity),
                                               InquireDate = inquiry.InquiryDate.Date.ToShortDateString(),
                                               //ProductDesc = productDesc.ProductDesc                           
 

                                        };


            //var query = from inquiry in session.Query<Inquiry1>()
            //            join inq in session.Query<Inquiry2>()
            //            on inquiry.InquiryNo equals inq.Inquiry1.InquiryNo 
            //            group new { inquiry, inq } by new { inquiry.InquiryNo } into g
            //            select new LeadDTO
            //            {
            //                 InquiryNo = g.Key.InquiryNo,
            //                 Quantity = (int)g.Sum(pt => pt.inq.Quantity),
            //                // Count = (int)g.Sum(pt => pt.p.Quantity),
            //                //Count = g.Select(x => x.c.CategoryID).Distinct().Count()
            //            };


            //var queryTest = from r in session.Query<Inquiry1>()
            //                join s in session.Query<Inquiry2>()
            //                    on r.InquiryNo equals s.Inquiry1.InquiryNo
            //                where r.Post == "U"
            //                group new { r, s } by new { r.InquiryNo, r.InquiryDate }
            //                into grp
                            
            //                select new LeadDTO
            //                {
            //                    //Count = grp.Count(),
            //                    InquiryNo=grp.Key.InquiryNo,
            //                    Quantity = grp.Sum(s => s.s.Quantity)
            //                    //InquireDate = grp.Key.InquiryDate.ToShortDateString()

            //                };


           

            

            var credit = from bm in session.Query<Inquiry1>()
                          join sms in session.Query<Inquiry2>() on bm.InquiryNo equals sms.Inquiry1.InquiryNo
                          join customer in session.Query<MCustomer1>() on bm.CustCode equals customer.CustCode
                         join productDesc in session.Query<MProductDesc>()
                         on bm.CustCode equals productDesc.CustCode
                         where bm.Post == "U"
                          group sms by new {  sms.Inquiry1 ,customer.CustCode ,bm.InquiryDate ,customer.CustName , productDesc.ProductDesc  } into g 
                          select new LeadDTO

                          {
                              InquiryNo =g.Key.Inquiry1.InquiryNo,
                              Quantity = g.Sum(s => s.Quantity),
                              CustomerName=g.Key.CustName,
                              InquireDate = g.Key.InquiryDate.ToShortDateString(),
                              ProductDesc = g.Key.ProductDesc
                              
                  
                          };
                          
                          



            //     var query1 = from stud in session.Query<Inquiry1>()
            //                  join ts in session.Query<Inquiry2>() on stud.InquiryNo equals ts.Inquiry1.InquiryNo
            //                 // into studts
            //                  //from p in studts
            //                  //join o in TimeRecords on p.TimeSheetId equals o.TimeSheetId
            //                  where stud.Post == "P"
            //                 // group sale.TotalDue by ad.City into g
            //                  group ts.Quantity by stud.InquiryNo into last

            //                  select new LeadDTO
            //                  {
            //                      InquiryNo = last.Key,
            //                      Quantity =  last.Sum()  
            //                  };


            //var results = from r in session.Query<Inquiry1>()
            //              join s in session.Query<Inquiry2>()
            //               on r.InquiryNo equals s.Inquiry1.InquiryNo
            //              group new { r, s } by new { r.InquiryNo } into g
            //              select new LeadDTO
            //              {
            //                               InquiryNo = g.Key.InquiryNo,
            //                                Quantity = (int)g.Sum(pt => pt.s.Quantity),
            //                  //                // Count = (int)g.Sum(pt => pt.p.Quantity),
            //                  //                //Count = g.Select(x => x.c.CategoryID).Distinct().Count()
            //              };
            //select new LeadDTO
            // {
            //     InquiryNo = StudentGroup.Key.InquiryNo,
            //     Quantity =  StudentGroup.Sum(StudentGroup.Key.InquiryNo)
            //     // Count = (int)g.Sum(pt => pt.p.Quantity),
            //     //Count = g.Select(x => x.c.CategoryID).Distinct().Count()
            // };



            var metaData = new
            {
                page = "1",
                pages = "1",
                perpage = "-1",
                total = credit.Count(),
                sort = "asc",
                field = "InquiryNo",
            };

            var Ans = new { meta = metaData, data = credit };

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            return Request.CreateResponse(HttpStatusCode.OK, Ans);
        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsMockGroup(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();



            if (dateTo.HasValue && dateFrom.HasValue)
            {

                var linq = from inquiry in session.Query<Inquiry1>()
                           join customers in session.Query<MCustomer1>()
                           on inquiry.CustCode equals customers.CustCode
                           join inquiryObj in session.Query<Inquiry2>()
                           on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                           join productDesc in session.Query<MProductDesc>()
                           on customers.CustCode equals productDesc.CustCode
                           where inquiry.Post == status || inquiry.InquiryDate.Date >= dateFrom.Value.Date && inquiry.InquiryDate.Date <= dateTo.Value.Date

                           select new LeadDTO
                           {
                               InquiryNo = inquiry.InquiryNo,
                               Post = inquiry.Post,
                               CustomerName = customers.CustName,
                               Quantity = inquiryObj.Quantity,
                               Unit = inquiryObj.Unit,
                               ProductDesc = productDesc.ProductDesc,
                               InquireDate = inquiry.InquiryDate.ToShortDateString()
                               //InquireDate = inquiry.InquiryDate
                               //ResponseCode = "Ok",
                               //InquireDate = inquiry.InquiryDate,

                           };


                //Group By


                LeadDTO result = null;
                Inquiry1 employee = null;
                Inquiry2 _inquiry2 = null;
                MCustomer1 customer = null;
                MProductDesc products = null;
                LeadDTO resultDTO = null;


                //var linq = from inquiry in session.Query<Inquiry1>()
                //           join customers in session.Query<MCustomer1>()
                //           on inquiry.CustCode equals customers.CustCode
                //           join inquiryObj in session.Query<Inquiry2>()
                //           on inquiry.InquiryNo equals inquiryObj.Inquiry1.InquiryNo
                //           join productDesc in session.Query<MProductDesc>();

                var groupedList = from inqObj in session.Query<Inquiry1>()
                                  group inqObj by new { inqObj.InquiryNo }
                                  into newGroup
                                  select new LeadDTO
                                  {
                                      InquiryNo = newGroup.Key.InquiryNo,
                                      //Count = newGroup.Count(),
                                      //Employees = newGroup
                                  };


                //  return incidentsByCode.ToList();


                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, linq);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }


        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsStatusWork(DateTime? dateTo, DateTime? dateFrom, string status)
        {

            ISession session = Helper.OpenSession();



            if (dateTo.HasValue && dateFrom.HasValue)
            {


            

                IQuery query = session.CreateSQLQuery(

 
                   "Select G.gy_no ,O.gy_no, *From order_sheet1 O"+
                   "Right Outer Join gy_trans1 G"+
                    "On O.gy_no = G.gy_no Where G.post='U'"
                           ).SetResultTransformer(Transformers.AliasToBean<LeadDTO>());

                //query.SetParameter("employee_number", EmployeeNumber);
                //query.SetParameter("appraisal_id", AppraisalPeriodId);
                ICollection<LeadDTO> linq = query.List<LeadDTO>();
                

                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, linq);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }

        [HttpGet]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public dynamic GetAllLeadsStatusWork()
        {

            ISession session = Helper.OpenSession();



            if (session!=null)
            {


 

                var linq = from inquiry in session.Query<Inquiry1>().DefaultIfEmpty()

                           join customers in session.Query<MCustomer1>() 
                           on inquiry.CustCode equals customers.CustCode
                           
                           where inquiry.Post == "U"
 
                           select new LeadDTO
                           {
                               InquiryNo = inquiry.InquiryNo,
                               CustomerName = customers.CustName

                           };


                var metaData = new
                {
                    page = "1",
                    pages = "1",
                    perpage = "-1",
                    total = linq.Count(),
                    sort = "asc",
                    field = "InquiryNo",
                };

                var Ans = new { meta = metaData, data = linq };


                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
                return Request.CreateResponse(HttpStatusCode.OK, linq);
            }
            else
            {

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.BadRequest);
                return Request.CreateResponse(HttpStatusCode.OK, "No Records found");

            }


        }










    }
}
