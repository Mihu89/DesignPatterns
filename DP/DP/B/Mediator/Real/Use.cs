using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Mediator.Real
{
    public static class Use
    {
        public static void Apply()
        {
            IFacebookGroupMediator mediator = new ConcretFacebookGroupMediator();
            User u1 = new Client(mediator, "U1");
            User u2 = new Client(mediator, "U2");
            User u3 = new Client(mediator, "U3");
            User u4 = new Client(mediator, "U4");
            User u5 = new Client(mediator, "U5");
            User u6 = new Client(mediator, "U6");
            User u7 = new Client(mediator, "U7");

            mediator.RegisterUser(u1);
            mediator.RegisterUser(u2);
            mediator.RegisterUser(u3);
            mediator.RegisterUser(u4);
            mediator.RegisterUser(u5);
            mediator.RegisterUser(u6);
            mediator.RegisterUser(u7);

            u1.Send("We learn at StapIT");
            Console.WriteLine();
            u3.Send("I play GTA5");
        }
    }
}
