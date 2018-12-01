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
    public partial class ClientLibraryInfoControlForm : Form
    {
        public ClientLibraryInfoControlForm()
        {
            InitializeComponent();
        }

        private void ButtonReturnBook_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClientPersonal_Click(object sender, EventArgs e)
        {
            using (ClientPersonalInfoControlForm info = new ClientPersonalInfoControlForm(NViewHelper.FormViewMode.Edit))
            {
                info.ShowDialog();
            }
        }
        private void ClientLibraryInfoControlForm_Load(object sender, EventArgs e)
        {
            labelClientTicketNum.Text = Properties.Resources.libraryNumTicket;
            labelBookNum.Text = Properties.Resources.bookNum;
            labelBooksList.Text = Properties.Resources.bookList;
            buttonReturnBook.Text = Properties.Resources.returnBook;
            buttonClientPersonal.Text = Properties.Resources.personalInfo;
        }

    }
}
