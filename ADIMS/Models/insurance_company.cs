//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADIMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class insurance_company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public insurance_company()
        {
            this.farm_policy = new HashSet<farm_policy>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string initials { get; set; }
        public string krapin { get; set; }
        public string distribution_channel { get; set; }
        public string channel_name { get; set; }
        public string phoneno { get; set; }
        public string email { get; set; }
        public string postal_address { get; set; }
        public string town { get; set; }
        public string physical_address { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<farm_policy> farm_policy { get; set; }
    }
}
