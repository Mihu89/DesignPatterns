using System;
using System.Collections.Generic;
using System.Text;

namespace DP.S.Adapter.Real
{
    public static class Use
    {
        public static void Applay()
        {
            string replayFromDavid = new John().AskQuestion("How are you ?");
            Console.WriteLine($"Answer from David: {replayFromDavid}\n");

            string replayFromJohn = new David().AskQuestion("Ou etes vous?");
            Console.WriteLine($"Answer from John: {replayFromJohn}\n");
        }
    }
}
