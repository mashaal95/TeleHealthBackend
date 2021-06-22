using System;
using System.ComponentModel.DataAnnotations;

namespace TelstraAPI.Models
{
    public class Patient
    {
        [Required]
        public Guid PatientID { get; set; }

        [Required]
        public String FirstName { get; set; }

        [Required]
        public String LastName { get; set; }

        [Required]
        public String PhoneNum { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required]
        public String BloodType { get; set; }
    }
}