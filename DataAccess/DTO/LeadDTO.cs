using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LeadDTO
    {
        public LeadDTO()
        {

        }

 

        public int InquiryNo { get; set; }
        
        public Decimal Quantity { get; set  ; }

        public Decimal UnitPrice { get; set; }

        public string QualityCode { get; set; }

        public string ColorCode { get; set; }

        public string PatternCode { get; set; }

        public string StyleCode { get; set; }

        public string Post { get; set; }

        public string Status { get; set; }

        public string Remarks { get; set; }

        public string PostStatus { get; set; }

        public string PostDate { get; set; }

        public short CustCode { get; set; }
       
        public byte Unit { get; set; }
        
        public string CustomerName { get; set; }

        public string UnitName { get; set; }

        public int gy_no { get; set; }

        public int sc_no { get; set; }


        public string InquireDate { get; set; }

        public string GYDate { get; set; }

        public string ValidityDate { get; set; }
        
        public string LeadTime { get; set; }

        public string ShipDate { get; set; }
        [JsonIgnore]
        public int Count { get; set; }
        
         
        //public DateTime InquireDate
        //{
        //    get
        //    {

        //        DateTime inquireDateTimeSpan = this.InquireDate.Date;
        //        return inquireDateTimeSpan;

        //    }
        //    set {; }
        //}

        public string ProductDesc { get; set; }
        [JsonIgnore]
        public string ResponseCode { get; set; }
       
        
        //public string LeadInformation { get; set; }
        //public string Inquired { get; set; }
    }

    public class Headers
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "error_message")]
        public string Errormessage { get; set; }
        [JsonProperty(PropertyName = "warnings")]
        public string Warnings { get; set; }
        [JsonProperty(PropertyName = "results_count")]
        public string ResultsCount { get; set; }
    }



}
