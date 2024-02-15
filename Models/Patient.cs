using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Firstname { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Surname { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Lastname { get; set; } = null!;
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string PassportSeriesAndNumber { get; set; } = null!;
        public DateOnly BirthDate { get; set; }
        public string Gender { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string Address { get; set; } = null!;
        [Required]
        [StringLength(12, MinimumLength = 12)]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 6)]
        public string Email { get; set; } = null!;
        public string MedicalCard { get; set; } = null!;
        [Required]
        public int InsurancePolicy { get; set; }
        public DateOnly InsurancePolicyExpireDate { get; set; }

        public virtual ICollection<Event> Events { get; set; } = new List<Event>();

        public virtual MedicalCard MedicalCardNavigation { get; set; } = null!;
    }
}
