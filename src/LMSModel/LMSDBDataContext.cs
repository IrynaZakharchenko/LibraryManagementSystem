using System;
using System.Collections.Generic;
namespace LMSModel
{
   public partial class LMSDBDataContext
   {
      partial void OnCreated()
      {
         if (!DatabaseExists())
         {
            CreateDatabase();

            List<Position> positions = new List<Position>();
            foreach (UserPosition position in Enum.GetValues(typeof(UserPosition)))
            {
               positions.Add(new Position() { position_enum = position });
            }
            Positions.InsertAllOnSubmit(positions);

            Account account = new Account
            {
               Position = positions.Find(position => position.position_enum.Equals(UserPosition.Administrator)),
               login = "admin",
               password = "admin",
               Person = new Person
               {
                  address = "localhost",
                  birthday = System.DateTime.Now,
                  full_name = "Default administrator",
                  phone = 0
               }
            };

            Accounts.InsertOnSubmit(account);
            SubmitChanges();
         }
      }
   }
}
