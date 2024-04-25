using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS3433
{
    public class CodeBreakerGame
    {
        private List<string> possibleGuesses;

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
            string initialGuess = "0123"; // Use a fixed initial guess for better information gain
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
            HashSet<string> validGuesses = new HashSet<string>(possibleGuesses);

            foreach (string guess in possibleGuesses)
            {
                if (CountBulls(guess, lastGuess) != bulls || CountCows(guess, lastGuess) != cows)
                {
                    validGuesses.Remove(guess);
                }
            }

            possibleGuesses = validGuesses.ToList();
        }

        private string SelectNextGuess()
        {
            Dictionary<string, double> guessEntropies = new Dictionary<string, double>();

            foreach (string guess in possibleGuesses)
            {
                double entropy = CalculateEntropy(guess);
                guessEntropies[guess] = entropy;
            }

            return guessEntropies.OrderBy(x => x.Value).First().Key;
        }

        private double CalculateEntropy(string guess)
        {
            Dictionary<(int, int), int> countDistribution = new Dictionary<(int, int), int>();

            foreach (string possibleSolution in possibleGuesses)
            {
                int bulls = CountBulls(guess, possibleSolution);
                int cows = CountCows(guess, possibleSolution);

                if (!countDistribution.ContainsKey((bulls, cows)))
                {
                    countDistribution[(bulls, cows)] = 0;
                }

                countDistribution[(bulls, cows)]++;
            }

            double entropy = 0;

            foreach (int count in countDistribution.Values)
            {
                double probability = (double)count / possibleGuesses.Count;
                entropy -= probability * Math.Log(probability, 2);
            }

            return entropy;
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