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
    
    public partial class tbl_employee
    {
        public decimal id { get; set; }
        public string employee_fullname { get; set; }
        public string employee_gender { get; set; }
        public string employee_job_title { get; set; }
        public Nullable<decimal> salary { get; set; }
        public string employee_phone { get; set; }
        public Nullable<decimal> id_user_save { get; set; }
        public Nullable<System.DateTime> datetime_save { get; set; }
        public Nullable<decimal> id_user_update { get; set; }
        public Nullable<System.DateTime> datetime_update { get; set; }
    
        public virtual tbl_user tbl_user { get; set; }
        public virtual tbl_user tbl_user1 { get; set; }
    }
}
