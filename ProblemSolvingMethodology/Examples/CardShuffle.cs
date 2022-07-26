using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingMethodology.Examples
{
    class CardShuffle
    {
        static Random rand = new Random();

        public static void Test()
        {
            List<Card> cards = new List<Card>();
            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Suit[] allSuits = new Suit[] { Suit.CLUB, Suit.DIAMOND, Suit.HEART, Suit.SPADE };
            foreach (string face in allFaces)
            {
                foreach (Suit suit in allSuits)
                {
                    Card card = new Card() { Face = face, Suit = suit };
                    cards.Add(card);
                }
            }
            ShuffleCards(cards);
            PrintCards(cards);

            // Border case Test
            TestShuffleOneCard();
            TestShuffleTwoCards();

            // Performance Test
            TestShuffle52000Cards();
        }

        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.Write(card);
            }
            Console.WriteLine();
        }

        static void PerformSingleSwap(List<Card> cards, int index)
        {
            int randomIndex = rand.Next(0, cards.Count);
            Card firstCard = cards[index];
            Card randomCard = cards[randomIndex];
            cards[index] = randomCard;
            cards[randomIndex] = firstCard;
        }

        static void ShuffleCards(List<Card> cards)
        {
            if (cards.Count > 1)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    PerformSingleSwap(cards, i);
                }
            }
        }

        static void TestShuffleOneCard()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "A", Suit = Suit.CLUB });
            ShuffleCards(cards);
            PrintCards(cards);
        }

        static void TestShuffleTwoCards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(new Card() { Face = "A", Suit = Suit.CLUB });
            cards.Add(new Card() { Face = "3", Suit = Suit.DIAMOND });
            ShuffleCards(cards);
            PrintCards(cards);
        }

        static void TestShuffle52000Cards()
        {
            List<Card> cards = new List<Card>();
            string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Suit[] allSuits = new Suit[] { Suit.CLUB, Suit.DIAMOND, Suit.HEART, Suit.SPADE };
            for (int i = 0; i < 1000; i++)
            {
                foreach (string face in allFaces)
                {
                    foreach (Suit suit in allSuits)
                    {
                        Card card = new Card() { Face = face, Suit = suit };
                        cards.Add(card);
                    }
                }
            }
            //PrintCards(cards);
            DateTime oldTime = DateTime.Now;
            ShuffleCards(cards);
            DateTime newTime = DateTime.Now;
            Console.WriteLine("Execution time: {0}", newTime - oldTime);
        }
    }
}
