namespace RegExercise
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = System.Console.ReadLine();
            string patern = @"([\w-.]+\@[A-Za-z-.]+)(\.[A-Za-z]+)+";
            Regex email = new Regex(patern);
            MatchCollection matches = email.Matches(input);
            foreach (Match match in matches)
            {
                string matchString = match.ToString();
                if (!matchString.StartsWith("-")
                    || matchString.StartsWith("_")
                    || matchString.StartsWith(".")
                    || matchString.EndsWith("-")
                    || matchString.EndsWith("_")
                    || matchString.EndsWith(".")
                    || matchString.EndsWith("0")
                    || matchString.EndsWith("1")
                    || matchString.EndsWith("2")
                    || matchString.EndsWith("3")
                    || matchString.EndsWith("4")
                    || matchString.EndsWith("5")
                    || matchString.EndsWith("6")
                    || matchString.EndsWith("7")
                    || matchString.EndsWith("8")
                    || matchString.EndsWith("9")
                    || matchString.StartsWith("0")
                    || matchString.StartsWith("1")
                    || matchString.StartsWith("2")
                    || matchString.StartsWith("3")
                    || matchString.StartsWith("4")
                    || matchString.StartsWith("5")
                    || matchString.StartsWith("6")
                    || matchString.StartsWith("7")
                    || matchString.StartsWith("8")
                    || matchString.StartsWith("9"))
                {
                    System.Console.WriteLine(matchString);
                }
            }
        }
    }
}
