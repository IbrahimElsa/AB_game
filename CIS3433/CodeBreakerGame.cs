using System;
using System.Collections.Generic;
using System.Linq;

namespace CIS3433
{
    public class CodeBreakerGame
    {
        private readonly List<string> possibleGuesses;
        private readonly Dictionary<string, int> guessScores;

        public string SecretNumber { get; private set; }
        public List<string> Guesses { get; private set; }
        public int TotalTries { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public CodeBreakerGame(string secretNumber)
        {
            SecretNumber = secretNumber;
            Guesses = new List<string>();
            TotalTries = 0;
            StartTime = DateTime.Now;

            possibleGuesses = GeneratePossibleGuesses();
            guessScores = possibleGuesses.ToDictionary(guess => guess, _ => 0);
        }

        private List<string> GeneratePossibleGuesses()
        {
            return Enumerable.Range(0, 10)
                .Select(x => x.ToString())
                .OrderBy(x => Guid.NewGuid())
                .Take(4)
                .ToList();
        }

        public void MakeGuess(string guess)
        {
            Guesses.Add(guess);
            TotalTries++;

            int bulls = int.Parse(guess.Substring(0, 1));
            int cows = int.Parse(guess.Substring(1, 1));

            UpdateGuessScores(guess, bulls, cows);
            RemoveInvalidGuesses(bulls, cows);
        }

        private void UpdateGuessScores(string guess, int bulls, int cows)
        {
            foreach (var possibleGuess in possibleGuesses)
            {
                int score = CountPossibleSolutions(possibleGuess, possibleGuesses, bulls, cows);
                guessScores[possibleGuess] = Math.Min(score, guessScores[possibleGuess]);
            }
        }

        private void RemoveInvalidGuesses(int bulls, int cows)
        {
            possibleGuesses.RemoveAll(guess =>
                CountBulls(guess, SecretNumber) != bulls || CountCows(guess, SecretNumber) != cows);
        }

        private int CountPossibleSolutions(string guess, List<string> possibleGuesses, int bulls, int cows)
        {
            return possibleGuesses.Count(g =>
                CountBulls(guess, g) == bulls && CountCows(guess, g) == cows);
        }

        private int CountBulls(string guess, string secretNumber)
        {
            return guess.Zip(secretNumber, (g, s) => g == s).Count(x => x);
        }

        private int CountCows(string guess, string secretNumber)
        {
            return guess.Count(digit => secretNumber.Contains(digit)) - CountBulls(guess, secretNumber);
        }

        public double CalculateScore()
        {
            EndTime = DateTime.Now;
            TimeSpan timeTaken = EndTime - StartTime;
            double score = 10 * (10 - TotalTries + 1) - (timeTaken.TotalSeconds / 10);
            return score;
        }
    }
}