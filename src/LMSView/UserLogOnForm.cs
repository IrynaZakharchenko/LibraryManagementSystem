using System.Resources;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class UserLogOnForm : Form
   {
      private IAuthentication authenticationProcess;

      public UserLogOnForm()
      {
         InitializeComponent();
         authenticationProcess = new AuthenticationProcess();
         authenticationProcess.OnAdminLogOn += AuthorizeAdmin;
         authenticationProcess.OnLibrarianLogOn += AuthorizeLibrarian;
         authenticationProcess.OnStockmanLogOn += AuthorizeStockman;
         authenticationProcess.OnFailedLogOn += OnFailedLogOn;
      }

      private void ClearTextFields()
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

      private void ButtonlogOn_Click(object sender, System.EventArgs e)
      {
         authenticationProcess.Authorize(new UserCredential() { Name = textBoxLogin.Text, Password = textBoxPassword.Text });
         ClearTextFields();
         Activate();
      }

      public void AuthorizeLibrarian(IWorkspaceLibrarian workspaceLibrarian)
      {
         Hide();
         using (LibrarianControlForm mLibraryManageWin = new LibrarianControlForm(workspaceLibrarian))
         {
            mLibraryManageWin.ShowDialog();
         }
         Show();
      }

      public void AuthorizeAdmin(IWorkspaceAdmin workspaceAdmin)
      {
         Hide();
         if (workspaceAdmin != null)
         {
            using (UserInfoSearchForm mAdminManageWin = new UserInfoSearchForm(workspaceAdmin.UserInformationRegister))
            {
               mAdminManageWin.ShowDialog();
            }
         }
         Show();
      }

      public void AuthorizeStockman(IWorkspaceStockman workspaceStockman)
      {
         Hide();
         using (BookInfoSearchForm mStockmanManageWin = new BookInfoSearchForm(workspaceStockman))
         {
            mStockmanManageWin.ShowDialog();
         }
         Show();
      }

      public void OnFailedLogOn()
      {
         MessageBox.Show(Properties.Resources.errorLoginEmpty, Properties.Resources.logonFailed,
         MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
      }

   }
}
