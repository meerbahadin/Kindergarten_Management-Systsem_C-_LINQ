//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kindergarten2
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_disease_assignment
    {
        public decimal id { get; set; }
        public decimal id_disease_type { get; set; }
        public decimal id_child_healthy { get; set; }
        public string rightt { get; set; }
        public string leftt { get; set; }
        public string note { get; set; }
        public Nullable<decimal> id_user_save { get; set; }
        public Nullable<System.DateTime> datetime_save { get; set; }
        public Nullable<decimal> id_user_update { get; set; }
        public Nullable<System.DateTime> datetime_update { get; set; }
    
        public virtual tbl_child_healthy tbl_child_healthy { get; set; }
        public virtual tbl_user tbl_user { get; set; }
        public virtual tbl_user tbl_user1 { get; set; }
    }
}