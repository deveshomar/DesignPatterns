using DesignPattern_Strategy.Model;

namespace DesignPattern_Strategy.ValidationWithStrategy
{
    public class BusinessUser
    {
        public class BusinessUserValidationStrategy : IValidationStrategy
        {
            public List<string> Validate(UserRegistrationRequest request)
            {
                var errors = new List<string>();

                if (string.IsNullOrWhiteSpace(request.CompanyName))
                    errors.Add("Company name is required.");
                if (string.IsNullOrWhiteSpace(request.RegistrationNumber))
                    errors.Add("Business registration number is required.");
                if (!request.Email.Contains("@") || request.Email.Contains("gmail.com"))
                    errors.Add("Business email is required (no free email domains).");

                return errors;
            }
        }
    }
}
