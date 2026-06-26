using System;

namespace demo
{

    public class NLP_handler
    {


        public string DetectIntent(string input)
        {

            input = input.ToLower();


            if (input.Contains("remind") ||
            input.Contains("remember"))
            {
                return "reminder";
            }


            if (input.Contains("quiz"))
            {
                return "quiz";
            }


            if (input.Contains("task"))
            {
                return "task";
            }


            if (input.Contains("log"))
            {
                return "log";
            }



            return "chat";


        }


    }

}