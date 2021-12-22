using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{

    //single responsibility principle
    interface IUser
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password, string email);

    }


    interface ILogger
    {
        bool LogError(string error);

    }


    interface IEmail
    {
        bool SendEmail(string email, string body);

    }
}
