using LCD;

namespace TDD_lcd_cs
{
    public class LCDTest
    {
        [Fact]
        public void CanShowOneDigit()
        {
            const string one = "  \n" +
                               " |\n" +
                               " |";

            Assert.Equal(one, LcdNumbers.Show(1));

            const string two = " _ \n" +
                               " _|\n" +
                               "|_ ";

            Assert.Equal(two, LcdNumbers.Show(2));

            const string three = " _ \n" +
                                 " _|\n" +
                                 " _|";

            Assert.Equal(three, LcdNumbers.Show(3));

            const string four = "   \n" +
                                "|_|\n" +
                                "  |";

            Assert.Equal(four, LcdNumbers.Show(4));

            const string five = " _ \n" +
                                "|_ \n" +
                                " _|";

            Assert.Equal(five, LcdNumbers.Show(5));

            const string six = " _ \n" +
                               "|_ \n" +
                               "|_|";

            Assert.Equal(six, LcdNumbers.Show(6));

            const string seven = " _ \n" +
                                 "  |\n" +
                                 "  |";

            Assert.Equal(seven, LcdNumbers.Show(7));

            const string eight = " _ \n" +
                                 "|_|\n" +
                                 "|_|";

            Assert.Equal(eight, LcdNumbers.Show(8));

            const string nine = " _ \n" +
                                "|_|\n" +
                                " _|";

            Assert.Equal(nine, LcdNumbers.Show(9));

            const string zero = " _ \n" +
                                "| |\n" +
                                "|_|";

            Assert.Equal(zero, LcdNumbers.Show(0));
        }
    }
}