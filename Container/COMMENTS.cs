//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Container
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMMENTS
    {
        public int ID { get; set; }
        public Nullable<int> SiteID { get; set; }
        public Nullable<int> SenderID { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Status { get; set; }
        public string Date { get; set; }
    
        public virtual SITE SITE { get; set; }
    }
}
