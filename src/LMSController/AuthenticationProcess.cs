using LMSModel;

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
         Account account = Accounts.FindByLoginAndPassword(userCredential.Login, userCredential.Password);
         
         if (null != account)
         {
            switch (account.Position.position_enum)
            {
               case PositionEnum.Librarian:
                  OnLibrarianLogOn(new LibrarianWorkspace());
                  break;
               case PositionEnum.Administrator:
                  OnAdminLogOn(new AdminWorkspace());
                  break;
               case PositionEnum.Stockman:
                  OnStockmanLogOn(new StockmanWorkspace());
                  break;
            }
         }
         else
         {
            OnFailedLogOn();
         }
      }
   }
}
