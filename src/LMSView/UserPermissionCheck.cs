using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Windows.Forms;
using System.Globalization;
using LMSController;

namespace LMSView
{
    class UserPermissionCheck
    {
        private UserLogOnForm mStartWindow;
        private AuthenticationProcess authenticationProcess;

        public UserPermissionCheck(UserLogOnForm startupWindow)
        {
            mStartWindow = startupWindow;
            authenticationProcess = new AuthenticationProcess();
            authenticationProcess.OnAdminLogOn += AuthorizeAdmin;
            authenticationProcess.OnLibrarianLogOn += AuthorizeLibrarian;
            authenticationProcess.OnStockmanLogOn += AuthorizeStockman;
        }

        public void AuthorizeLibrarian(IWorkspaceLibrarian workspaceLibrarian)
        {
            mStartWindow.Hide();
            using (LibrarianControlForm mLibraryManageWin = new LibrarianControlForm())
            {
                mLibraryManageWin.ShowDialog();
            }
            mStartWindow.ClearTextFields();
            mStartWindow.Show();
        }

        public void AuthorizeAdmin(IWorkspaceAdmin workspaceAdmin)
        {
            mStartWindow.Hide();
            using (UserInfoSearchForm mAdminManageWin = new UserInfoSearchForm(workspaceAdmin))
            {
                mAdminManageWin.ShowDialog();
            }
            mStartWindow.ClearTextFields();
            mStartWindow.Show();
        }

        public void AuthorizeStockman(IWorkspaceStockman workspaceStockman)
        {
            mStartWindow.Hide();
            using (BookInfoSearchForm mStockmanManageWin = new BookInfoSearchForm())
            {
                mStockmanManageWin.ShowDialog();
            }
            mStartWindow.ClearTextFields();
            mStartWindow.Show();
        }
        
        public void Authorization(string login, string password)
        {
            authenticationProcess.Authorize(new UserCredential(login, password));
        }
        
    }


}
