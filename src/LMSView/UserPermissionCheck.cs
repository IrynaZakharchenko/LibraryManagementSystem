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
    class UserPermissionCheck
    {
        private Form mStartWindow;

        public UserPermissionCheck(Form startupWindow)
        {
            mStartWindow = startupWindow;
        }

        private static NViewHelper.AccountMode CheckPermission(string login)
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

            NViewHelper.AccountMode userPermission = CheckPermission(login);
            if(NViewHelper.AccountMode.Library == userPermission)
            {
                using (LibrarianControlForm mLibraryManageWin = new LibrarianControlForm())
                {
                    mLibraryManageWin.ShowDialog();
                }                
            }
            else
            {
                using (UserInfoSearchForm mAdminStockmanManageWin = new UserInfoSearchForm(userPermission))
                {
                    mAdminStockmanManageWin.ShowDialog();
                }
            };
            
            mStartWindow.Show();
        }
        
    }


}
