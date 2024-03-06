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
    }
}