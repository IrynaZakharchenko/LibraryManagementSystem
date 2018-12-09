using System;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class ClientLibraryInfoControlForm : Form
   {
      //private readonly NViewHelper.FormViewMode viewMode;
      private readonly IClientInformationRegister clientInformationRegister;
      private ClientInformation currentClient;

      public ClientLibraryInfoControlForm(NViewHelper.FormViewMode mode, IClientInformationRegister register, ClientInformation client)
      {
         //viewMode = mode;
         clientInformationRegister = register;
         currentClient = client;

         InitializeComponent();
      }

      private void ButtonReturnBook_Click(object sender, EventArgs e)
      {
         if (listBoxClientBookCollection.SelectedItem != null)
         {
            BookInformation selectedBook = (BookInformation)listBoxClientBookCollection.SelectedItem;
            clientInformationRegister.ReturnBook(currentClient, selectedBook);
         }
         else
         {
            MessageBox.Show(Properties.Resources.uncheckedBook, Properties.Resources.failed,
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }
      }

      private void ButtonClientPersonal_Click(object sender, EventArgs e)
      {
         using (ClientPersonalInfoControlForm info = new ClientPersonalInfoControlForm(NViewHelper.FormViewMode.Edit,
                                                         clientInformationRegister, currentClient))
         {
            info.ShowDialog();
            Activate();
         }
      }
      private void ClientLibraryInfoControlForm_Load(object sender, EventArgs e)
      {
         labelClientTicketNum.Text = Properties.Resources.libraryNumTicket;
         labelClientName.Text = Properties.Resources.bookNum;
         labelBooksList.Text = Properties.Resources.bookList;
         buttonReturnBook.Text = Properties.Resources.returnBook;
         buttonClientPersonal.Text = Properties.Resources.personalInfo;

         dateTimePickerReturn.Value = DateTime.Now;
      }

      private void ListBoxClientBookCollection_SelectedIndexChanged(object sender, EventArgs e)
      {
         BookInformation selectedBook = (BookInformation)listBoxClientBookCollection.SelectedItem;
         //dateTimePickerGiveBook.Value = selectedBook.
      }
   }
}
