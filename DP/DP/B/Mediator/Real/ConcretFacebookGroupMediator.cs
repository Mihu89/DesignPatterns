using System;
using System.Collections.Generic;
using System.Text;

namespace DP.B.Mediator.Real
{
    public class ConcretFacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> userList = new List<User>();

        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string message, User user)
        {
            foreach (var u in userList)
            {
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
