using LCD;

namespace TDD_lcd_cs
{
    public class LCDTest
    {
        [Fact]
        public void CanShowOneDigitFor1Width1Height()
        {
            const string one = "   \r\n" +
                               "  |\r\n" +
                               "   \r\n" +
                               "  |\r\n" +
                               "   ";

            Assert.Equal(one, LcdNumbers.Show(1));

            const string two = " - \r\n" +
                               "  |\r\n" +
                               " - \r\n" +
                               "|  \r\n" +
                               " - ";

            Assert.Equal(two, LcdNumbers.Show(2));

            const string three = " - \r\n" +
                                 "  |\r\n" +
                                 " - \r\n" +
                                 "  |\r\n" +
                                 " - ";

            Assert.Equal(three, LcdNumbers.Show(3));

            const string four = "   \r\n" +
                                "| |\r\n" +
                                " - \r\n" +
                                "  |\r\n" +
                                "   ";

            Assert.Equal(four, LcdNumbers.Show(4));

            const string five = " - \r\n" +
                                "|  \r\n" +
                                " - \r\n" +
                                "  |\r\n" +
                                " - ";

            Assert.Equal(five, LcdNumbers.Show(5));

            const string six = " - \r\n" +
                               "|  \r\n" +
                               " - \r\n" +
                               "| |\r\n" +
                               " - ";

            Assert.Equal(six, LcdNumbers.Show(6));

            const string seven = " - \r\n" +
                                 "  |\r\n" +
                                 "   \r\n" +
                                 "  |\r\n" +
                                 "   ";

            Assert.Equal(seven, LcdNumbers.Show(7));

            const string eight = " - \r\n" +
                                 "| |\r\n" +
                                 " - \r\n" +
                                 "| |\r\n" +
                                 " - ";

            Assert.Equal(eight, LcdNumbers.Show(8));

            const string nine = " - \r\n" +
                                "| |\r\n" +
                                " - \r\n" +
                                "  |\r\n" +
                                " - ";

            Assert.Equal(nine, LcdNumbers.Show(9));

            const string zero = " - \r\n" +
                                "| |\r\n" +
                                "   \r\n" +
                                "| |\r\n" +
                                " - ";

            Assert.Equal(zero, LcdNumbers.Show(0));
        }
        
        [Fact]
        public void CanShowTwoOrMoreDigits()
        {
            const string twelve = "    - \r\n" +
                                  "  |  |\r\n" +
                                  "    - \r\n" +
                                  "  ||  \r\n" +
                                  "    - ";

            Assert.Equal(twelve, LcdNumbers.Show(12));

            const string allDigits = "    -  -     -  -  -  -  -  - \r\n" +
                                     "  |  |  || ||  |    || || || |\r\n" +
                                     "    -  -  -  -  -     -  -    \r\n" +
                                     "  ||    |  |  || |  || |  || |\r\n" +
                                     "    -  -     -  -     -  -  - ";
            Assert.Equal(allDigits, LcdNumbers.Show(1234567890));

        }

        [Fact]
        public void CanShowWidth3Height2()
        {
            const string two = " --- \r\n" +
                               "    |\r\n" +
                               "    |\r\n" +
                               " --- \r\n" +
                               "|    \r\n" +
                               "|    \r\n" +
                               " --- ";

            Assert.Equal(two, LcdNumbers.Show(2, 3, 2));

            const string thirty = " ---  --- \r\n" +
                                  "    ||   |\r\n" +
                                  "    ||   |\r\n" +
                                  " ---      \r\n" +
                                  "    ||   |\r\n" +
                                  "    ||   |\r\n" +
                                  " ---  --- ";

            Assert.Equal(thirty, LcdNumbers.Show(30, 3, 2));
        }

        [Fact]
        public void CanShowWidth5Height3()
        {
            const string eight = " ----- \r\n" + 
                                 "|     |\r\n" +
                                 "|     |\r\n" +
                                 "|     |\r\n" +
                                 " ----- \r\n" +
                                 "|     |\r\n" +
                                 "|     |\r\n" +
                                 "|     |\r\n" +
                                 " ----- ";

            Assert.Equal(eight, LcdNumbers.Show(8, 5, 3));

            const string ninetySeven = " -----  ----- \r\n" +
                                       "|     |      |\r\n" +
                                       "|     |      |\r\n" +
                                       "|     |      |\r\n" +
                                       " -----        \r\n" +
                                       "      |      |\r\n" +
                                       "      |      |\r\n" +
                                       "      |      |\r\n" +
                                       " -----        ";

            Assert.Equal(ninetySeven, LcdNumbers.Show(97, 5, 3));

        }
    }

}