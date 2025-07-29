using DesignPattern_Strategy.Model;

namespace DesignPattern_Strategy.ValidationLogic
{
    public class RegistrationService
    {
        public List<string> Validate(UserRegistrationRequest request)
        {
            var errors = new List<string>();

            if (request.UserType == "Individual")
            {
                if (string.IsNullOrEmpty(request.FullName))
                    errors.Add("Full name is required.");
                if (request.Age < 18)
                    errors.Add("User must be at least 18 years old.");
            }
            else if (request.UserType == "Business")
            {
                if (string.IsNullOrEmpty(request.CompanyName))
                    errors.Add("Company name is required.");
                if (string.IsNullOrEmpty(request.RegistrationNumber))
                    errors.Add("Registration number is required.");
            }

            return errors;
        }
    }

}
