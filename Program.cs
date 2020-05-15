using System;
using System.Collections.Generic;
using System.Linq;

namespace card_game_colter
{
  class Program
  {
    static void Main(string[] args)
    {
        Random rnd = new Random ();
        var deck1 = new List<string>() {"Ace of Clubs", "2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Diamonds", "2 of Diamonds", "3 of Diamonds", "4 of Diamonds", "5 of Diamonds", "6 of Diamonds", "7 of Diamonds", "8 of Diamonds", "9 of Diamonds", "10 of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds", "Ace of Hearts", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Spades", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades"};

        Console.WriteLine("Press Enter to Shuffle the Deck and Display the Top Two Random Cards");
        Console.ReadLine ();

        for (int firstIndex = deck1.Count - 1; firstIndex >= 0; firstIndex --) { 
          int secondIndex = rnd.Next(0,firstIndex);
          var firstValue = deck1[firstIndex];
          deck1[firstIndex] = deck1[secondIndex];
          deck1[secondIndex] = firstValue;
        }
        Console.WriteLine(deck1[0]);
        Console.WriteLine(deck1[1]);
    }
  }
}
