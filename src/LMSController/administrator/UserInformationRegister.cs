using LMSModel;
using System;

namespace LMSController
{
   internal class UserInformationRegister : IUserInformationRegister
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
            result = new UserInformation()
            {
               UserId = account.id_account,
               Position = account.Position.position_enum.ToString(),
               Credential = new UserCredential()
               {
                  Name = account.login,
                  Password = account.password,
               },
               PersonalInformation = new PersonalInformation()
               {
                  FullName = account.Person.full_name,
                  Birthday = account.Person.birthday,
                  Phone = account.Person.phone,
                  Address = account.Person.address
               }
            };
         }
         return result;
      }
   }
}
