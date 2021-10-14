using System;

namespace UserRegistrationUsingAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to User Registration*****");
            ValidateUserFields validateUserFields = new ValidateUserFields();
            validateUserFields.ValidateUser();
        }
    }
}
