using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HelloCorona.Models
{
    public class Student
    {
        [DisplayName("Rollnumber")]
        public string RollNumber { get; set; }
        [DisplayName("Full name")]
        [Required(ErrorMessage = "Vui long nhap full name.")]
        public string FullName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Confirm password is not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DisplayFormat(DataFormatString = "yyyy-MM-dd")]
        public DateTime Birthday { get; set; }

        public EnumGender Gender { get; set; }

        public int Age { get; set; }

        public enum EnumGender
        {
            MALE = 1,
            FEMALE = 2,
            OTHER = 3
        }
    }
}