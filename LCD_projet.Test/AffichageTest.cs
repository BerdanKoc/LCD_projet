namespace LCD_projet.Test
{
    public class AffichageTest
    {
        [Fact]
        public void Chiffre1()
        {
            var attendu =
                "   " + Environment.NewLine +
                "  |" + Environment.NewLine +
                "  |";

            string chiffre1 = Nombres.Un;

            Assert.Equal(attendu, chiffre1 );
        }

        [Fact]
        public void Chiffre2()
        {
            var attendu =
                " _ " + Environment.NewLine +
                " _|" + Environment.NewLine +
                "|_ ";

            string chiffre2 = Nombres.Deux;

            Assert.Equal(attendu, chiffre2);
        }

        [Fact]
        public void Chiffre3()
        {
            var attendu =
                " _ " + Environment.NewLine +
                " _|" + Environment.NewLine +
                " _|";

            string chiffre3 = Nombres.Trois;

            Assert.Equal(attendu, chiffre3);
        }
    }
}