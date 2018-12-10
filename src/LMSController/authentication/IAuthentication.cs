namespace LMSController
{
   public delegate void LibrarianLogOnEventHandler(IWorkspaceLibrarian workspaceLibrarian);
   public delegate void AdminLogOnEventHandler(IWorkspaceAdmin workspaceLibrarian);
   public delegate void StockmanLogOnEventHandler(IWorkspaceStockman workspaceLibrarian);
   public delegate void FailedLogOnEventHandler();

   public interface IAuthentication
   {
      void Authorize(UserCredential userCredential);

      event LibrarianLogOnEventHandler OnLibrarianLogOn;
      event AdminLogOnEventHandler OnAdminLogOn;
      event StockmanLogOnEventHandler OnStockmanLogOn;
      event FailedLogOnEventHandler OnFailedLogOn;
   }
}
