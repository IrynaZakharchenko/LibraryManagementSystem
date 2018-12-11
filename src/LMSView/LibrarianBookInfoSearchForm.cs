using System;
using System.Windows.Forms;
using LMSController;
using System.Globalization;

namespace LMSView
{
   partial class LibrarianBookInfoSearchForm : Form
   {
      private IClientInformationRegister clientInformationRegister;
      private ClientInformation currentClient;
      private BookInformation currentBook;
      private readonly ILibraryCardRegister libraryCardRegister;

      public LibrarianBookInfoSearchForm(IClientInformationRegister register, ILibraryCardRegister libraryCardRegister, ClientInformation client, BookInformation book)
      {
         clientInformationRegister = register;
         currentClient = client;
         currentBook = book;
         this.libraryCardRegister = libraryCardRegister;
         InitializeComponent();
      }

      private void LibrarianBookInfoSearchForm_Paint(object sender, PaintEventArgs e)
      {
         listBoxInventoryCodeNotAvailable.Enabled = false;

         buttonRentBook.Text = Properties.Resources.rentBook;

         labelInventoryCodeAvailable.Text = Properties.Resources.inventoryCodeAvailable;
         labelInventoryCodeNotAvailable.Text = Properties.Resources.inventoryCodeNotAvailable;
         labelTitle.Text = Properties.Resources.title;
         labelFullTitle.Text = Properties.Resources.fullTitle;
         labelAuthors.Text = Properties.Resources.author;
         labelIsbn.Text = Properties.Resources.isbn;
         labelLanguage.Text = Properties.Resources.language;
         labelPublishDate.Text = Properties.Resources.publishDate;
         labelSeries.Text = Properties.Resources.series;
         labelPublishHouse.Text = Properties.Resources.publishHouse;
         labelSubject.Text = Properties.Resources.subject;
         labelParentSubject.Text = Properties.Resources.parentSubject;
         labelAnnotation.Text = Properties.Resources.annotation;

         Text = Properties.Resources.rentBookWelcome;

         foreach (var code in currentBook.InventoryCode)
         {
            
            if (code.Value == false)
            {
               listBoxInventoryCodeAvailable.Items.Add(code.Key);
            }
            else
            {
               LibraryCard card = libraryCardRegister.GetLibraryCardByInventoryCode(code.Key);
               if (card.DateReturnBook.HasValue)
               {
                  listBoxInventoryCodeAvailable.Items.Add(code.Key);
               }
               else
               {  
                  listBoxInventoryCodeNotAvailable.Items.Add(code.Key);
               }
            }
         }
         textBoxTitle.Text = currentBook.Title;

         AuthorInformation[] authors = currentBook.Authors;
         foreach (var name in authors)
         {
            textBoxAuthors.Text += name.Name + Properties.Resources.separator;
         }
         textBoxFullTitle.Text = currentBook.FullTitle;
         textBoxIsbn.Text = currentBook.ISBN.ToString(CultureInfo.CurrentCulture);
         textBoxLanguage.Text = currentBook.Language;
         dateTimePickerPublish.Value = currentBook.PublishDate;
         textBoxPublishHouseResult.Text = currentBook.PublishHouse.Name;
         textBoxSeries.Text = currentBook.BookSeries;
         textBoxSubject.Text = currentBook.Subject.Name;
         if (currentBook.Subject.SubjectParent != null)
         {
            textBoxSubjectParent.Text = currentBook.Subject.SubjectParent.Name;
         }
         textBoxAnnotation.Text = currentBook.Annotation;

         textBoxTicketNum.Text = currentClient.LibraryTicketNumberCode.ToString();
         textBoxClientName.Text = currentClient.PersonalInformation.FullName;
         labelClientInfo.Text = Properties.Resources.clientInformation;
      }

      private void ButtonRentBook_Click(object sender, EventArgs e)
      {
         if (listBoxInventoryCodeAvailable.SelectedItem != null)
         {
            clientInformationRegister.RentBook(currentClient, Convert.ToInt32(listBoxInventoryCodeAvailable.SelectedItem));
         }
         else
         {
            MessageBox.Show(Properties.Resources.selectedInventoryCode, Properties.Resources.failed,
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }
      }
   }
}
