using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Card> collection = new();
            string[] deck = Console.ReadLine().Split(", ");
            for (int i = 0; i < deck.Length; i++)
            {
                try
                {
                    string[] currentCard = deck[i].Split(" ");

                    Card card = new(currentCard[0], char.Parse(currentCard[1]));
                    collection.Add(card);

                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid card!");
                    
                }
            }
                StringBuilder sb = new();
                foreach (var item in collection)
                {
                    sb.Append(item.ToString() + " ");
                }
                Console.WriteLine(sb.ToString().Trim());

            
        }
    }

    public class Card
    {
        private IReadOnlyCollection<string> cardFacesCollection =
            new HashSet<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "K", "Q", "J", "A" };

        private string cardFaces;
        private char suits;

        public Card(string cardFaces, char suits)
        {
            CardFaces = cardFaces;

            if (suits == 'S')
            {
                Suits = '\u2660';
            }
            else if (suits == 'H')
            {
                Suits = '\u2665';
            }
            else if (suits == 'D')
            {
                Suits = '\u2666';
            }
            else if (suits == 'C')
            {
                Suits = '\u2663';
            }

        }

        public char Suits
        {
            get { return suits; }
            set
            {
                if (SuitChecker(value))
                {
                    throw new ArgumentException();
                }
                suits = value;
            }
        }

        public string CardFaces
        {
            get { return cardFaces; }
            set
            {
                if (FacesChecker(value))
                {
                    throw new ArgumentException();
                }
                cardFaces = value;
            }
        }

        private bool FacesChecker(string face)
        {
            if (!cardFacesCollection.Contains(face))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"[{this.CardFaces}{this.Suits}]";
        }

        private bool SuitChecker(char suit)
        {
            if (suit == '\u2660')
            {
                return false;
            }
            else if (suit == '\u2665')
            {
                return false;
            }
            else if (suit == '\u2666')
            {
                return false;
            }
            else if (suit == '\u2663')
            {
                return false;
            }
            return true;
        }



    }
}

