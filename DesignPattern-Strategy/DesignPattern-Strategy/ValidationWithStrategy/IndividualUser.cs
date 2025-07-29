using DesignPattern_Strategy.Model;

namespace DesignPattern_Strategy.ValidationWithStrategy
{
    public class IndividualUser
    {
        public class IndividualUserValidationStrategy : IValidationStrategy
        {
            public List<string> Validate(UserRegistrationRequest request)
            {
                var errors = new List<string>();

                if (string.IsNullOrWhiteSpace(request.FullName))
                    errors.Add("Full name is required.");
                if (request.Age < 18)
                    errors.Add("User must be at least 18 years old.");
                if (!request.Email.Contains("@"))
                    errors.Add("Valid email is required.");

                return errors;
            }
        }
    }
}
