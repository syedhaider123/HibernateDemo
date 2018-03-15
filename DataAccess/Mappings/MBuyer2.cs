using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class MBuyer2 {
        public virtual short person_code { get; set; }
        public virtual MBuyer1 m_buyer1 { get; set; }
        public virtual string gender { get; set; }
        public virtual string person_name { get; set; }
        public virtual string designation { get; set; }
    }
}
