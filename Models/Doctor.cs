using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string DoctorName { get; set; } = null!;

        public virtual ICollection<Event> Events { get; set; } = new List<Event>();
    }
}