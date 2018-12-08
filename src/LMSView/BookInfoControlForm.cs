using System;
using System.Windows.Forms;
using LMSView.NViewHelper;
using LMSController;
using System.Collections.Generic;

namespace LMSView
{
   partial class BookInfoControlForm : Form
   {
      private FormViewMode viewMode;
      private BookInformation currentBook;
      private ILibraryOperations libraryManagment;

      PublishHouseInformationRegister publishHouseRegister = new PublishHouseInformationRegister();
      SubjectInformationFinding SubjectFinding = new SubjectInformationFinding();

      public BookInfoControlForm(FormViewMode mode, ILibraryOperations libraryOperations, BookInformation book = null)
      {
         viewMode = mode;
         currentBook = book;
         libraryManagment = libraryOperations;

         InitializeComponent();
      }

      private void ButtonSave_Click(object sender, EventArgs e)
      {
         if (FormViewMode.Create == viewMode)
         {
            currentBook = new BookInformation();
         }
         libraryManagment.AddBook(PackageBookInformation(currentBook));
      }

      private void ButtonDelete_Click(object sender, EventArgs e)
      {
         if (FormViewMode.Edit == viewMode)
         {
            libraryManagment.DeleteBook(currentBook);
         }
      }

      private void BookControlPanel_Paint(object sender, PaintEventArgs e)
      {
         PrintForm();

         if (FormViewMode.Edit == viewMode)
         {
            Text = Properties.Resources.editBook;

            foreach (var code in currentBook.InventoryCode)
            {
               listBoxInventoryCode.Items.Add(code);
            }

            textBoxTitle.Text = currentBook.Title;

            AuthorInformation[] authors = currentBook.Authors;
            foreach (var name in authors)
            {
               textBoxAuthors.Text += " " + name.Name;
            }
            textBoxFullTitle.Text = currentBook.FullTitle;
            textBoxIsbn.Text = currentBook.Isbn.ToString();
            textBoxLanguage.Text = currentBook.Language;
            dateTimePickerPublish.Value = currentBook.PublishDate;
            textBoxPublishHouseResult.Text = currentBook.PublishHouse.Name;
            textBoxSeries.Text = currentBook.BookSeries;
            textBoxSubject.Text = currentBook.Subject.Name;
            textBoxSubjectParent.Text = currentBook.Subject.SubjectParent.Name;
            textBoxAnnotation.Text = currentBook.Annotation;
         }
         if (FormViewMode.Create == viewMode)
         {
            Text = Properties.Resources.createBook;

            labelTitle.Text = ViewHelper.MarkFieldAsImportant(labelTitle.Text);
            labelInventoryCode.Text = ViewHelper.MarkFieldAsImportant(labelInventoryCode.Text);
            labelAuthors.Text = ViewHelper.MarkFieldAsImportant(labelAuthors.Text);
            labelIsbn.Text = ViewHelper.MarkFieldAsImportant(labelIsbn.Text);
            labelLanguage.Text = ViewHelper.MarkFieldAsImportant(labelLanguage.Text);
            labelPublishDate.Text = ViewHelper.MarkFieldAsImportant(labelPublishDate.Text);
            labelPublishHouse.Text = ViewHelper.MarkFieldAsImportant(labelPublishHouse.Text);
         }
      }

      private BookInformation PackageBookInformation(BookInformation book)
      {
         List<int> listInventoryCodes = new List<int>();
         foreach (var code in listBoxInventoryCode.Items) 
         {
            listInventoryCodes.Add(Convert.ToInt32(code));
         };
         book.InventoryCode = listInventoryCodes.ToArray();
         book.Title = textBoxTitle.Text;
         book.FullTitle = textBoxFullTitle.Text;
         book.Isbn = Convert.ToInt16(textBoxIsbn.Text);
         book.Language = textBoxLanguage.Text;
         book.PublishHouse = publishHouseRegister.FindPublishHouseByName(textBoxPublishHouseResult.Text);
         book.PublishDate = dateTimePickerPublish.Value;
         book.Annotation = textBoxAnnotation.Text;
         string[] authorsNames = textBoxAuthors.Text.Split(new char[] { ',', ' ' });
         List<AuthorInformation> authors = new List<AuthorInformation>();
         foreach (string name in authorsNames)
         {
            authors.Add(new AuthorInformation(name));
         }
         book.Authors = authors.ToArray();
         SubjectInformationFinding subjectFinding = new SubjectInformationFinding();
         book.Subject = subjectFinding.FindByName(textBoxSubject.Text);
         book.Subject.SubjectParent = subjectFinding.FindByName(textBoxSubjectParent.Text);

         return book;
      }

      private void PrintForm()
      {
         buttonSave.Text = Properties.Resources.save;
         buttonDelete.Text = Properties.Resources.delete;
         buttonSearchPublishHouse.Text = Properties.Resources.search;
         buttonAddInventoryCode.Text = Properties.Resources.add;
         buttonDeleteInventoryCode.Text = Properties.Resources.delete;
         buttonEditInventoryCode.Text = Properties.Resources.edit;

         labelInventoryCode.Text = Properties.Resources.inventoryCode;
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
      }

      private void ButtonAddBooksExamples_Click(object sender, EventArgs e)
      {
         using (InventoryCodeControlForm examples = new InventoryCodeControlForm())
         {
            examples.ShowDialog();
            Activate();
         }
      }

      private void ButtonSearchPublishHouse_Click(object sender, EventArgs e)
      {
         PublishHouseInformation publishHouse = publishHouseRegister.FindPublishHouseByName(textBoxPublishHouseSearch.Text);
         if (null == publishHouse)
         {
            DialogResult userChoice = MessageBox.Show(Properties.Resources.searchPublishHouseFailed, Properties.Resources.failed,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (DialogResult.Yes == userChoice)
            {
               using (PublishHouseControlForm publishControl = new PublishHouseControlForm(FormViewMode.Create, publishHouseRegister))
               {
                  publishControl.ShowDialog();
               }
            }
            Activate();
         }
      }

      private void RemoveCodeFromList(int lastCode)
      {
         listBoxInventoryCode.Items.Remove(lastCode);
      }

      private void AddNewCodeToList(int code)
      {
         listBoxInventoryCode.Items.Add(code);
      }

      private void ButtonDeleteInventoryCode_Click(object sender, EventArgs e)
      {
         if (listBoxInventoryCode.SelectedItem != null)
         {
            RemoveCodeFromList(Convert.ToInt32(listBoxInventoryCode.SelectedItem));
         }
      }

      private void ButtonEditInventoryCode_Click(object sender, EventArgs e)
      {
         if (listBoxInventoryCode.SelectedItem != null)
         {
            int currentCode = Convert.ToInt32(listBoxInventoryCode.SelectedItem);
            using (InventoryCodeControlForm inventoryCodeControl = new InventoryCodeControlForm(currentCode))
            {
               inventoryCodeControl.AddNewBookExample += AddNewCodeToList;
               inventoryCodeControl.EditNewBookExample += RemoveCodeFromList;

               inventoryCodeControl.ShowDialog();
               Activate();
            }
         }
      }

      private void ButtonAddInventoryCode_Click(object sender, EventArgs e)
      {
         using (InventoryCodeControlForm inventoryCodeControl = new InventoryCodeControlForm())
         {
            inventoryCodeControl.AddNewBookExample += AddNewCodeToList;
            inventoryCodeControl.ShowDialog();
            Activate();
         }
      }
   }
}
