using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace DP.S.Adapter.Real
{
    public class John : IEnglishSpecker
    {
        public string AnswerForTheQuestion(string words)
        {
            string answer;
            if (words.Equals("Where are you ?"))
            {
                answer = "I'm from  USA";
            }
            else
            {
                answer = "What do you mean ?";
            }
            return answer;
        }

        public string AskQuestion(string words)
        {
            Console.WriteLine($"Question from John (english user) is: {words}");
            ITarget target = new Translator();   // Adapter
            string answerfromDavid = target.TranslateAndReplayToOtherPerson(words, "English");
            return answerfromDavid;
        }
    }
}
