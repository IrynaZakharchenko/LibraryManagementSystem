using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class LibrarianWorkspace : IWorkspaceLibrarian
    {
        public IBookFinding GetBookFinding()
        {
            throw new NotImplementedException();
        }

        public IClientInformationRegister GetClientInformationRegister()
        {
            throw new NotImplementedException();
        }
    }
}
