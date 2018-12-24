using System;
using System.Windows.Forms;
using LMSView.NViewHelper;
using LMSController;
using System.Collections.Generic;
using System.Globalization;

namespace LMSView
{
	partial class BookInfoControlForm : Form
	{
		private FormViewMode viewMode;
		private BookInformation currentBook;
		private ILibraryOperations libraryManagment;
		private IPublishHouseInformationRegister publishHouseRegister;

		public BookInfoControlForm(FormViewMode mode, IWorkspaceStockman workspaceStockman, BookInformation book = null)
		{
			viewMode = mode;
			currentBook = book;
			libraryManagment = workspaceStockman.LibraryOperations;
			publishHouseRegister = workspaceStockman.PublishHouseInformationRegister;

			InitializeComponent();
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (FormViewMode.Create == viewMode)
			{
				currentBook = new BookInformation();
				libraryManagment.AddBook(PackageBookInformation(currentBook));
				MessageBox.Show(Properties.Resources.successfull, Properties.Resources.createBook,
								    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
			}
			else
			{
				libraryManagment.EditBook(PackageBookInformation(currentBook));
				MessageBox.Show(Properties.Resources.successfull, Properties.Resources.editBook,
									 MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
			}
			Close();
		}

		private void ButtonDelete_Click(object sender, EventArgs e)
		{
			if (FormViewMode.Edit == viewMode)
			{
				if (DialogResult.Yes == MessageBox.Show(Properties.Resources.deleteConfirm, Properties.Resources.delete,
											   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification))
				{
					libraryManagment.DeleteBookByISBN(currentBook.ISBN);

					MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
										 MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
					Close();
				}
			}
			else
			{
				MessageBox.Show(Properties.Resources.bookDeleteFailed, Properties.Resources.failed,
									 MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
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
					if (code.Value == false)
					{
						listBoxInventoryCodeAvailable.Items.Add(code.Key);
					}
					else
					{
						listBoxInventoryCodeNotAvailable.Items.Add(code.Key);
					}
				}
				textBoxTitle.Text = currentBook.Title;

				AuthorInformation[] authors = currentBook.Authors;
				foreach (var name in authors)
				{
					textBoxAuthors.Text += name.Name + Properties.Resources.separator;
				}
				textBoxAuthors.Text = textBoxAuthors.Text.Remove(textBoxAuthors.Text.Length - 2, 1);
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
			}
			if (FormViewMode.Create == viewMode)
			{
				Text = Properties.Resources.createBook;

				labelTitle.Text = ViewHelper.MarkFieldAsImportant(labelTitle.Text);
				labelInventoryCodeNotAvailable.Text = ViewHelper.MarkFieldAsImportant(labelInventoryCodeNotAvailable.Text);
				labelAuthors.Text = ViewHelper.MarkFieldAsImportant(labelAuthors.Text);
				labelIsbn.Text = ViewHelper.MarkFieldAsImportant(labelIsbn.Text);
				labelLanguage.Text = ViewHelper.MarkFieldAsImportant(labelLanguage.Text);
				labelPublishDate.Text = ViewHelper.MarkFieldAsImportant(labelPublishDate.Text);
				labelPublishHouse.Text = ViewHelper.MarkFieldAsImportant(labelPublishHouse.Text);
			}
		}

		private BookInformation PackageBookInformation(BookInformation book)
		{
			Dictionary<int, bool> mapInventoryCodes = new Dictionary<int, bool>();
			foreach (var code in listBoxInventoryCodeAvailable.Items)
			{
				mapInventoryCodes.Add(Convert.ToInt32(code, CultureInfo.CurrentCulture), false);
			};
			foreach (var code in listBoxInventoryCodeNotAvailable.Items)
			{
				mapInventoryCodes.Add(Convert.ToInt32(code, CultureInfo.CurrentCulture), true);
			};
			book.InventoryCode = mapInventoryCodes;
			book.Title = textBoxTitle.Text;
			book.FullTitle = textBoxFullTitle.Text;
			book.ISBN = Convert.ToInt32(textBoxIsbn.Text, CultureInfo.CurrentCulture);
			book.Language = textBoxLanguage.Text;
			book.PublishHouse = publishHouseRegister.FindByName(textBoxPublishHouseResult.Text);
			book.PublishDate = dateTimePickerPublish.Value;
			book.Annotation = textBoxAnnotation.Text;
			book.BookSeries = textBoxSeries.Text;
			string[] authorsNames = textBoxAuthors.Text.Split(new char[] { ',' });
			List<AuthorInformation> authors = new List<AuthorInformation>();
			foreach (string name in authorsNames)
			{
				authors.Add(new AuthorInformation() { Name = name });
			}
			book.Authors = authors.ToArray();
			book.Subject = new SubjectInformation() { Name = textBoxSubject.Text };
			return book;
		}

		private void PrintForm()
		{
			listBoxInventoryCodeNotAvailable.Enabled = false;

			buttonSave.Text = Properties.Resources.save;
			buttonDelete.Text = Properties.Resources.delete;
			buttonSearchPublishHouse.Text = Properties.Resources.search;
			buttonAddInventoryCode.Text = Properties.Resources.add;
			buttonDeleteInventoryCode.Text = Properties.Resources.delete;
			buttonEditInventoryCode.Text = Properties.Resources.edit;

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
		}

		private void ButtonSearchPublishHouse_Click(object sender, EventArgs e)
		{
			PublishHouseInformation publishHouse = publishHouseRegister.FindByName(textBoxPublishHouseSearch.Text);
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
			else
			{
				textBoxPublishHouseResult.Text = publishHouse.Name;
			}
		}

		private void RemoveCodeFromList(int lastCode)
		{
			listBoxInventoryCodeAvailable.Items.Remove(lastCode);
			libraryManagment.DeleteBookByInventoryCode(lastCode);
		}

		private void AddNewCodeToList(int code)
		{
			listBoxInventoryCodeAvailable.Items.Add(code);
		}

		private void ButtonDeleteInventoryCode_Click(object sender, EventArgs e)
		{
			if (listBoxInventoryCodeAvailable.SelectedItem != null)
			{
				RemoveCodeFromList(Convert.ToInt32(listBoxInventoryCodeAvailable.SelectedItem, CultureInfo.CurrentCulture));
			}
			Activate();
		}

		private void ButtonEditInventoryCode_Click(object sender, EventArgs e)
		{
			if (listBoxInventoryCodeAvailable.SelectedItem != null)
			{
				int currentCode = Convert.ToInt32(listBoxInventoryCodeAvailable.SelectedItem, CultureInfo.CurrentCulture);
				using (InventoryCodeControlForm inventoryCodeControl = new InventoryCodeControlForm(currentCode))
				{
					inventoryCodeControl.AddNewBookExample += AddNewCodeToList;
					inventoryCodeControl.EditNewBookExample += RemoveCodeFromList;

					inventoryCodeControl.ShowDialog();
				}
				Activate();
			}
		}

		private void ButtonAddInventoryCode_Click(object sender, EventArgs e)
		{
			using (InventoryCodeControlForm inventoryCodeControl = new InventoryCodeControlForm())
			{
				inventoryCodeControl.AddNewBookExample += AddNewCodeToList;
				inventoryCodeControl.ShowDialog();
			}
			Activate();
		}
	}
}
