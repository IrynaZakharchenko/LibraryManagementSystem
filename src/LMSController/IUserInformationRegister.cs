using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public interface IUserInformationRegister
    {
        CUserInformation FindUserByName(string name);
        CUserInformation FindUserByLogin(string login);
        void AddUser(CUserInformation userInformation);
        void EditUser(CUserInformation userInformation);
        void DeleteUser(CUserInformation userInformation);
    }
}
