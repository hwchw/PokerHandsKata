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
	    public Game(Player playerHand, Player playerHand1)
	    {
		    throw new System.NotImplementedException();
	    }

	    public string Result()
	    {
		    throw new NotImplementedException();
	    }
    }

    public class Player
    {
	    public Player(string playerName, PlayerHand playerHand)
	    {
		    throw new System.NotImplementedException();
	    }
    }

    public class PlayerHand
    {
	    public PlayerHand(string s, string s1, string s2, string s3, string kd)
	    {
		    throw new System.NotImplementedException();
	    }
    }
}