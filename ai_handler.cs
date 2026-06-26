using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace demo
{//start of namespace
    public class ai_handler
    {//start of class
        private ArrayList reply;
        private ArrayList ignore;



        public ai_handler(ArrayList replyList, ArrayList ignoreList)
        {
            reply = replyList;
            ignore = ignoreList;
        }

        // method to remove special characters
        public string RemoveSpecialCharacters(string input)
        {//start of method
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            StringBuilder sanitized = new StringBuilder();

            foreach (char c in input)
            {//start of foreach
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '\'' || c == '-')
                {
                    sanitized.Append(c);
                }
                else
                {
                    sanitized.Append(' ');
                }
            }//end of foreach

            string result = sanitized.ToString();

            result = Regex.Replace(result, @"\s+", " ").Trim();

            return result;
        }//end of method

        // method to check user input
        public string ai_check(string questions, string username)
        {//start of method
            if (string.IsNullOrWhiteSpace(questions))
            {
                return "Please enter a valid question.";
            }

            string[] words = questions.ToLower().Split(
                new char[] { ' ', ',', '.', '?', '!', ';', ':' },
                StringSplitOptions.RemoveEmptyEntries);

            bool found = false;

            string message = "";

            Random indexer = new Random();

            List<string> per_word = new List<string>();
            List<string> answers_found = new List<string>();

            foreach (string word in words)
            {
                if (word.Length < 3 || ignore.Contains(word.ToLower()))
                    continue;

                per_word.Clear();

                // Interest detection
                if (word.Contains("interested"))
                {
                    SaveInterest(words, username);

                    message += "Great, I will remember your interests.\n";
                }

                bool wordFound = false;

                foreach (string answer in reply)
                {
                    if (answer.ToLower().Contains(word))
                    {
                        wordFound = true;
                        per_word.Add(answer);
                    }
                }

                if (wordFound && per_word.Count > 0)
                {
                    found = true;

                    int indexing = indexer.Next(0, per_word.Count);

                    answers_found.Add(per_word[indexing]);
                }
            }

            if (found && answers_found.Count > 0)
            {
                answers_found = answers_found.Distinct().ToList();

                foreach (string per_answer in answers_found)
                {
                    message += per_answer + "\n";
                }

                return message.TrimEnd('\n');
            }

            string[] fallbackMessages =
            {
                "I'm sorry, I don't understand that.",
                "I didn't quite get that.",
                "Try asking about cyber security.",
                "I couldn't find an answer for that."
            };

            Random random = new Random();

            return fallbackMessages[random.Next(fallbackMessages.Length)];
        }//end of method

        // method to save the users interests
        private void SaveInterest(string[] words, string username)
        {//start of save interests method
            HashSet<string> interests = new HashSet<string>();

            foreach (string word in words)
            {
                string clean = word.ToLower().Trim();

                clean = Regex.Replace(clean, @"[^a-zA-Z0-9\s]", "");

                if (!ignore.Contains(clean)
                    && clean != "interested"
                    && clean != "and"
                    && clean != "in"
                    && clean.Length >= 3)
                {
                    interests.Add(clean);
                }
            }

            if (interests.Count == 0)
                return;

            string filename = "interested_topic.txt";

            string finalList = string.Join(", ", interests);

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);

                bool userFound = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith(username))
                    {
                        userFound = true;

                        lines[i] = username + " interested in: " + finalList;

                        File.WriteAllLines(filename, lines);

                        break;
                    }
                }

                if (!userFound)
                {
                    File.AppendAllText(filename,
                        username + " interested in: " + finalList + "\n");
                }
            }
            else
            {
                File.WriteAllText(filename,
                    username + " interested in: " + finalList + "\n");
            }
        }//end of method

        // auto show saved interests
        public string GetInterestReminder(string username)
        {//start of interest reminder method
            string filename = "interested_topic.txt";

            if (!File.Exists(filename))
                return "";

            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                if (line.StartsWith(username))
                {
                    int colonIndex = line.IndexOf("interested in:");

                    if (colonIndex >= 0)
                    {
                        string interests = line.Substring(colonIndex + 14).Trim();

                        return "Just a reminder, you are interested in " + interests;
                    }
                }
            }

            return "";
        }//end of method
    }//end of classs
}//end of namespace