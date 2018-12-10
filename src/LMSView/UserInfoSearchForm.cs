using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class UserInfoSearchForm : Form
   {
      private readonly IUserInformationRegister userInformationRegister;

      public UserInfoSearchForm(IUserInformationRegister userRegister)
      {
         userInformationRegister = userRegister;

         InitializeComponent();
      }

      private void ButtonSearch_Click(object sender, EventArgs e)
      {
         try
         {
            string search = textBoxSearch.Text;
            if (false == String.IsNullOrEmpty(search))
            {
               UserInformation user = userInformationRegister.FindByName(search);
               if (user != null)
               {
                  using (UserInformationControlForm accountForm = new UserInformationControlForm(NViewHelper.FormViewMode.Edit, userInformationRegister, user))
                  {
                     accountForm.ShowDialog();
                  }
               }
               else
               {
                  DialogResult result = MessageBox.Show(search + Properties.Resources.userSearchFailed, Properties.Resources.failed,
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                  if(DialogResult.Yes == result)
                  {
                     using (UserInformationControlForm accountForm = new UserInformationControlForm(NViewHelper.FormViewMode.Create, userInformationRegister))
                     {
                        accountForm.ShowDialog();
                     }
                  }
               }
               Activate();
            }
            else
            {
               MessageBox.Show(Properties.Resources.userSearchEmpty, Properties.Resources.failed,
               MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
         }
         catch (InvalidOperationException)
         {
            MessageBox.Show(Properties.Resources.userSearchFailed, Properties.Resources.failed,
               MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }
      }

      private void ButtonCreate_Click(object sender, EventArgs e)
      {
         using (UserInformationControlForm accountForm = new UserInformationControlForm(NViewHelper.FormViewMode.Create, userInformationRegister))
         {
            accountForm.ShowDialog();
            Activate();
         }
      }

      private void UserInfoSearchForm_Load(object sender, EventArgs e)
      {
         Text = Properties.Resources.adminWelcome;
         toolStripStatusLabelListControl.Text = Properties.Resources.statusStripAdminMain;
         buttonSearch.Text = Properties.Resources.search;
         buttonCreate.Text = Properties.Resources.create;
      }
   }
}
