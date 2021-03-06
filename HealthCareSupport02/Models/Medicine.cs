//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthCareSupport02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Medicine
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Medicine Name")]
        public string Name { get; set; }

        [Display(Name = "Medicine Group")]
        public int MedicineGroupId { get; set; }

        [Display(Name = "Company")]
        public int CompanyId { get; set; }
        public string Details { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual MedicineGroup MedicineGroup { get; set; }
    }
}
