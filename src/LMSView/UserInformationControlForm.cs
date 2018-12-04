using System;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
    public partial class UserInformationControlForm : Form
    {
        private NViewHelper.FormViewMode viewMode;
        private readonly IUserInformationRegister userInformationRegister;
        private string userForSearch;

        public UserInformationControlForm(NViewHelper.FormViewMode mode, 
            IUserInformationRegister register, 
            string userSearch = null)
        {
            viewMode = mode;
            userInformationRegister = register;
            userForSearch = userSearch;
            InitializeComponent();
        }
       
        private void PrintForm()
        {
            Text = Properties.Resources.adminWelcome;
            buttonSave.Text = Properties.Resources.save;
            buttonDelete.Text = Properties.Resources.delete;
            comboBoxPosition.Items.AddRange(userInformationRegister.PossiblePositions());

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
            UserInformation userFind = new UserInformation();
            try
            {
                userFind = userInformationRegister.FindUser(userForSearch);
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show(Properties.Resources.userSearchNull, Properties.Resources.failed,
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            textBoxLogin.Text = userFind.Login;
            textBoxPassword.Text = userFind.Password;
            textBoxName.Text = userFind.PersonalInformation.FullName;
            dateTimeBirth.Value = userFind.PersonalInformation.Birthday;
            textBoxPhone.Text = userFind.PersonalInformation.Phone.ToString();
            textBoxAddress.Text = userFind.PersonalInformation.Address;
            comboBoxPosition.Text = userFind.Position;
        }

        static private string MarkFieldAsImportant(string field)
        {
            return Properties.Resources.importantFieldMark + field;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            userInformationRegister.DeleteUser(ExtractInputInformation());
            DialogResult result = MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (DialogResult.OK == result)
            {
                Close();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            DialogResult ?result;
            try
            {
                if (NViewHelper.FormViewMode.Edit == viewMode)
                {
                    userInformationRegister.EditUser(ExtractInputInformation());
                }
                if (NViewHelper.FormViewMode.Create == viewMode)
                {
                    userInformationRegister.AddUser(ExtractInputInformation());
                }

                result = MessageBox.Show(Properties.Resources.successfull, Properties.Resources.save,
                  MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                if (DialogResult.OK == result.Value)
                {
                    Close();
                }
            }
            catch(Exception ex)
            {
                result = MessageBox.Show(ex.Message, Properties.Resources.failed,
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
        }

        private UserInformation ExtractInputInformation()
        {
            UserInformation newUserInformation = new UserInformation();
            newUserInformation.Login = textBoxLogin.Text;
            newUserInformation.Password = textBoxPassword.Text;
            newUserInformation.Position = comboBoxPosition.SelectedItem.ToString();
            PersonalInformation personInfo = new PersonalInformation();
            personInfo.FullName = textBoxName.Text;
            personInfo.Birthday = dateTimeBirth.Value;
            personInfo.Phone = Convert.ToDecimal(textBoxPhone.Text);
            personInfo.Address = textBoxAddress.Text;
            newUserInformation.PersonalInformation = personInfo;

            return newUserInformation;
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
