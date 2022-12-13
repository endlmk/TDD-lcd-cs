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
        }
    }
}