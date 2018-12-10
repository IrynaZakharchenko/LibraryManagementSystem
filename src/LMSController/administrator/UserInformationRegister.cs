using LMSModel;
using System;

namespace LMSController
{
   internal class UserInformationRegister : IUserInformationRegister
   {
      private static readonly string[] possiblePositions = Enum.GetNames(typeof(UserPosition));

      public string[] GetPossiblePositions()
      {
         return possiblePositions;
      }

      public UserInformation FindByName(string userName)
      {
         if (userName == null)
         {
            throw new ArgumentNullException(nameof(userName));
         }

         Account account = Accounts.FindByUserName(userName);

         UserInformation result = null;
         if (account != null)
         {
            result = new UserInformation()
            {
               UserId = account.id_account,
               Position = account.Position.position_enum.ToString(),
               Credential = new UserCredential()
               {
                  Name = account.login,
                  Password = account.password,
               },
               PersonalInformation = PersonalInformation.Convert(account.Person)
            };
         }
         return result;
      }

      public void Add(UserInformation userInformation)
      {
         Accounts.Add(Convert(userInformation));
         Accounts.Save();
      }

      public void Edit(UserInformation userInformation)
      {
         Accounts.Edit(Convert(userInformation));
         Accounts.Save();
      }

      public void Delete(UserInformation userInformation)
      {
         if (userInformation == null)
         {
            throw new ArgumentNullException(nameof(userInformation));
         }

         if (userInformation.Credential == null)
         {
            throw new ArgumentNullException(nameof(userInformation.Credential));
         }

         Accounts.Delete(userInformation.Credential.Name);
         Accounts.Save();
      }

      private static Account Convert(UserInformation userInformation)
      {
         if (userInformation == null)
         {
            throw new ArgumentNullException(nameof(userInformation));
         }

         return new Account
         {
            id_account = userInformation.UserId,
            login = userInformation.Credential.Name,
            password = userInformation.Credential.Password,
            Position = new Position
            {
               position_enum = (UserPosition)Enum.Parse(typeof(UserPosition), userInformation.Position)
            },
            Person = PersonalInformation.Convert(userInformation.PersonalInformation)
         };
      }
   }
}
