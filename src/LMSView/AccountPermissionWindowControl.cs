using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Windows.Forms;
using System.Globalization;

namespace LMSView
{
    class AccountPermissionWindowControl
    {
        private Form mStartWindow;

        public AccountPermissionWindowControl(Form startupWindow)
        {
            mStartWindow = startupWindow;
        }

        private static NViewHelper.AccountMode checkPermission(string login)
        {
            if(true == String.Equals(Properties.Resources.librarian.ToLower(CultureInfo.CurrentCulture), login))
            {
                return NViewHelper.AccountMode.Library;
            }
            if(true == String.Equals(Properties.Resources. admin.ToLower(CultureInfo.CurrentCulture), login))
            {
                return NViewHelper.AccountMode.Admin;
            }
            if(true == String.Equals(Properties.Resources.stockman.ToLower(CultureInfo.CurrentCulture), login))
            {
                return NViewHelper.AccountMode.Stockman;
            }
            else
            {
                return NViewHelper.AccountMode.Library;
            }
        }

        public void Authorization(string login)
        {
            mStartWindow.Hide();

            NViewHelper.AccountMode userPermission = checkPermission(login);
            if(NViewHelper.AccountMode.Library == userPermission)
            {
                using (LibrarianControlPanel mLibraryManageWin = new LibrarianControlPanel())
                {
                    mLibraryManageWin.ShowDialog();
                }                
            }
            else
            {
                using (AccountsBooksListControlPanel mAdminStockmanManageWin = new AccountsBooksListControlPanel(userPermission))
                {
                    mAdminStockmanManageWin.ShowDialog();
                }
            };
            
            mStartWindow.Show();
        }
        
    }


}
