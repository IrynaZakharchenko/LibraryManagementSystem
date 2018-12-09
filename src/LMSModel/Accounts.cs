using System.Collections.Generic;
using System.Linq;

namespace LMSModel
{
   public static class Accounts
   {
      public static Account FindByUserNameAndPassword(string userName, string password)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.login.Equals(userName) && account.password.Equals(password)
            select account;

         return query.Count() > 0 ? query.First() : null;
      }

      public static Account FindByUserName(string userName)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.login.Equals(userName)
            select account;

         return query.Count() > 0 ? query.First() : null;
      }

      public static Account FindById(int id)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.id_account == id
            select account;

         return query.Count() > 0 ? query.First() : null;
      }

      public static ICollection<Account> FindByName(string name)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.Person.full_name.Equals(name)
            select account;

         return query.Count() > 0 ? query.ToList() : null;
      }

      public static ICollection<Account> FindByPosition(UserPosition @enum)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.Position.position_enum.Equals(@enum)
            select account;

         return query.Count() > 0 ? query.ToList() : null;
      }

      public static void Add(Account newAccount)
      {
         if (newAccount == null)
         {
            throw new System.ArgumentNullException(nameof(newAccount));
         }

         if (FindByUserName(newAccount.login) == null)
         {
            IQueryable<Position> query =
               from position in DBInstance.DataContext.Positions
               where position.position_enum == newAccount.Position.position_enum
               select position;

            if (query.Count() > 0)
            {
               newAccount.Position = query.First();
            }

            DBInstance.DataContext.Accounts.InsertOnSubmit(newAccount);
         }
      }

      public static void Delete(string userName)
      {
         if (userName == null)
         {
            throw new System.ArgumentNullException(nameof(userName));
         }

         Account account = FindByUserName(userName);
         if (account != null)
         {
            DBInstance.DataContext.Accounts.DeleteOnSubmit(account);

            if ((from reader in DBInstance.DataContext.Readers
                 where reader.id_personal_info == account.id_personal_info
                 select reader).Count() == 0)
            {
               DBInstance.DataContext.Persons.DeleteOnSubmit(account.Person);
            }
         }
      }

      public static void Edit(Account existingAccount)
      {
         if (existingAccount == null)
         {
            throw new System.ArgumentNullException(nameof(existingAccount));
         }

         Account account = FindById(existingAccount.id_account);

         account.login = existingAccount.login;
         account.password = existingAccount.password;

         account.Position =
            (from position in DBInstance.DataContext.Positions
             where position.position_enum == existingAccount.Position.position_enum
             select position).First();

         account.Person.full_name = existingAccount.Person.full_name;
         account.Person.address = existingAccount.Person.address;
         account.Person.birthday = existingAccount.Person.birthday;
         account.Person.phone = existingAccount.Person.phone;
      }

      public static void Save()
      {
         DBInstance.SubmitChanges();
      }
   }
}
