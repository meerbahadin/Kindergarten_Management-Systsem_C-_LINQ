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
    
    public partial class tbl_child_healthy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_child_healthy()
        {
            this.tbl_disease_assignment = new HashSet<tbl_disease_assignment>();
        }
    
        public decimal id { get; set; }
        public decimal id_child { get; set; }
        public Nullable<decimal> id_child_disease_type { get; set; }
        public string drug_allergy { get; set; }
        public string darmany_naxoshiya_drezhxayanaka { get; set; }
        public Nullable<bool> have_surgery { get; set; }
        public string note_of_surgery { get; set; }
        public string general_clinic_test_disease_type_note { get; set; }
        public string general_clinic_test_disease_type { get; set; }
        public string face_type { get; set; }
        public string child_height { get; set; }
        public string child_weight { get; set; }
        public string food_eating_type { get; set; }
        public Nullable<decimal> id_user_save { get; set; }
        public Nullable<System.DateTime> datetime_save { get; set; }
        public Nullable<decimal> id_user_update { get; set; }
        public Nullable<System.DateTime> datetime_update { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_disease_assignment> tbl_disease_assignment { get; set; }
    }
}
