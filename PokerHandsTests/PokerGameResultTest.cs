using NUnit.Framework;

namespace PokerHands
{
    public class Tests
    {
        [Test]
        public void Given_BlackSide_2C_3D_5S_9C_KD_WhiteSide_2C_3H_4S_8C_AH_Then_White_Should_Won()
        {
	        var playerOne = new Player("Black", new PlayerHand("2C", "3D", "5S", "9C", "KD"));
	        var playerTwo = new Player("White", new PlayerHand("2C", "3H", "4S", "8C", "AH"));
            var game = new Game(playerOne, playerTwo);

            Assert.AreEqual("White wins. - with high card: Ace", game.Result());
        }
    }
}