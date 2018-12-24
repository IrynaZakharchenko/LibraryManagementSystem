using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class ClientLibraryInfoControlForm : Form
   {
      private readonly IWorkspaceLibrarian workspaceLibrarian;
      private ClientInformation currentClient;

      public ClientLibraryInfoControlForm(IWorkspaceLibrarian workspace,
                                          ref ClientInformation client)
      {
         workspaceLibrarian = workspace;
         currentClient = client;

         InitializeComponent();
      }

      private void ClientLibraryInfoControlForm_Load(object sender, EventArgs e)
      {
			Text = Properties.Resources.librarianClientWindow;
         labelClientTicketNum.Text = Properties.Resources.libraryNumTicket;
         textBoxTicketNum.Text = currentClient.LibraryTicketNumberCode.ToString(CultureInfo.CurrentCulture);
         labelClientName.Text = Properties.Resources.client;
         textBoxClientName.Text = currentClient.PersonalInformation.FullName;
         labelBooksList.Text = Properties.Resources.bookList;
         buttonClientPersonal.Text = Properties.Resources.personalInfo;
         labelDateGetBook.Text = Properties.Resources.dateGetBook;
         labelDateGiveBook.Text = Properties.Resources.dateGiveBook;
         buttonReturnBook.Text = Properties.Resources.returnBook;
         dateTimePickerReturn.Visible = false;
         dateTimePickerGiveBook.Visible = false;

         ICollection<LibraryCard> libraryCards = workspaceLibrarian.LibraryCardRegister.GetLibraryCardsByTicketNum(currentClient.LibraryTicketNumberCode);
         if (libraryCards != null)
         {
            foreach (var card in libraryCards)
            {
               listBoxClientBookCollection.Items.Add(card.CodeRentedBook);
            }
         }
      }

      private void ButtonReturnBook_Click(object sender, EventArgs e)
      {
         if (listBoxClientBookCollection.SelectedItem != null)
         {
            int selectedBookCode = Convert.ToInt32(listBoxClientBookCollection.SelectedItem, CultureInfo.CurrentCulture);

            workspaceLibrarian.ClientInformationRegister.ReturnBook(selectedBookCode);
            listBoxClientBookCollection.Items.Remove(listBoxClientBookCollection.SelectedItem);
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
                                                         workspaceLibrarian.ClientInformationRegister, ref currentClient))
         {
            info.ShowDialog();
            Activate();
         }
      }

      private void ListBoxClientBookCollection_SelectedValueChanged(object sender, EventArgs e)
      {
         if (listBoxClientBookCollection.SelectedItem != null)
         {
            int inventoryCode = Convert.ToInt32(listBoxClientBookCollection.SelectedItem);
            LibraryCard currentCard = workspaceLibrarian.LibraryCardRegister.GetLibraryCardByInventoryCode(inventoryCode);

            dateTimePickerGiveBook.Visible = true;
            dateTimePickerGiveBook.Value = currentCard.DateRentBook;
            if (currentCard.DateReturnBook.HasValue)
            {
               dateTimePickerReturn.Visible = true;
               dateTimePickerReturn.Value = currentCard.DateReturnBook.Value;
            }
            else
            {
               dateTimePickerReturn.Visible = false;
            }
         }

      }
   }
}
