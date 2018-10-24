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
    
    public partial class early_warning
    {
        public int id { get; set; }
        public Nullable<int> county { get; set; }
        public Nullable<int> sub_county { get; set; }
        public Nullable<int> month { get; set; }
        public Nullable<int> season { get; set; }
        public Nullable<int> crop { get; set; }
        public Nullable<int> crop_growth_stage { get; set; }
        public Nullable<int> rainfall_performance { get; set; }
        public Nullable<int> achieved_acreage { get; set; }
        public Nullable<int> time_of_planting { get; set; }
        public Nullable<int> crop_condition { get; set; }
        public Nullable<int> water_availability { get; set; }
        public Nullable<int> expected_yield_compared_to_LTA { get; set; }
        public Nullable<int> foodstocks_available_compared_toNormal { get; set; }
    
        public virtual county county1 { get; set; }
        public virtual season season1 { get; set; }
        public virtual subcounty subcounty { get; set; }
    }
}