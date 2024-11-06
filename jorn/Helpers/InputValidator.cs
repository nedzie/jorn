using System.Text.RegularExpressions;

namespace jorn.Helpers
{
    public static class InputValidator
    {
        private const string _correctPattern = "^(?:[01][0-9]|2[0-3])[0-5][0-9]$";
        private readonly static Regex _inputValidator = new Regex(_correctPattern);

        public static bool IsValid(string[] args)
        {
            if (args.Length is not 3)
            {
                return false;
            }

            for (int i = 0; i < 3; i++)
            {
                if (!_inputValidator.IsMatch(args[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
