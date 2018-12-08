using LMSModel;
using System;

namespace LMSController
{
   public class AuthenticationProcess : IAuthentication
   {
      public event LibrarianLogOnEventHandler OnLibrarianLogOn;
      public event AdminLogOnEventHandler OnAdminLogOn;
      public event StockmanLogOnEventHandler OnStockmanLogOn;
      public event FailedLogOnEventHandler OnFailedLogOn;

      public void Authorize(UserCredential userCredential)
      {
         if (userCredential == null)
         {
            throw new ArgumentNullException(nameof(userCredential));
         }

         Account account = Accounts.FindByUserNameAndPassword(userCredential.Name, userCredential.Password);
         
         if (null != account)
         {
            switch (account.Position.position_enum)
            {
               case UserPosition.Librarian:
                  OnLibrarianLogOn(new LibrarianWorkspace());
                  break;
               case UserPosition.Administrator:
                  OnAdminLogOn(new AdminWorkspace());
                  break;
               case UserPosition.Stockman:
                  OnStockmanLogOn(new StockmanWorkspace());
                  break;
               default:
                  throw new InvalidOperationException(account.Position.position_enum.ToString());
            }
         }
         else
         {
            OnFailedLogOn();
         }
      }
   }
}
