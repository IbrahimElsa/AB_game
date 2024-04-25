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

        public CodeBreakerGame()
        {
            Guesses = new List<string>();
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
            //string initialGuess = "0123";
            Guesses.Add(initialGuess);
            return initialGuess;
        }

        public (string finalGuess, bool isGameFinished) MakeGuess(int bulls, int cows)
        {
            RemoveInvalidGuesses(bulls, cows);

            // If there's only one possible guess remaining, return it and indicate the game is finished
            if (possibleGuesses.Count == 1)
            {
                string finalGuess = possibleGuesses[0];
                Guesses.Add(finalGuess);
                return (finalGuess, true);
            }

            // Create a separate list of candidate guesses
            List<string> candidateGuesses = possibleGuesses.Where(guess => guess.Distinct().Count() == 4).ToList();

            // Create a cache for storing previous counts
            Dictionary<string, int> countCache = new Dictionary<string, int>();

            // Use a priority queue to store candidate guesses ordered by their scores
            PriorityQueue<string, int> candidateScores = new PriorityQueue<string, int>();

            foreach (var candidateGuess in candidateGuesses)
            {
                int score = CountPossibleSolutions(candidateGuess, possibleGuesses, bulls, cows, countCache);
                candidateScores.Enqueue(candidateGuess, -score); // Negative score for descending order
            }

            string bestGuess = candidateScores.Dequeue();
            Guesses.Add(bestGuess);

            // Check if the game is finished (i.e., there's only one possible guess left)
            bool isGameFinished = possibleGuesses.Count == 1;

            // Return whether the game is finished
            return (bestGuess, isGameFinished);
        }

        private void RemoveInvalidGuesses(int bulls, int cows)
        {
            string lastGuess = Guesses.LastOrDefault() ?? string.Empty;
            possibleGuesses.RemoveAll(guess =>
                CountBulls(guess, lastGuess) != bulls ||
                CountCows(guess, lastGuess) != cows);
        }

        private int CountPossibleSolutions(string guess, List<string> possibleGuesses, int bulls, int cows, Dictionary<string, int> countCache)
        {
            string key = $"{guess}_{bulls}_{cows}";

            if (countCache.TryGetValue(key, out int count))
            {
                return count;
            }

            count = possibleGuesses.Count(g => CountBulls(guess, g) == bulls && CountCows(guess, g) == cows);
            countCache[key] = count;

            return count;
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