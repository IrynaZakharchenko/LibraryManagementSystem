using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMSView
{
    public partial class LibrarianControlForm : Form
    {
        public LibrarianControlForm()
        {
            InitializeComponent();
        }

        private void LibrarianControlPanel_Load(object sender, EventArgs e)
        {
            Text = Properties.Resources.librarianWelcome;

            labelSearchClient.Text = Properties.Resources.manageUser;
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
            using (ClientPersonalInfoControlForm client = 
                new ClientPersonalInfoControlForm(NViewHelper.FormViewMode.Create))
            {
                client.ShowDialog();
            }
        }

        private void ButtonSearchClient_Click(object sender, EventArgs e)
        {
            using (ClientLibraryInfoControlForm client =
                new ClientLibraryInfoControlForm())
            {
                client.ShowDialog();
            }

        }

        private void ButtonRentBook_Click(object sender, EventArgs e)
        {

        }
    }
}
