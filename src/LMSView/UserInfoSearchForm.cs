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
        public UserInfoSearchForm()
        {
            InitializeComponent();
        }

        private void AccountsBooksListControlPanel_Load(object sender, EventArgs e)
        {
            Text = Properties.Resources.adminWelcome;
            toolStripStatusLabelListControl.Text = Properties.Resources.statusStripAdminMain;
            buttonSearch.Text = Properties.Resources.search;
            buttonCreate.Text = Properties.Resources.create;
        }
        
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            using (UserInformationControlForm accountForm = new UserInformationControlForm(NViewHelper.FormViewMode.Edit))
            {
                accountForm.ShowDialog();
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            using (UserInformationControlForm accountForm = new UserInformationControlForm(NViewHelper.FormViewMode.Create))
            {
                accountForm.ShowDialog();
            }
        }
    }
}
