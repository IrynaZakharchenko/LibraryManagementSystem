using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public delegate void LibrarianLogon(IWorkspaceLibrarian workspaceLibrarian);
    public delegate void AdminLogon(IWorkspaceAdmin workspaceLibrarian);
    public delegate void StockmanLogon(IWorkspaceStockman workspaceLibrarian);

    public interface IAuthentication
    {
        void Authorize(CUserCredential userCredential);

        event LibrarianLogon OnLibrarianLogon;
        event AdminLogon OnAdminLogon;
        event StockmanLogon OnStockmanLogon;
    }
}
