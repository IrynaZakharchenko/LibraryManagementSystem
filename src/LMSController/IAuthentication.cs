using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public delegate void LibrarianLogOnEventHandler(IWorkspaceLibrarian workspaceLibrarian);
    public delegate void AdminLogOnEventHandler(IWorkspaceAdmin workspaceLibrarian);
    public delegate void StockmanLogOnEventHandler(IWorkspaceStockman workspaceLibrarian);

    public interface IAuthentication
    {
        void Authorize(UserCredential userCredential);

        event LibrarianLogOnEventHandler OnLibrarianLogOn;
        event AdminLogOnEventHandler OnAdminLogOn;
        event StockmanLogOnEventHandler OnStockmanLogOn;
    }
}
