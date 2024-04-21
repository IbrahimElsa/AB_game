using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS3433
{
    public class CodeBreakerGame
    {
        private readonly List<string> possibleGuesses;
        private readonly Dictionary<string, int> guessScores;

        public List<string> Guesses { get; private set; }
        public int TotalTries { get; private set; }

        public CodeBreakerGame()
        {
            Guesses = new List<string>();
            TotalTries = 0;
            possibleGuesses = GeneratePossibleGuesses();
            guessScores = new Dictionary<string, int>(possibleGuesses.Count);
            foreach (var guess in possibleGuesses)
            {
                guessScores[guess] = 0;
            }
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
            string initialGuess = possibleGuesses[new Random().Next(possibleGuesses.Count)];
            Guesses.Add(initialGuess);
            TotalTries++;
            return initialGuess;
        }

        public string MakeGuess(int bulls, int cows)
        {
            UpdateGuessScores(bulls, cows);
            RemoveInvalidGuesses(bulls, cows);
            string bestGuess = possibleGuesses
                .OrderByDescending(guess => guessScores[guess])
                .FirstOrDefault(guess => guess.Distinct().Count() == 4) ?? string.Empty;
            if (!string.IsNullOrEmpty(bestGuess))
            {
                Guesses.Add(bestGuess);
                TotalTries++;
            }
            return bestGuess;
        }

        private void UpdateGuessScores(int bulls, int cows)
        {
            foreach (var possibleGuess in possibleGuesses)
            {
                int score = CountPossibleSolutions(possibleGuess, possibleGuesses, bulls, cows);
                guessScores[possibleGuess] = Math.Min(score, guessScores[possibleGuess]);
            }
        }

        private void RemoveInvalidGuesses(int bulls, int cows)
        {
            string lastGuess = Guesses.LastOrDefault() ?? string.Empty;
            possibleGuesses.RemoveAll(guess =>
                CountBulls(guess, lastGuess) != bulls ||
                CountCows(guess, lastGuess) != cows);
        }

        private int CountPossibleSolutions(string guess, List<string> possibleGuesses, int bulls, int cows)
        {
            return possibleGuesses.Count(g =>
                CountBulls(guess, g) == bulls && CountCows(guess, g) == cows);
        }

        private int CountBulls(string guess, string secretNumber)
        {
            if (string.IsNullOrEmpty(secretNumber))
                return 0;

            int count = 0;
            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == secretNumber[i])
                    count++;
            }
            return count;
        }

        private int CountCows(string guess, string secretNumber)
        {
            if (string.IsNullOrEmpty(secretNumber))
                return 0;

            int count = 0;
            foreach (char digit in guess)
            {
                if (secretNumber.Contains(digit))
                    count++;
            }
            return count - CountBulls(guess, secretNumber);
        }
    }
}