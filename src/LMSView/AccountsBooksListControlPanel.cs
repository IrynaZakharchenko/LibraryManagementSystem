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
    public partial class AccountsBooksListControlPanel : Form
    {
        private readonly NViewHelper.AccountMode mUserMode;

        public AccountsBooksListControlPanel(NViewHelper.AccountMode user)
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
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (NViewHelper.AccountMode.Stockman == mUserMode)
            {
                using (BookControlPanel bookForm = new BookControlPanel(NViewHelper.FormViewMode.View))
                {
                    bookForm.ShowDialog();
                }
            }
            else
            {
                using (AccountControlPanel accountForm = new AccountControlPanel(NViewHelper.FormViewMode.View))
                {
                    accountForm.ShowDialog();
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (NViewHelper.AccountMode.Stockman == mUserMode)
            {
                using (BookControlPanel bookForm = new BookControlPanel(NViewHelper.FormViewMode.Create))
                {
                    bookForm.ShowDialog();
                }
            }
            else
            {
                using (AccountControlPanel accountForm = new AccountControlPanel(NViewHelper.FormViewMode.Create))
                {
                    accountForm.ShowDialog();
                }
            }
        }
    }
}
