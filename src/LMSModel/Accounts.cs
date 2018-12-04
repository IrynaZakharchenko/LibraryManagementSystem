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
            DBInstance.DataContext.Accounts.InsertOnSubmit(newAccount);
         }
      }
      static public void Delete(string login)
      {
         Account account = FindByLogin(login);
         if (account != null)
         {
            DBInstance.DataContext.Accounts.DeleteOnSubmit(account);
         }
      }
      static public void Edit(Account existingAccount)
      {
         Account account = FindById(existingAccount.id_account);
         if (account != null)
         {
            account.login = existingAccount.login;
            account.password = existingAccount.password;
            account.Person = existingAccount.Person;
            account.Position = existingAccount.Position;

            DBInstance.DataContext.Accounts.InsertOnSubmit(existingAccount);
         }
      }
      static public void Save()
      {
         DBInstance.SubmitChanges();
      }
   }
}
