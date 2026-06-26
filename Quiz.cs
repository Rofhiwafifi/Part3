using System.Collections.Generic;

namespace demo
{
    public class Quiz
    {
        private List<quizQuestion> questions = new List<quizQuestion>()
        {
            new quizQuestion("What should you do with a phishing email?", "Report it"),

            new quizQuestion("Should you reuse the same password for multiple accounts?", "No"),

            new quizQuestion("What does VPN stand for?", "Virtual Private Network"),

            new quizQuestion("Is Two-Factor Authentication (2FA) recommended?", "Yes"),

            new quizQuestion("What type of software protects your computer from viruses?", "Antivirus"),

            new quizQuestion("What device helps block unauthorized network access?", "Firewall"),

            new quizQuestion("Should you click links from unknown emails?", "No"),

            new quizQuestion("What is malware?", "Malicious Software"),

            new quizQuestion("What should you do if you think your account has been hacked?", "Change Password"),

            new quizQuestion("Is it safe to share your passwords with other people?", "No")
        };

        public List<quizQuestion> GetQuestions()
        {
            return questions;
        }
    }
}