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
   }
}
