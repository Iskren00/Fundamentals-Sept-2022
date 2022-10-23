using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read the decks of both of players
            List<int> firstHand = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondHand = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            //This will be the winning deck
            List<int> winningDeck = new List<int>();

            //A boolean to stop the while loop
            bool isEndOfTheGame = true;

            //String to save who player win the game
            string winningPlayer = string.Empty;

            while (isEndOfTheGame)
            {
                //All the game is inside the method
                TheGame(firstHand, secondHand);

                //Check is the game ended
                if (firstHand.Count == 0)
                {
                    isEndOfTheGame = false;
                    winningPlayer = "Second";
                    winningDeck = secondHand;
                }
                else if(secondHand.Count == 0)
                {
                    isEndOfTheGame = false;
                    winningPlayer = "First";
                    winningDeck = firstHand;
                }
            }
            //Take the sum of the winning deck
            int sum = 0;

            foreach (int card in winningDeck)
            {
                sum += card;
            }

            //Prin the result
            Console.WriteLine($"{winningPlayer} player wins! Sum: {sum}");
        }


        static void TheGame(List<int> firstHand, List<int> secondHand)
        {
            if (firstHand[0] > secondHand[0])
            {
                int winingCard = firstHand[0];
                firstHand.Add(secondHand[0]);
                firstHand.Add(winingCard);
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);
            }
            else if (firstHand[0] < secondHand[0])
            {
                int winingCard = secondHand[0];
                secondHand.Add(firstHand[0]);
                secondHand.Add(winingCard);
                secondHand.RemoveAt(0);
                firstHand.RemoveAt(0);
            }
            else if (firstHand[0] == secondHand[0])
            {
                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);
            }


        }
    }
}
