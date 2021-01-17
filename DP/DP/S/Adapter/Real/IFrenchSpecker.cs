using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Adapter.Real
{
    public interface IFrenchSpecker
    {
        string AskQuestion(string words);
        string AnswerForTheQuestion(string words);
    }
}
