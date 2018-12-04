using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
   public class UserInformation
   {
      internal int UserId { get; set; }

      public string Login { get; set; }
      public string Password { get; set; }
      public string Position { get; set; }
      public PersonalInformation PersonalInformation { get; set; }

      public UserInformation() { }
      public UserInformation(string login, string password, 
      string position, PersonalInformation personalInformation)
      {
         Login = login;
         Password = password;
         Position = position;
         PersonalInformation = personalInformation;
      }
   }
}
