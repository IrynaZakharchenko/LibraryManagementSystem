using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
   public interface IUserInformationRegister
   {
      UserInformation FindUser(string searhString);
      string[] PossiblePositions();
      void AddUser(UserInformation userInformation);
      void EditUser(UserInformation userInformation);
      void DeleteUser(UserInformation userInformation);
   }
}
