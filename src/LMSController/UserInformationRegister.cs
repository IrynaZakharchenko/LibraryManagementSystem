using LMSModel;
using System;

namespace LMSController
{
   class UserInformationRegister : IUserInformationRegister
   {
      public string[] PossiblePositions()
      {
         return Enum.GetNames(typeof(PositionEnum));
      }

      public void AddUser(UserInformation userInformation)
      {
         Accounts.Add(new Account
         {
            login = userInformation.Login,
            password = userInformation.Password,
            Position = new Position
            {
               position_enum = (PositionEnum)Enum.Parse(typeof(PositionEnum), userInformation.Position)
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
         Accounts.Delete(userInformation.Login);
         Accounts.Save();
      }

      public void EditUser(UserInformation userInformation)
      {
         Accounts.Edit(new Account
         {
            id_account = userInformation.UserId,
            login = userInformation.Login,
            password = userInformation.Password,
            Position = new Position
            {
               position_enum = (PositionEnum)Enum.Parse(typeof(PositionEnum), userInformation.Position)
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
        
      public UserInformation FindUser(string searhString)
      {
         Account account = Accounts.FindByLogin(searhString);

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
