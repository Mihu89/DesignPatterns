using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Mediator.Real
{
    public class Client : User
    {
        public Client(IFacebookGroupMediator mediator, string name): base(mediator, name)
        {
        }
        public override void Receive(string message)
        {
            Console.WriteLine($"{name} : Received Message: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{name} : Sending Message ={message}\n");
            imediator.SendMessage(message, this);
        }
    }
}
