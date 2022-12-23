using System.Text;

namespace LCD
{
    public class LcdNumbers
    {

        private static readonly string[][] Numbers =
        {
            new string[] 
            {
                " _ ",
                "| |",
                "|_|"
            },
            new string[] 
            {
                "  ",
                " |",
                " |"
            },
            new string[] 
            {
                " _ ",
                " _|",
                "|_ "
            },
            new string[] 
            {
                " _ ",
                " _|",
                " _|"
            },
            new string[]
            {
                "   ",
                "|_|",
                "  |"
            },
            new string[] 
            {
                " _ ",
                "|_ ",
                " _|"
            },
            new string[]
            {
                " _ ",
                "|_ ",
                "|_|"
            },
            new string[]
            {
                " _ ",
                "  |",
                "  |"
            },
            new string[]
            {
                " _ ",
                "|_|",
                "|_|"
            },
            new string[]
            {
                " _ ",
                "|_|",
                " _|"
            }
        };

        // 7seg lcd
        //  - 
        // | |
        //  -
        // | |
        //  -
        
        public static string Show(int number)
        {
            var strNum = number.ToString();

            var digits = new List<string[]>();
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
                    result.Append(digit[i]);
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