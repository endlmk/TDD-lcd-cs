using System.Text;

namespace LCD
{
    public static class LcdNumbers
    {
        // 7seg lcd
        //   -H1   <- partH1
        //V1| |V2  <- partV12 * height
        //   -H2   <- partH2
        //V3| |V4  <- partV34 * height
        //   -H3   <- partH3

        enum SegPart
        {
            V1,
            V2,
            V3,
            V4,
            H1,
            H2,
            H3,
        }
        private const SegPart V1 = SegPart.V1;
        private const SegPart V2 = SegPart.V2;
        private const SegPart V3 = SegPart.V3;
        private const SegPart V4 = SegPart.V4;
        private const SegPart H1 = SegPart.H1;
        private const SegPart H2 = SegPart.H2;
        private const SegPart H3 = SegPart.H3;

        private static readonly List<SegPart>[] SegComponentList =
        {
            new() { H1, V1, V2, V3, V4, H3 },
            new() { V2, V4},
            new() { H1, V2, H2, V3, H3 },
            new() { H1, V2, H2, V4, H3 },
            new() { V1, V2, H2, V4 },
            new() { H1, V1, H2, V4, H3 },
            new() { H1, V1, H2, V3, V4, H3 },
            new() { H1, V2, V4 },
            new() { H1, V1, V2, H2, V3, V4, H3 },
            new() { H1, V1, V2, H2, V4, H3 },
        };


        public static string Show(int number, int width = 1, int height = 1)
        {
            var strNum = number.ToString();

            var digits = new List<int>();
            foreach (var c in strNum)
            {
                var i = c - '0';
                digits.Add(i);
            }

            // map number chars
            var lcdCharsList = digits.Select(x => ToLcdChars(x, width, height)).ToList();
            
            // concat each number chars
            var result = new StringBuilder();
            var rows = lcdCharsList.First().Count;
            for (var i = 0; i < rows; ++i)
            {
                result.Append(lcdCharsList.Aggregate(new StringBuilder(), (added, next) => added.Append(next[i])));
 
                if (i != rows - 1)
                {
                    result.Append(Environment.NewLine);
                }
            }

            return result.ToString();
        }

        private static List<String> ToLcdChars(int n, int width, int height)
        {
            var component = SegComponentList[n];

            var result = new List<String> { CreatePartH(width, component, H1) };
            result.AddRange(Enumerable.Repeat(CreatePartV(width, component, V1, V2), height));
            result.Add(CreatePartH(width, component, H2));
            result.AddRange(Enumerable.Repeat(CreatePartV(width, component, V3, V4), height));
            result.Add(CreatePartH(width, component, H3));

            return result;
        }


        private static string CreatePartH(int width, List<SegPart> component, SegPart p)
        {
            return ' ' + 
                   new string(component.Contains(p) ? '-' : ' ', width) +
                   ' ';
        }

        private static string CreatePartV(int width, List<SegPart> component, SegPart p1, SegPart p2)
        {
            return (component.Contains(p1) ? '|' : ' ') +
                   new string(' ', width) +
                   (component.Contains(p2) ? '|' : ' ');
        }
    }
}