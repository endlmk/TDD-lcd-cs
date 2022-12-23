using System.Text;

namespace LCD
{
    public class LcdNumbers
    {
        // 7seg lcd
        //  -1   <- partH1
        //1| |2  <- partV12 * height
        //  -2   <- partH2
        //3| |4  <- partV34 * height
        //  -3   <- partH3
        
        // 1 -> [V:[2, 4], H:[]]
        // 2 -> [V:[2, 3], H:[1, 2, 3]]


        public static string Show(int number, int width = 1, int height = 1)
        {
            var strNum = number.ToString();

            var digits = new List<int>();
            foreach (var c in strNum)
            {
                var i = c - '0';
                digits.Add(i);
            }

            int rows = height * 2 + 3;

            // map number chars
            var lcdCharsList = digits.Select(x => ToLcdChars(x, width, height));

            // concat each number chars
            var result = new StringBuilder();
            for (var i = 0; i < rows; ++i)
            {
                result.Append(lcdCharsList.Aggregate(new StringBuilder(), (added, next) => added.Append(next[i])).ToString());
 
                if (i != rows - 1)
                {
                    result.Append(Environment.NewLine);
                }
            }

            return result.ToString();
        }

        private static List<String> ToLcdChars(int n, int width, int height)
        {
            Dictionary<char, List<int>> numConstruct = null;
            if (n == 1)
            {
                numConstruct = new Dictionary<char, List<int>>
                {
                    { 'V', new List<int> { 2, 4 } },
                    { 'H', new List<int>() },
                };
            }
            else if(n == 2)
            {
                numConstruct = new Dictionary<char, List<int>>
                {
                    { 'V', new List<int> { 2, 3 } },
                    { 'H', new List<int> { 1, 2, 3 } },
                };
            }

            var partH1 = ' ' + new string((numConstruct['H'].Contains(1) ? '-' : ' '), width) + ' ';
            var partV12 = (numConstruct['V'].Contains(1) ? '|' : ' ') + new string(' ', width) +
                          (numConstruct['V'].Contains(2) ? '|' : ' ');
            var partH2 = ' ' + new string((numConstruct['H'].Contains(2) ? '-' : ' '), width) + ' ';

            var partV34 = (numConstruct['V'].Contains(3) ? '|' : ' ') + new string(' ', width) +
                          (numConstruct['V'].Contains(4) ? '|' : ' ');
            var partH3 = ' ' + new string((numConstruct['H'].Contains(3) ? '-' : ' '), width) + ' ';

            var result = new List<String>();

            result.Add(partH1);
            for (var i = 0; i < height; i++)
            {
                result.Add(partV12);
            }
            result.Add(partH2);
            for (var i = 0; i < height; i++)
            {
                result.Add(partV34);
            }
            result.Add(partH3);

            return result;
        }
    }
}