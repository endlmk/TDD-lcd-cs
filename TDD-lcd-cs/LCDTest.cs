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

            //const string four = "   \r\n" +
            //                    "|_|\r\n" +
            //                    "  |";

            //Assert.Equal(four, LcdNumbers.Show(4));

            //const string five = " _ \r\n" +
            //                    "|_ \r\n" +
            //                    " _|";

            //Assert.Equal(five, LcdNumbers.Show(5));

            //const string six = " _ \r\n" +
            //                   "|_ \r\n" +
            //                   "|_|";

            //Assert.Equal(six, LcdNumbers.Show(6));

            //const string seven = " _ \r\n" +
            //                     "  |\r\n" +
            //                     "  |";

            //Assert.Equal(seven, LcdNumbers.Show(7));

            //const string eight = " _ \r\n" +
            //                     "|_|\r\n" +
            //                     "|_|";

            //Assert.Equal(eight, LcdNumbers.Show(8));

            //const string nine = " _ \r\n" +
            //                    "|_|\r\n" +
            //                    " _|";

            //Assert.Equal(nine, LcdNumbers.Show(9));

            //const string zero = " _ \r\n" +
            //                    "| |\r\n" +
            //                    "|_|";

            //Assert.Equal(zero, LcdNumbers.Show(0));
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

            //const string allDigits = "   _  _     _  _  _  _  _  _ \r\n" +
            //                         " | _| _||_||_ |_   ||_||_|| |\r\n" +
            //                         " ||_  _|  | _||_|  ||_| _||_|";
            //Assert.Equal(allDigits, LcdNumbers.Show(1234567890));

        }
    }

}