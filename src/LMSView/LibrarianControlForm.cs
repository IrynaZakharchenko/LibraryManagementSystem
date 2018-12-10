using System;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class LibrarianControlForm : Form
   {
      private readonly IWorkspaceLibrarian workspaceLibrarian;

      public LibrarianControlForm(IWorkspaceLibrarian workspace)
      {
         workspaceLibrarian = workspace;
         InitializeComponent();
      }

      private void LibrarianControlPanel_Load(object sender, EventArgs e)
      {
         Text = Properties.Resources.librarianWelcome;

         labelSearchClient.Text = Properties.Resources.manageClient;
         labelSearchBook.Text = Properties.Resources.manageBook;

         buttonSearchClient.Text = Properties.Resources.search;
         buttonCreateClient.Text = Properties.Resources.createClient;
         buttonSearchBook.Text = Properties.Resources.search;
      }

      private void ButtonSearchBook_Click(object sender, EventArgs e)
      {

      }

      private void ButtonCreateClient_Click(object sender, EventArgs e)
      {
         using (ClientPersonalInfoControlForm client = new ClientPersonalInfoControlForm(NViewHelper.FormViewMode.Create,
                                                                                         workspaceLibrarian.ClientInformationRegister))
         {
            client.ShowDialog();
            Activate();
         }
      }

      private void ButtonSearchClient_Click(object sender, EventArgs e)
      {
         string clientName = textBoxManageClient.Text;

         if (false == String.IsNullOrEmpty(clientName))
         {
            ClientInformation client = workspaceLibrarian.ClientInformationRegister.FindByName(clientName);
            if (client != null)
            {
               using (ClientLibraryInfoControlForm clientLibraryInfo = new ClientLibraryInfoControlForm(workspaceLibrarian.LibraryCardRegister,
                                                                                                        workspaceLibrarian.ClientInformationRegister,
                                                                                                        workspaceLibrarian.BookFinding,
                                                                                                        client))
               {
                  clientLibraryInfo.ShowDialog();
               }
            }
            else
            {
               MessageBox.Show(Properties.Resources.searchFailed, Properties.Resources.failed,
                               MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
         }
         else
         {
            MessageBox.Show(Properties.Resources.clientSearchEmpty, Properties.Resources.failed,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }
         Activate();
      }

   }
}
