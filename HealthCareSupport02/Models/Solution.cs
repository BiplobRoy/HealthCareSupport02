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

    public partial class Solution
    {
        public int Id { get; set; }

        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }

        [Display(Name = "Patient")]
        public int PatientId { get; set; }


        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Problem Name")]
        public string ProblemName { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 4)]
        [Display(Name = "Prescription")]
        public string Solution1 { get; set; }

        [Display(Name = "Test No 1")]
        public string File1 { get; set; }

        [Display(Name = "Test No 2")]
        public string File2 { get; set; }

        [Display(Name = "Test No 3")]
        public string File3 { get; set; }

        [Display(Name = "Test No 4")]
        public string File4 { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}