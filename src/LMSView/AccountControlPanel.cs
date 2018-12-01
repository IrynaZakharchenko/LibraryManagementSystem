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
    public partial class AccountControlPanel : Form
    {
        private NViewHelper.FormViewMode viewMode;

        public AccountControlPanel(NViewHelper.FormViewMode mode)
        {
            viewMode = mode;
            InitializeComponent();
        }
        
        private void AccountControlPanel_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabelAccounts.Text = Properties.Resources.statusStripControlAdmin;

            PrintForm();
            switch (viewMode)
            {
                case NViewHelper.FormViewMode.View:
                    ApplySimpleViewMode();
                    break;
                case NViewHelper.FormViewMode.Create:
                    ApplyCreateViewMode();
                    break;
                case NViewHelper.FormViewMode.Modify:
                    ApplyModifyViewMode();
                    break;
            }
        }

        private void PrintForm()
        {
            Text = Properties.Resources.adminWelcome;
            labelLogin.Text = Properties.Resources.login;
            labelPassword.Text = Properties.Resources.password;
            labelBirth.Text = Properties.Resources.birth;
            labelName.Text = Properties.Resources.fullName;
            labelPhone.Text = Properties.Resources.phone;
            labelAddress.Text = Properties.Resources.address;
            labelPosition.Text = Properties.Resources.position;
        }
        private void ApplySimpleViewMode()
        {
            buttonModify.Text = Properties.Resources.edit;
            buttonDelete.Text = Properties.Resources.delete;

            textBoxLogin.ReadOnly = true;
            textBoxPassword.ReadOnly = true;
            textBoxName.ReadOnly = true;
            textBoxPhone.ReadOnly = true;
            textBoxAddress.ReadOnly = true;
        }

        private void ApplyModifyViewMode()
        {
            buttonModify.Text = Properties.Resources.save;
            buttonDelete.Text = Properties.Resources.reset;

            textBoxLogin.ReadOnly = false;
            textBoxPassword.ReadOnly = false;
            textBoxName.ReadOnly = false;
            textBoxPhone.ReadOnly = false;
            textBoxAddress.ReadOnly = false;
        }
        
        private void ApplyCreateViewMode()
        {
            Text = Properties.Resources.adminWelcome;
            labelLogin.Text = MarkFieldAsImportant(labelLogin.Text);
            labelPassword.Text = MarkFieldAsImportant(labelPassword.Text);
            labelBirth.Text = MarkFieldAsImportant(labelBirth.Text);
            labelName.Text = MarkFieldAsImportant(labelName.Text);
            labelPhone.Text = MarkFieldAsImportant(labelPhone.Text);
            labelPosition.Text = MarkFieldAsImportant(labelPosition.Text);

            buttonModify.Text = Properties.Resources.save;
            buttonDelete.Text = Properties.Resources.reset;

        }
        
        static private string MarkFieldAsImportant(string field)
        {
            return Properties.Resources.importantFieldMark + field;
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (NViewHelper.FormViewMode.View == viewMode)
            {
                viewMode = NViewHelper.FormViewMode.Modify;
                Invalidate();
            }
            else
            {
                MessageBox.Show(Properties.Resources.successfull, Properties.Resources.save + Properties.Resources.accountInfo,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult userConfirm = MessageBox.Show(Properties.Resources.deleteConfirm + Properties.Resources.accountInfo, Properties.Resources.delete,
               MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (DialogResult.OK == userConfirm)
            {
                MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
        }

        
    }

}
