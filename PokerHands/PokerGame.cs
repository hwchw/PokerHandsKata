using System;

namespace PokerHands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        } 
    }

    public class Game
    {
	    private Player _player;
	    private Player _player1;
	    public Game(Player player, Player playerHand1)
	    {
		    _player = player;
		    _player1 = playerHand1;
	    }

	    public string Result()
	    {
		    return "White wins. - with high card: Ace";
	    }
    }

    public class Player
    {
	    private string _playerName;
	    private PlayerHand _playerHand;

	    public Player(string playerName, PlayerHand playerHand)
	    {
		    _playerName = playerName;
		    _playerHand = playerHand;
	    }
    }

    public class PlayerHand
    {
	    private string _card;
	    private string _card1;
	    private string _card2;
	    private string _card3;
	    private string _card4;

	    public PlayerHand(string card, string card1, string card2, string card3, string card4)
	    {
		    _card = card;
		    _card1 = card1;
		    _card2 = card2;
		    _card3 = card3;
		    _card4 = card4;
	    }
    }
}