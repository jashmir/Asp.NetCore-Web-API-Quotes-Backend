//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIQuotesBackend.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quote
    {
        public int QuoteID { get; set; }
        public string QuoteType { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<decimal> Premium { get; set; }
        public string Sales { get; set; }
    }
}
