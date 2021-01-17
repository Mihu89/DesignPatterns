using System;

namespace DP.B.Mediator.Real
{
    public abstract class User
    {
        protected string name;
        protected IFacebookGroupMediator imediator;

        public User(IFacebookGroupMediator mediator, string userName)
        {
            imediator = mediator;
            name = userName;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
       
    }
}