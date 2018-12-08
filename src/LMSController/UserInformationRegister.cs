using LMSModel;
using System;

namespace LMSController
{
   class UserInformationRegister : IUserInformationRegister
   {
      public string[] PossiblePositions()
      {
         return Enum.GetNames(typeof(UserPosition));
      }

      public void AddUser(UserInformation userInformation)
      {
         if (userInformation == null)
         {
            throw new ArgumentNullException(nameof(userInformation));
         }

         Accounts.Add(new Account
         {
            login = userInformation.Credential.Name,
            password = userInformation.Credential.Password,
            Position = new Position
            {
               position_enum = (UserPosition)Enum.Parse(typeof(UserPosition), userInformation.Position)
            },
            Person = new Person
            {
               address = userInformation.PersonalInformation.Address,
               birthday = userInformation.PersonalInformation.Birthday,
               phone = userInformation.PersonalInformation.Phone,
               full_name = userInformation.PersonalInformation.FullName,
            }
         });
         Accounts.Save();
      }

      public void DeleteUser(UserInformation userInformation)
      {
         if (userInformation == null)
         {
            throw new ArgumentNullException(nameof(userInformation));
         }

         Accounts.Delete(userInformation.Credential.Name);
         Accounts.Save();
      }

      public void EditUser(UserInformation userInformation)
      {
         if (userInformation == null)
         {
            throw new ArgumentNullException(nameof(userInformation));
         }

         Accounts.Edit(new Account
         {
            id_account = userInformation.UserId,
            login = userInformation.Credential.Name,
            password = userInformation.Credential.Password,
            Position = new Position
            {
               position_enum = (UserPosition)Enum.Parse(typeof(UserPosition), userInformation.Position)
            },
            Person = new Person
            {
               address = userInformation.PersonalInformation.Address,
               birthday = userInformation.PersonalInformation.Birthday,
               phone = userInformation.PersonalInformation.Phone,
               full_name = userInformation.PersonalInformation.FullName,
            }
         });
         Accounts.Save();
      }
        
      public UserInformation FindUser(string userName)
      {
         if (userName == null)
         {
            throw new ArgumentNullException(nameof(userName));
         }

         Account account = Accounts.FindByUserName(userName);

         UserInformation result = null;
         if (account != null)
         {
            result = new UserInformation(account.login, account.password, account.Position.position_enum.ToString(), new PersonalInformation(account.Person.full_name,
               account.Person.birthday, account.Person.phone, account.Person.address))
               {
                  UserId = account.id_account
               };
         }
         return result;
      }
   }
}
