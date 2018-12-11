using System;
using System.Globalization;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class ClientPersonalInfoControlForm : Form
   {
      private NViewHelper.FormViewMode mViewMode;
      private readonly IClientInformationRegister clientInformationRegister;
      private ClientInformation currentClient;

      public ClientPersonalInfoControlForm(NViewHelper.FormViewMode mode,
                                           IClientInformationRegister register,
                                           ref ClientInformation client)
      {
         mViewMode = mode;
         clientInformationRegister = register;
         currentClient = client;

         InitializeComponent();
      }

      private void ReaderControlPanel_Paint(object sender, PaintEventArgs e)
      {
         labelLibTicketNum.Text = Properties.Resources.libraryNumTicket;
         labelName.Text = Properties.Resources.fullName;
         labelBirth.Text = Properties.Resources.birth;
         labelPhone.Text = Properties.Resources.phone;
         labelAddress.Text = Properties.Resources.address;

         buttonSave.Text = Properties.Resources.save;
         buttonDelete.Text = Properties.Resources.delete;
         if (NViewHelper.FormViewMode.Edit == mViewMode)
         {
            Text = Properties.Resources.clientEdit;
            textBoxLibTicketNum.Text = currentClient.LibraryTicketNumberCode.ToString(CultureInfo.CurrentCulture);
            textBoxName.Text = currentClient.PersonalInformation.FullName;
            textBoxPhone.Text = currentClient.PersonalInformation.Phone.ToString(CultureInfo.CurrentCulture);
            textBoxAddress.Text = currentClient.PersonalInformation.Address;
            dateTimePickerBirth.Value = currentClient.PersonalInformation.Birthday;
         }
         if (NViewHelper.FormViewMode.Create == mViewMode)
         {
            Text = Properties.Resources.clientCreate;
            labelLibTicketNum.Text = NViewHelper.ViewHelper.MarkFieldAsImportant(labelLibTicketNum.Text);
            labelName.Text = NViewHelper.ViewHelper.MarkFieldAsImportant(labelName.Text);
            labelBirth.Text = NViewHelper.ViewHelper.MarkFieldAsImportant(labelBirth.Text);
            labelPhone.Text = NViewHelper.ViewHelper.MarkFieldAsImportant(labelPhone.Text);
         }
      }

      private void ButtonSave_Click(object sender, EventArgs e)
      {
         if (NViewHelper.FormViewMode.Create == mViewMode)
         {
            currentClient = new ClientInformation();
            clientInformationRegister.Add(PackageNewClientInfo());
         }
         if (NViewHelper.FormViewMode.Edit == mViewMode)
         {
            clientInformationRegister.Edit(PackageNewClientInfo());
         }
         MessageBox.Show(Properties.Resources.successfull, Properties.Resources.save,
                         MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         Close();
      }

      private ClientInformation PackageNewClientInfo()
      {
         currentClient.LibraryTicketNumberCode = Convert.ToInt32(textBoxLibTicketNum.Text, CultureInfo.CurrentCulture);

         PersonalInformation personInfo = new PersonalInformation()
         {
            FullName = textBoxName.Text,
            Birthday = dateTimePickerBirth.Value,
            Phone = Convert.ToDecimal(textBoxPhone.Text, CultureInfo.CurrentCulture)
         };
         currentClient.PersonalInformation = personInfo;

         return currentClient;
      }

      private void ButtonDelete_Click(object sender, EventArgs e)
      {
         if (currentClient != null)
         {
            clientInformationRegister.Delete(currentClient);
            MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            Close();
         }
         else
         {
            MessageBox.Show(Properties.Resources.failed, Properties.Resources.delete,
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }

      }
   }
}
