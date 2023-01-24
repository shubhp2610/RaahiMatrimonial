using System;
using System.ComponentModel.DataAnnotations;

namespace MatrimonyMVC.Models
{
    public class RegisterModel
    {
        public string ProfileFor { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Religion { get; set; }

        public string Email { get; set; }

        public string Education { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string MobileNo { get; set; }
    }
}