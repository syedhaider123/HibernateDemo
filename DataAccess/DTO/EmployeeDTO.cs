using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDTO
    {
        public EmployeeDTO()
        {

        }

        public  int Empid { get; set; }
        public  string Name { get; set; }
        public  string Surname { get; set; }
        public  string Post { get; set; }
    }



}
