namespace DesignPattern_Strategy.Model
{
    public interface IValidationStrategy
    {
        List<string> Validate(UserRegistrationRequest request);
    }
    public class UserRegistrationRequest
    {
        public string UserType { get; set; } // "Individual", "Business"
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string RegistrationNumber { get; set; }
    }
}
