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
    
    public partial class govt_subsidized_fertilizer
    {
        public int id { get; set; }
        public Nullable<int> county { get; set; }
        public Nullable<int> sub_county { get; set; }
        public Nullable<int> month { get; set; }
        public Nullable<int> season { get; set; }
        public string subsidized_fertilizer { get; set; }
        public Nullable<double> total_bags_available_toDate { get; set; }
        public Nullable<double> total_bags_issued { get; set; }
        public Nullable<int> total_beneficiary_farmers { get; set; }
    
        public virtual county county1 { get; set; }
        public virtual season season1 { get; set; }
        public virtual subcounty subcounty { get; set; }
    }
}