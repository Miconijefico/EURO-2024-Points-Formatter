using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EURO_2024_Game
{
    public class PointsCalculator
    {
        public Dictionary<string, int> CalculateScores(string userFilePath, string resultFilePath)
        {
            var scores = new Dictionary<string, int>();
            var results = File.ReadAllLines(resultFilePath);
            var users = File.ReadAllLines(userFilePath);

            string currentUser = null;
            int currentQuestionIndex = 0;
            for (int i = 0; i < users.Length; i++)
            {
                if (!users[i].Contains(":")) // This is a user name
                {
                    currentUser = users[i];
                    scores[currentUser] = 0;
                    currentQuestionIndex = 0; // Reset question index for each user
                }
                else // This is an answer
                {
                    string userAnswer = users[i];
                    string correctAnswer = results[currentQuestionIndex];

                    if (userAnswer == correctAnswer)
                    {
                        scores[currentUser] += 3;
                    }
                    else if (userAnswer.Contains(":") && correctAnswer.Contains(":") && userAnswer.Split(':')[1] == correctAnswer.Split(':')[1])

                    {
                        scores[currentUser] += 1;
                    }

                    currentQuestionIndex++; // Move to the next question
                }
            }

            return scores;
        }
    }
}
