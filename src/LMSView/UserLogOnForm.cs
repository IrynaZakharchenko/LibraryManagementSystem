using System.Resources;
using System.Windows.Forms;

namespace LMSView
{
    public partial class UserLogOnForm : Form
    {
        private UserPermissionCheck managerForms;
        private const int countLogonAttempts = 5;

        public UserLogOnForm()
        {
            InitializeComponent();
            managerForms = new UserPermissionCheck(this);
        }

        public void ClearTextFields()
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        private void UserLogOnForm_Load(object sender, System.EventArgs e)
        {
            Text = Properties.Resources.welcome;

            buttonlogOn.Text = Properties.Resources.logon;
            labelLogin.Text = Properties.Resources.login;
            labelLogin.Dock = DockStyle.Fill;
            labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            labelPassword.Text = Properties.Resources.password;
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTipsLogon.SetToolTip(textBoxLogin, Properties.Resources.tipsLogin);
            toolTipsLogon.SetToolTip(textBoxPassword, Properties.Resources.tipsPassword);
            toolStripStatusLabelLogOn.Text = Properties.Resources.statusStripLogOn;
        }

        private void buttonlogOn_Click(object sender, System.EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            if (false == string.IsNullOrEmpty(login))
            {
                
                managerForms.Authorization(login, password);
            }
            else
            {
                MessageBox.Show(Properties.Resources.errorLoginEmpty, Properties.Resources.logonFailed,
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            Activate();
        }
    }
}
