using System;
using System.Globalization;
using System.Windows.Forms;
using LMSController;
using LMSView.NViewHelper;

namespace LMSView
{
   public partial class UserInformationControlForm : Form
   {
      private NViewHelper.FormViewMode viewMode;
      private readonly IUserInformationRegister userInformationRegister;
      private UserInformation currentUser;

      public UserInformationControlForm(NViewHelper.FormViewMode mode,
          IUserInformationRegister register,
          UserInformation findedUser = null)
      {
         viewMode = mode;
         userInformationRegister = register;
         currentUser = findedUser;
         InitializeComponent();
      }

      private void PrintForm()
      {
         Text = Properties.Resources.adminWelcome;
         buttonSave.Text = Properties.Resources.save;
         buttonDelete.Text = Properties.Resources.delete;
         if (comboBoxPosition.Items.Count == 0)
         {
            comboBoxPosition.Items.AddRange(userInformationRegister.GetPossiblePositions());
         }

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

      private void ApplyEditViewMode()
      {
         textBoxLogin.Text = currentUser.Credential.Name;
         textBoxPassword.Text = currentUser.Credential.Password;
         textBoxName.Text = currentUser.PersonalInformation.FullName;
         dateTimeBirth.Value = currentUser.PersonalInformation.Birthday;
         textBoxPhone.Text = currentUser.PersonalInformation.Phone.ToString(CultureInfo.CurrentCulture);
         textBoxAddress.Text = currentUser.PersonalInformation.Address;
         comboBoxPosition.Text = currentUser.Position;
      }

      static private string MarkFieldAsImportant(string field)
      {
         return Properties.Resources.importantFieldMark + field;
      }

      private void ButtonDelete_Click(object sender, EventArgs e)
      {
         DialogResult result;
         if (NViewHelper.FormViewMode.Edit == viewMode)
         {
            userInformationRegister.Delete(currentUser);

            result = MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
                     MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            if (DialogResult.OK == result)
            {
               Close();
            }
         }
         else
         {
            result = MessageBox.Show(Properties.Resources.userDeleteFailed, Properties.Resources.delete,
                     MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }
			Activate();
		}

		private void ButtonSave_Click(object sender, EventArgs e)
      {
         try
         {
            if (NViewHelper.FormViewMode.Edit == viewMode)
            {
               userInformationRegister.Edit(ExtractInputInformation(currentUser));
            }
            if (NViewHelper.FormViewMode.Create == viewMode)
            {
               userInformationRegister.Add(ExtractInputInformation(new UserInformation()));
            }
            MessageBox.Show(Properties.Resources.successfull, Properties.Resources.save,
                     MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            Close();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, Properties.Resources.failed,
            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
				Activate();
			}
		}

      private UserInformation ExtractInputInformation(UserInformation userInformation)
      {
         userInformation.Credential = new UserCredential()
         {
            Name = textBoxLogin.Text,
            Password = textBoxPassword.Text
         };
         userInformation.Position = comboBoxPosition.SelectedItem.ToString();
         userInformation.PersonalInformation = new PersonalInformation
         {
            FullName = textBoxName.Text,
            Birthday = dateTimeBirth.Value,
            Phone = Convert.ToDecimal(textBoxPhone.Text, CultureInfo.CurrentCulture),
            Address = textBoxAddress.Text
         };

         return userInformation;
      }

      private void UserInformationControlForm_Paint(object sender, PaintEventArgs e)
      {
         toolStripStatusLabelAccounts.Text = Properties.Resources.statusStripControlAdmin;

         PrintForm();
         if (NViewHelper.FormViewMode.Create == viewMode)
         {
            ApplyCreateViewMode();
         }
         if (NViewHelper.FormViewMode.Edit == viewMode)
         {
            ApplyEditViewMode();
         }
      }
   }

}
