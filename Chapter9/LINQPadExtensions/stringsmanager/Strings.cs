using System.Linq;

namespace LINQPad.stringsmanager
{
    public static class Strings
    {

        public static string Proper(this string inputString)
        {
            if (inputString == string.Empty) return string.Empty;

            if (inputString.Contains(" "))
            {
                var result = string.Empty;
                var wordsList = inputString.Split(' ');
                result = wordsList.Aggregate(result, (current, word) => current + (word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " "));
                return result.Trim();
            }

            return inputString.Substring(0, 1).ToUpper() + inputString.Substring(1).ToLower();
        }

    }
}
