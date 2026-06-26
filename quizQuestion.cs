using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{ }
public class quizQuestion
{
    public string Text { get; set; }
    public string Answer { get; set; }

    public quizQuestion(string text, string answer)
    {
        Text = text;
        Answer = answer;
    }
}
