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
    
    public partial class cce_actual_progress
    {
        public int id { get; set; }
        public string name { get; set; }
        public string progresskey { get; set; }
        public string data { get; set; }
        public Nullable<int> queue { get; set; }
        public Nullable<int> cropacreage { get; set; }
        public string user { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
    }
}