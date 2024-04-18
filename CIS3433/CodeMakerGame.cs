using System;
using System.Linq;
using System.Collections.Generic;

namespace CIS3433
{
    public class CodeMakerGame
    {
        public string? SecretNumber { get; private set; }

        public CodeMakerGame()
        {
            SecretNumber = null;
        }

        public void GenerateSecretNumber()
        {
            //var random = new Random();
            //var digits = Enumerable.Range(0, 10).OrderBy(x => random.Next()).Take(4).ToArray();
            //SecretNumber = string.Join("", digits);
            SecretNumber = "1234";
        }

        public string EvaluateGuess(string guess)
        {
            int bulls = 0;
            int cows = 0;
            var secretNumberCounts = new Dictionary<char, int>();

            foreach (char digit in SecretNumber)
            {
                if (secretNumberCounts.ContainsKey(digit))
                {
                    secretNumberCounts[digit]++;
                }
                else
                {
                    secretNumberCounts[digit] = 1;
                }
            }

            for (int i = 0; i < SecretNumber.Length; i++)
            {
                if (guess[i] == SecretNumber[i])
                {
                    bulls++;
                    secretNumberCounts[guess[i]]--;
                }
            }

            for (int i = 0; i < SecretNumber.Length; i++)
            {
                if (guess[i] == SecretNumber[i]) continue;

                if (secretNumberCounts.ContainsKey(guess[i]) && secretNumberCounts[guess[i]] > 0)
                {
                    cows++;
                    secretNumberCounts[guess[i]]--;
                }
            }

            return $"{bulls}{cows}";
        }
    }
}