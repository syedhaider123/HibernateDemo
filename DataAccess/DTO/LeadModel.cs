using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class LeadModel
    {
        [JsonProperty(PropertyName = "headers")]
        public Headers Headers { get; set; }
        [JsonProperty(PropertyName = "results")]
        public List<LeadDTO>  Data { get; set; }
    }

  
}
