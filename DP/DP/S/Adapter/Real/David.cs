using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Adapter.Real
{
    public class David : IFrenchSpecker
    {
        public string AnswerForTheQuestion(string words)
        {
            string answer;
            if (words.Equals("Comment allez-vous"))
            {
                answer = "Je suis tres bien";
            }
            else
            {
                answer = "Repete ancore un fois";
            }
            return answer;
        }

        public string AskQuestion(string words)
        {
            Console.WriteLine($"Question from David (french) is {words}");
            ITarget target = new Translator();   // Adapter
            string answerfromJohn = target.TranslateAndReplayToOtherPerson(words, "English");
            return answerfromJohn;
        }
    }
}
