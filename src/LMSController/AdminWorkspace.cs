using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSController
{
    public class AdminWorkspace : IWorkspaceAdmin
    {
        private IUserInformationRegister adminAllowedOperations = new UserInformationRegister();

        public IUserInformationRegister GetUserInformationRegister()
        {
            return adminAllowedOperations;
        }
    }
}
