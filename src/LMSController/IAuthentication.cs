using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    delegate void LibrarianLogon(IWorkspaceLibrarian workspaceLibrarian);
    delegate void AdminLogon(IWorkspaceAdmin workspaceLibrarian);
    delegate void StockmanLogon(IWorkspaceStockman workspaceLibrarian);

    interface IAuthentication
    {
        void Authorize(CUserCredential userCredential);

        event LibrarianLogon OnLibrarianLogon;
        event AdminLogon OnAdminLogon;
        event StockmanLogon OnStockmanLogon;
    }
}
