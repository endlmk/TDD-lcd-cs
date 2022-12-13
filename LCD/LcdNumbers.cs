namespace LCD
{
    public class LcdNumbers
    {
        private const string Zero = " _ \n" +
                                    "| |\n" +
                                    "|_|";

        private const string One = "  \n" +
                                   " |\n" +
                                   " |";

        private const string Two = " _ \n" +
                                   " _|\n" +
                                   "|_ ";

        private const string Three = " _ \n" +
                                     " _|\n" +
                                     " _|";

        private const string Four = "   \n" +
                                    "|_|\n" +
                                    "  |";


        private const string Five = " _ \n" +
                                    "|_ \n" +
                                    " _|";

        private const string Six = " _ \n" +
                                   "|_ \n" +
                                   "|_|";

        private const string Seven = " _ \n" +
                                     "  |\n" +
                                     "  |";

        private const string Eight = " _ \n" +
                                     "|_|\n" +
                                     "|_|";

        private const string Nine = " _ \n" +
                                    "|_|\n" +
                                    " _|";

        private static readonly string[] Numbers = new string[] { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine };

        public static string Show(int number)
        {
            return Numbers[number];
        }
    }
}