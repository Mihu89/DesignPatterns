using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Mediator.Real
{
    public interface IFacebookGroupMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }
}
