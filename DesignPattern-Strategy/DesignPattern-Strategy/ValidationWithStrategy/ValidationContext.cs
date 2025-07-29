using DesignPattern_Strategy.Model;
using static DesignPattern_Strategy.ValidationWithStrategy.BusinessUser;
using static DesignPattern_Strategy.ValidationWithStrategy.IndividualUser;

namespace DesignPattern_Strategy.ValidationWithStrategy
{
    public class ValidationContext
    {
        private readonly Dictionary<string, IValidationStrategy> _strategies;

        public ValidationContext()
        {
            _strategies = new Dictionary<string, IValidationStrategy>
        {
            { "Individual", new IndividualUserValidationStrategy() },
            { "Business", new BusinessUserValidationStrategy() }
        };
        }

        public List<string> Validate(UserRegistrationRequest request)
        {
            if (_strategies.TryGetValue(request.UserType, out var strategy))
            {
                return strategy.Validate(request);
            }

            return new List<string> { "Unsupported user type." };
        }
    }
}
