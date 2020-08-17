using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MarioApp
{
    class VsoftContract
    {
        public string Id { get; set; }
        public string A010 { get; set; }        
        public string Vs99 { get; set; }
        public string Vs98 { get; set; }
        public string V164 { get; set; }
        public string V165 { get; set; }
        public string Aw2 { get; set; }
        public string A325 { get; set; }
        public string A600 { get; set; }
        public string Vs97 { get; set; }
        public string B010 { get; set; }
        public string B014 { get; set; }
        public string V166 { get; set; }
        public string V223 { get; set; }
        public string Vs96 { get; set; }
        public string V167 { get; set; }
        public decimal? DecB010 { get; set; }
        public decimal? DecB014 { get; set; }
        // TODO!!!!!!!!!!!
        public string Dece069 { get; set; }
        public string E069 { get; set; }
        public string E070 { get; set; }
        public string E071 { get; set; }
        public string E072 { get; set; }
        
        public virtual VsoftCustomer VsoftCustomer { get; set; } // important for ON DELETE CASCADE when Customer is deleted        
        public string VsoftCustomerId { get; internal set; } // A110 in mdv database
        public virtual ICollection<VsoftTelebibContract> VsoftTelebibContracts { get; set; }                
    }
}
