using System.Text;

namespace LCD
{
    public class LcdNumbers
    {
        private const string Zero = " _ \r\n" +
                                    "| |\r\n" +
                                    "|_|";

        private const string One = "  \r\n" +
                                   " |\r\n" +
                                   " |";

        private const string Two = " _ \r\n" +
                                   " _|\r\n" +
                                   "|_ ";

        private const string Three = " _ \r\n" +
                                     " _|\r\n" +
                                     " _|";

        private const string Four = "   \r\n" +
                                    "|_|\r\n" +
                                    "  |";


        private const string Five = " _ \r\n" +
                                    "|_ \r\n" +
                                    " _|";

        private const string Six = " _ \r\n" +
                                   "|_ \r\n" +
                                   "|_|";

        private const string Seven = " _ \r\n" +
                                     "  |\r\n" +
                                     "  |";

        private const string Eight = " _ \r\n" +
                                     "|_|\r\n" +
                                     "|_|";

        private const string Nine = " _ \r\n" +
                                    "|_|\r\n" +
                                    " _|";

        private static readonly string[] Numbers = new string[] { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine };

        public static string Show(int number)
        {
            var strNum = number.ToString();

            var digits = new List<string>();
            foreach (var c in strNum)
            {
                var i = c - '0';
                digits.Add(Numbers[i]);
            }

            var result = new StringBuilder();
            for (var i = 0; i < 3; ++i)
            {
                foreach (var digit in digits)
                {
                    result.Append(digit.Split(Environment.NewLine)[i]);
                }

                if (i != 2)
                {
                    result.Append(Environment.NewLine);
                }
            }

            return result.ToString();
        }
    }
}