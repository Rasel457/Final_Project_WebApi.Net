//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int id { get; set; }
        public int service_id { get; set; }
        public string comment1 { get; set; }
        public int user_id { get; set; }
    
        public virtual Service Service { get; set; }
        public virtual User User { get; set; }
    }
}
