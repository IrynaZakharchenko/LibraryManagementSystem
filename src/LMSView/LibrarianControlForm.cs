using System;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class LibrarianControlForm : Form
   {
      private readonly IWorkspaceLibrarian workspaceLibrarian;
      private ClientInformation selectedClient = null;

      public LibrarianControlForm(IWorkspaceLibrarian workspace)
      {
         workspaceLibrarian = workspace;
         InitializeComponent();
      }

      private void LibrarianControlPanel_Load(object sender, EventArgs e)
      {
         Text = Properties.Resources.librarianWelcome;

         labelSearchClient.Text = Properties.Resources.searchClient;
         labelSearchBook.Text = Properties.Resources.searchBook;

         buttonSearchClient.Text = Properties.Resources.search;
         buttonCreateClient.Text = Properties.Resources.createClient;
         buttonSearchBook.Text = Properties.Resources.search;
      }

      private void ButtonSearchBook_Click(object sender, EventArgs e)
      {
         if (selectedClient != null)
         {
            BookInformation book = workspaceLibrarian.BookFinding.FindByTitle(textBoxManageBook.Text);
            if (book != null)
            {
               using (LibrarianBookInfoSearchForm bookForm = new LibrarianBookInfoSearchForm(workspaceLibrarian.ClientInformationRegister,
                                                                                             workspaceLibrarian.LibraryCardRegister,
                                                                                             selectedClient,
                                                                                             book))
               {
                  Hide();
                  bookForm.ShowDialog();
                  Show();
               }
            }
         }
         else
         {
            MessageBox.Show(Properties.Resources.clientNotSpecified, Properties.Resources.failed,
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }
         Activate();
      }

      private void CreateNewClient()
      {
         using (ClientPersonalInfoControlForm client = new ClientPersonalInfoControlForm(NViewHelper.FormViewMode.Create,
                                                                                         workspaceLibrarian.ClientInformationRegister,
                                                                                         ref selectedClient))
         {
            client.ShowDialog();
			}

			Activate();
		}

      private void ButtonCreateClient_Click(object sender, EventArgs e)
      {
         CreateNewClient();
		}

      private void ButtonSearchClient_Click(object sender, EventArgs e)
      {
         selectedClient = workspaceLibrarian.ClientInformationRegister.FindByLibraryTicket(Convert.ToInt32(textBoxManageClient.Text));

         if (selectedClient != null)
         {
            using (ClientLibraryInfoControlForm clientLibraryInfo = new ClientLibraryInfoControlForm(workspaceLibrarian, ref selectedClient))
            {
               clientLibraryInfo.ShowDialog();
            }
         }
         else
         {
            DialogResult result = MessageBox.Show(Properties.Resources.searchFailed, Properties.Resources.failed,
                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (DialogResult.OK == result)
            {
               CreateNewClient();
            }
         }
         Activate();
      }

   }
}
