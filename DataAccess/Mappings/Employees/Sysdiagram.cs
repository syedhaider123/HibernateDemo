using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class Sysdiagram {
        public Sysdiagram() { }
        public virtual int DiagramId { get; set; }
        public virtual string Name { get; set; }
        public virtual int PrincipalId { get; set; }
        public virtual System.Nullable<int> Version { get; set; }
        public virtual byte[] Definition { get; set; }
    }
}
