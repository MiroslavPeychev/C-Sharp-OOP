namespace P04.Telephony
{
    using System.Linq;

    public class Smartphone : ICaller, IBrowser
    {

        public string Call(string phoneNumber)
        {
            if (phoneNumber.All(x => char.IsLetter(x)))
            {
                return "Invalid number!";
            }

            return $"Calling... {phoneNumber}";
        }

        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }
    }
}