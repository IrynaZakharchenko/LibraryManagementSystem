using System.Collections.Generic;
using System.Linq;

namespace LMSModel
{
   public static class Accounts
   {
      static public Account FindByLoginAndPassword(string login, string password)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.login.Equals(login)
            where account.password.Equals(password)
            select account;

         return query.Count() > 0 ? query.First() : null;
      }
      static public Account FindByLogin(string login)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.login.Equals(login)
            select account;

         return query.Count() > 0 ? query.First() : null;
      }
      static public Account FindById(int id)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.id_account == id
            select account;

         return query.Count() > 0 ? query.First() : null;
      }
      static public List<Account> FindByName(string name)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.Person.full_name.Equals(name)
            select account;

         return query.Count() > 0 ? query.ToList() : null;
      }
      static public List<Account> FindByPosition(PositionEnum @enum)
      {
         IQueryable<Account> query =
            from account in DBInstance.DataContext.Accounts
            where account.Position.position_enum.Equals(@enum)
            select account;

         return query.Count() > 0 ? query.ToList() : null;
      }
      static public void Add(Account newAccount)
      {
         if (FindByLogin(newAccount.login) == null)
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
      static public void Delete(string login)
      {
         Account account = FindByLogin(login);
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
      static public void Edit(Account existingAccount)
      {
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
      static public void Save()
      {
         DBInstance.SubmitChanges();
      }
   }
}
