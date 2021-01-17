using System;
using System.Collections.Generic;

namespace DP.S.Adapter.Real
{
    public class Translator : ITarget
    {
        static Dictionary<string, string> EnglishToFrench = new Dictionary<string, string>();
        static Dictionary<string, string> FrenchToEnglish = new Dictionary<string, string>();

        David david = new David();
        John john = new John();

        public Translator()
        {
            EnglishToFrench.Add("How are you ?", "comment allez-vous");
            FrenchToEnglish.Add("Je suis tre bien", "I'm fine"); 
            FrenchToEnglish.Add("Ou ete vous ?", "Where are you from ?");
            EnglishToFrench.Add("I'm from America", "Je suis aux Eats-Units");
        }
        public string TranslateAndReplayToOtherPerson(string words, string ConvertToWhichLanguage)
        {
            if (ConvertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
            {
                string Englishwords = ConvertToEnglish(words);
                Console.WriteLine("\nPam Converted \"" +words + " \" to \"" +Englishwords
                + " and send the question to John");
                string EnglishwordsReply = john.AnswerForTheQuestion(Englishwords);
                Console.WriteLine("Pam Got reply from John in English : " + "\"" +EnglishwordsReply
                + "\"");
                string FrenchConverted = ConvertToFrench(EnglishwordsReply);
                Console.WriteLine("Pam Converted " + "\"" +EnglishwordsReply + "\"" + " to " + "\""
+FrenchConverted + "\"" + " and send back to David\n");
                return FrenchConverted;
            }
            else if (ConvertToWhichLanguage.Equals("French", StringComparison.InvariantCultureIgnoreCase))
            {
                string Frenchwords = ConvertToFrench(words);
                Console.WriteLine("\nPam Converted \"" +words + " \" to \"" +Frenchwords
                + " and send the question to David");
                string FrenchwordsReply = david.AnswerForTheQuestion(Frenchwords);
                Console.WriteLine("Pam Got reply from David in French : " + "\"" +FrenchwordsReply
                + "\"");
                string EnglishConverted = ConvertToEnglish(FrenchwordsReply);
                Console.WriteLine("Pam Converted " + "\"" +FrenchwordsReply + "\"" + " to " + "\""
+EnglishConverted + "\"" + " and send back to John\n");
                return EnglishConverted;
            }
            else
            {
                return "Sorry Cannot Covert";
            }
        }

        public string ConvertToFrench(string words)
        {
            return EnglishToFrench[words];
        }

        public string ConvertToEnglish(string words)
        {
            return FrenchToEnglish[words];
        }
    }
}