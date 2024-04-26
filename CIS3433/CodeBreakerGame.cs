using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS3433
{
    public class CodeBreakerGame
    {
        private readonly List<string> possibleGuesses;
        private readonly Dictionary<string, string> hintTable = new Dictionary<string, string>()
        {
            { "4B0C", "0123" },
            { "2B2C", "0214" },
            { "1B3C", "0134" },
            { "0B4C", "1034" },
            { "3B0C", "0456" },
            { "2B1C", "0145" },
            { "2B0C", "0456" },
            { "1B2C", "0245" },
            { "0B3C", "1435" },
            { "0B0C", "4567" },
            { "1B0C", "0456" },
            { "1B1C", "0145" },
            { "0B2C", "1245" },
            { "0B1C", "1456" }
        };

        public List<string> Guesses { get; private set; }

        public CodeBreakerGame()
        {
            Guesses = new List<string>();
            possibleGuesses = GeneratePossibleGuesses();
        }

        private List<string> GeneratePossibleGuesses()
        {
            List<string> guesses = new List<string>();
            for (int i = 0; i < 10000; i++)
            {
                string number = i.ToString("D4");
                if (number.Distinct().Count() == 4)
                {
                    guesses.Add(number);
                }
            }
            return guesses;
        }

        public string GenerateInitialGuess()
        {
            string initialGuess = "0123";
            Guesses.Add(initialGuess);
            return initialGuess;
        }

        public (string finalGuess, bool isGameFinished, bool isError) MakeGuess(int bulls, int cows)
        {
            string lastGuess = Guesses.Last();
            if (bulls < 0 || bulls > 4 || cows < 0 || cows > 4 || bulls + cows > 4 ||
                (bulls == 3 && cows == 1) || (bulls == 4 && cows > 0))
            {
                return (string.Empty, false, true);
            }

            RemoveInvalidGuesses(bulls, cows);
            if (bulls == 4)
            {
                return (lastGuess, true, false);
            }
            if (possibleGuesses.Count == 1)
            {
                string finalGuess = possibleGuesses[0];
                Guesses.Add(finalGuess);
                return (finalGuess, true, false);
            }

            try
            {
                string nextGuess = SelectNextGuess();
                Guesses.Add(nextGuess);
                return (nextGuess, false, false);
            }
            catch (InvalidOperationException)
            {
                return (string.Empty, false, true);
            }
        }

        private void RemoveInvalidGuesses(int bulls, int cows)
        {
            string lastGuess = Guesses.Last();
            List<string> validGuesses = new List<string>();
            foreach (string guess in possibleGuesses)
            {
                if (CountBulls(guess, lastGuess) == bulls && CountCows(guess, lastGuess) == cows)
                {
                    validGuesses.Add(guess);
                }
            }
            possibleGuesses.Clear();
            possibleGuesses.AddRange(validGuesses);
        }

        private string SelectNextGuess()
        {
            if (Guesses.Count == 1)
            {
                string hint = $"{CountBulls(Guesses.Last(), possibleGuesses[0])}B{CountCows(Guesses.Last(), possibleGuesses[0])}C";
                if (hintTable.ContainsKey(hint))
                {
                    return hintTable[hint];
                }
            }

            Dictionary<string, int> guessCounts = new Dictionary<string, int>();
            foreach (string guess in possibleGuesses)
            {
                int count = CountPossibleSolutions(guess);
                guessCounts[guess] = count;
            }
            KeyValuePair<string, int> bestGuess = guessCounts.OrderBy(x => x.Value).First();
            return bestGuess.Key;
        }

        private int CountPossibleSolutions(string guess)
        {
            int count = 0;
            foreach (string g in possibleGuesses)
            {
                if (CountBulls(guess, g) == CountBulls(Guesses.Last(), g) &&
                    CountCows(guess, g) == CountCows(Guesses.Last(), g))
                {
                    count++;
                }
            }
            return count;
        }

        private int CountBulls(string guess, string secretNumber)
        {
            int bulls = 0;
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == secretNumber[i])
                {
                    bulls++;
                }
            }
            return bulls;
        }

        private int CountCows(string guess, string secretNumber)
        {
            int cows = 0;
            foreach (char digit in guess)
            {
                if (secretNumber.Contains(digit))
                {
                    cows++;
                }
            }
            cows -= CountBulls(guess, secretNumber);
            return cows;
        }
    }
}