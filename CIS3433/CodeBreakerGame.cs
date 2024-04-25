using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS3433
{
    public class CodeBreakerGame
    {
        private readonly List<string> possibleGuesses;

        public List<string> Guesses { get; private set; }

        public CodeBreakerGame()
        {
            Guesses = new List<string>();
            possibleGuesses = GeneratePossibleGuesses();
        }

        private List<string> GeneratePossibleGuesses()
        {
            return Enumerable.Range(0, 10000)
                .Select(x => x.ToString("D4"))
                .Where(x => x.Distinct().Count() == 4)
                .ToList();
        }

        public string GenerateInitialGuess()
        {
            string initialGuess = possibleGuesses[0];
            Guesses.Add(initialGuess);
            return initialGuess;
        }

        public (string finalGuess, bool isGameFinished) MakeGuess(int bulls, int cows)
        {
            RemoveInvalidGuesses(bulls, cows);

            if (bulls == 4)
            {
                return (Guesses.Last(), true);
            }

            if (possibleGuesses.Count == 1)
            {
                string finalGuess = possibleGuesses[0];
                Guesses.Add(finalGuess);
                return (finalGuess, true);
            }

            string nextGuess = SelectNextGuess();
            Guesses.Add(nextGuess);

            return (nextGuess, false);
        }

        private void RemoveInvalidGuesses(int bulls, int cows)
        {
            string lastGuess = Guesses.Last();
            possibleGuesses.RemoveAll(guess =>
                CountBulls(guess, lastGuess) != bulls ||
                CountCows(guess, lastGuess) != cows);
        }

        private string SelectNextGuess()
        {
            Dictionary<string, int> guessCounts = new Dictionary<string, int>();

            foreach (string guess in possibleGuesses)
            {
                int count = CountPossibleSolutions(guess);
                guessCounts[guess] = count;
            }

            return guessCounts.OrderBy(x => x.Value).First().Key;
        }

        private int CountPossibleSolutions(string guess)
        {
            return possibleGuesses.Count(g =>
                CountBulls(guess, g) == CountBulls(Guesses.Last(), g) &&
                CountCows(guess, g) == CountCows(Guesses.Last(), g));
        }

        private int CountBulls(string guess, string secretNumber)
        {
            return guess.Zip(secretNumber, (g, s) => g == s).Count(isMatch => isMatch);
        }

        private int CountCows(string guess, string secretNumber)
        {
            return guess.Count(digit => secretNumber.Contains(digit)) - CountBulls(guess, secretNumber);
        }
    }
}