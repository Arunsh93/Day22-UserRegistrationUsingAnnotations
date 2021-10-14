using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistrationUsingAnnotation
{
    class UserAnnotationFields
    {
        //Validation First name filed using Annotations

        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name should be Minimum 3 CHaracters")]
        [RegularExpression(@"^[A-Z]{1}[a-zA-Z]{3,}$", ErrorMessage = "First Name is InValid")]
        [DataType(DataType.Text)]
        public string firstName { get; set; }
    }
}
