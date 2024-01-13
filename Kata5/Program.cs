using System.Text.RegularExpressions;

namespace Kata5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool ValidatePin(string pin)
        {
            if (pin.Length == 4 || pin.Length == 6)
            {
                foreach (char character in pin)
                {
                    if (!char.IsDigit(character))
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
