using System;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class BookInfoSearchForm : Form
   {
      private IWorkspaceStockman WorkspaceStockman;

      public BookInfoSearchForm(IWorkspaceStockman workspaceStockman)
      {
         WorkspaceStockman = workspaceStockman;
         InitializeComponent();
      }

      private void BookInfoSearchForm_Load(object sender, EventArgs e)
      {
         Text = Properties.Resources.stockmanWelcome;
         toolStripStatusLabelBook.Text = Properties.Resources.statusStripStockmanMain;
         buttonSearch.Text = Properties.Resources.search;
         buttonCreate.Text = Properties.Resources.create;
      }

      private void ButtonSearch_Click(object sender, EventArgs e)
      {
         BookInformation book = WorkspaceStockman.BookFinding.FindBookByTitle(textBoxSearch.Text);
         if(book != null)
         {
            using (BookInfoControlForm bookForm = new BookInfoControlForm(NViewHelper.FormViewMode.Edit, 
                   WorkspaceStockman.LibraryOperations, book))
            {
               Hide();
               bookForm.ShowDialog();
               Show();
            }
         }
      }

      private void ButtonCreate_Click(object sender, EventArgs e)
      {
         using (BookInfoControlForm bookForm = new BookInfoControlForm(NViewHelper.FormViewMode.Create,
                  WorkspaceStockman.LibraryOperations))
         {
            Hide();
            bookForm.ShowDialog();
            Show();
         }
      }
   }
}
