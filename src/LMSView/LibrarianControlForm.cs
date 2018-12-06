﻿using System;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class LibrarianControlForm : Form
   {
      private readonly IWorkspaceLibrarian workspace;

      public LibrarianControlForm()
      {
         workspace = new LibrarianWorkspace();
         InitializeComponent();
      }

      private void LibrarianControlPanel_Load(object sender, EventArgs e)
      {
         Text = Properties.Resources.librarianWelcome;

         labelSearchClient.Text = Properties.Resources.manageClient;
         labelSearchBook.Text = Properties.Resources.manageBook;

         buttonRentBook.Text = Properties.Resources.rentBook;
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
                                                                                         workspace.GetClientInformationRegister()))
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
            ClientInformation client = workspace.GetClientInformationRegister().FindClientByName(clientName);
            if (client != null)
            {
               using (ClientLibraryInfoControlForm clientLibraryInfo = new ClientLibraryInfoControlForm(NViewHelper.FormViewMode.Edit,
                                                                                                        workspace.GetClientInformationRegister(),
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

      private void ButtonRentBook_Click(object sender, EventArgs e)
      {

      }
   }
}
