using System;
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
                                           ClientInformation client = null)
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
         if (NViewHelper.FormViewMode.Edit == mViewMode)
         {
            clientInformationRegister.EditClient(PackageNewClientInfo(currentClient));
         }
         if (NViewHelper.FormViewMode.Create == mViewMode)
         {
            clientInformationRegister.AddClient(PackageNewClientInfo(new ClientInformation()));
         }
      }

      private ClientInformation PackageNewClientInfo(ClientInformation client)
      {
         client.LibraryTicketNumberCode = Convert.ToInt32(textBoxLibTicketNum.Text);

         PersonalInformation personInfo = new PersonalInformation()
         {
            FullName = textBoxName.Text,
            Birthday = dateTimePickerBirth.Value,
            Phone = Convert.ToDecimal(textBoxPhone.Text)
         };
         client.PersonalInformation = personInfo;

         return client;
      }
   }
}
