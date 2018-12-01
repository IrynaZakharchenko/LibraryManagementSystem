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
    public partial class UserInformationControlForm : Form
    {
        private NViewHelper.FormViewMode viewMode;

        public UserInformationControlForm(NViewHelper.FormViewMode mode)
        {
            viewMode = mode;
            InitializeComponent();
        }
       
        private void PrintForm()
        {
            Text = Properties.Resources.adminWelcome;
            buttonSave.Text = Properties.Resources.save;
            buttonDelete.Text = Properties.Resources.delete;

            labelLogin.Text = Properties.Resources.login;
            labelPassword.Text = Properties.Resources.password;
            labelBirth.Text = Properties.Resources.birth;
            labelName.Text = Properties.Resources.fullName;
            labelPhone.Text = Properties.Resources.phone;
            labelAddress.Text = Properties.Resources.address;
            labelPosition.Text = Properties.Resources.position;
        }

        private void ApplyCreateViewMode()
        {
            labelLogin.Text = MarkFieldAsImportant(labelLogin.Text);
            labelPassword.Text = MarkFieldAsImportant(labelPassword.Text);
            labelBirth.Text = MarkFieldAsImportant(labelBirth.Text);
            labelName.Text = MarkFieldAsImportant(labelName.Text);
            labelPhone.Text = MarkFieldAsImportant(labelPhone.Text);
            labelPosition.Text = MarkFieldAsImportant(labelPosition.Text);
        }
        
        static private string MarkFieldAsImportant(string field)
        {
            return Properties.Resources.importantFieldMark + field;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.successfull, Properties.Resources.save,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

        }

        private void UserInformationControlForm_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabelAccounts.Text = Properties.Resources.statusStripControlAdmin;

            PrintForm();
            if (NViewHelper.FormViewMode.Create == viewMode)
            {
                ApplyCreateViewMode();
            }
        }
    }

}
