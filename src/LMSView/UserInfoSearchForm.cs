using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSView
{
    public partial class UserInfoSearchForm : Form
    {
        private readonly NViewHelper.AccountMode mUserMode;

        public UserInfoSearchForm(NViewHelper.AccountMode user)
        {
            mUserMode = user;
            InitializeComponent();
        }

        private void AccountsBooksListControlPanel_Load(object sender, EventArgs e)
        {
            if(NViewHelper.AccountMode.Stockman == mUserMode)
            {
                Text = Properties.Resources.stockmanWelcome;
                toolStripStatusLabelListControl.Text = Properties.Resources.statusStripStockmanMain;
            }
            else
            {
                Text = Properties.Resources.adminWelcome;
                toolStripStatusLabelListControl.Text = Properties.Resources.statusStripAdminMain;
            }
            buttonSearch.Text = Properties.Resources.search;
            buttonCreate.Text = Properties.Resources.create;
        }
        
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (NViewHelper.AccountMode.Stockman == mUserMode)
            {
                using (BookInfoControlForm bookForm = new BookInfoControlForm(NViewHelper.FormViewMode.Edit))
                {
                    bookForm.ShowDialog();
                }
            }
            else
            {
                using (UserInformationControlForm accountForm = new UserInformationControlForm(NViewHelper.FormViewMode.Edit))
                {
                    accountForm.ShowDialog();
                }
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (NViewHelper.AccountMode.Stockman == mUserMode)
            {
                using (BookInfoControlForm bookForm = new BookInfoControlForm(NViewHelper.FormViewMode.Create))
                {
                    bookForm.ShowDialog();
                }
            }
            else
            {
                using (UserInformationControlForm accountForm = new UserInformationControlForm(NViewHelper.FormViewMode.Create))
                {
                    accountForm.ShowDialog();
                }
            }
        }
    }
}
