namespace MyApi.Services
{
    public class ValidName : IValidName
    {
        public bool isValid(string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }
    }
}
