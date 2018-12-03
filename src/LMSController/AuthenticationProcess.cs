using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class AuthenticationProcess : IAuthentication
    {
        public event LibrarianLogOnEventHandler OnLibrarianLogOn;
        public event AdminLogOnEventHandler OnAdminLogOn;
        public event StockmanLogOnEventHandler OnStockmanLogOn;

        public void Authorize(UserCredential userCredential)
        {
            if(null != userCredential)
            {
                switch (userCredential.Login)
                {
                    case "librarian":
                        OnLibrarianLogOn(new LibrarianWorkspace());
                        break;
                    case "admin":
                        OnAdminLogOn(new AdminWorkspace());
                        break;
                    case "stockman":
                        OnStockmanLogOn(new StockmanWorkspace());
                        break;
                }
            }
        }
    }
}
