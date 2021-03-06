using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistrationUsingAnnotation
{
    class ValidateUserFields
    {
        public string message;
        UserAnnotationFields annotationFields = new UserAnnotationFields();

        public ValidateUserFields(string message)
        {
            this.message = message;
        }
        public ValidateUserFields()
        {

        }

        public void ValidateUser()
        {
            //Read the user input fields and store it into the object

            Console.WriteLine("Enter First Name: ");
            annotationFields.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            annotationFields.lastName = Console.ReadLine();

            Console.WriteLine("Enter EmailId: ");
            annotationFields.emailId = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            annotationFields.phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter The Password: ");
            annotationFields.password = Console.ReadLine();
            ValidateUserAnnotationFields();
        }

        public void ValidateUserAnnotationFields()
        {
            //Validate the Object
            ValidationContext validationContext = new ValidationContext(annotationFields);

            //List of Error Messages
            List<ValidationResult> validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(annotationFields, validationContext, validationResults, true);

            if(!isValid)
            {
                //if invalid Print Error message
                foreach(ValidationResult errorMessage in validationResults)
                {
                    Console.WriteLine(errorMessage.ErrorMessage);
                }
            }
        }
    }
}
