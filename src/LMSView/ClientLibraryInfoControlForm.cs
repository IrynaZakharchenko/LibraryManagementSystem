using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class ClientLibraryInfoControlForm : Form
   {
      private readonly ILibraryCardRegister libraryCardRegister;
      private readonly IClientInformationRegister clientInformationRegister;
      private readonly IBookFinding bookFinding;
      private ClientInformation currentClient;

      public ClientLibraryInfoControlForm(ILibraryCardRegister libraryRegister,
                                          IClientInformationRegister clientRegister,
                                          IBookFinding finding,
                                          ClientInformation client)
      {
         libraryCardRegister = libraryRegister;
         clientInformationRegister = clientRegister;
         bookFinding = finding;
         currentClient = client;

         InitializeComponent();
      }

      private void ClientLibraryInfoControlForm_Load(object sender, EventArgs e)
      {
         labelClientTicketNum.Text = Properties.Resources.libraryNumTicket;
         textBoxTicketNum.Text = currentClient.LibraryTicketNumberCode.ToString(CultureInfo.CurrentCulture);
         labelClientName.Text = Properties.Resources.bookNum;
         textBoxClientName.Text = currentClient.PersonalInformation.FullName;
         labelBooksList.Text = Properties.Resources.bookList;
         buttonClientPersonal.Text = Properties.Resources.personalInfo;

         buttonReturnBook.Text = Properties.Resources.returnBook;
         dateTimePickerReturn.Visible = false;
         dateTimePickerGiveBook.Visible = false;

         ICollection<LibraryCard> libraryCards = libraryCardRegister.GetLibraryCardsByTicketNum(currentClient.LibraryTicketNumberCode);
         foreach (var card in libraryCards)
         {
            BookInformation book = bookFinding.FindBookByInventoryCode(card.CodeRentedBook);
            listBoxClientBookCollection.Items.Add(book.Title);
         }
         listBoxClientBookCollection.SelectedIndex = 0;
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

      private void ListBoxClientBookCollection_SelectedValueChanged(object sender, EventArgs e)
      {
         string title = listBoxClientBookCollection.SelectedValue as string;
         BookInformation book = bookFinding.FindBookByTitle(title);
         LibraryCard currentCard = libraryCardRegister.GetLibraryCardByBookTitle(book.Title);

         dateTimePickerGiveBook.Visible = true;
         dateTimePickerGiveBook.Value = currentCard.DateRentBook;
      }
   }
}
