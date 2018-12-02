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
    public partial class ClientPersonalInfoControlForm : Form
    {
        private NViewHelper.FormViewMode mViewMode;

        public ClientPersonalInfoControlForm(NViewHelper.FormViewMode mode)
        {
            mViewMode = mode;
            InitializeComponent();
        }

        private void ReaderControlPanel_Paint(object sender, PaintEventArgs e)
        {
            labelLibTicketNum.Text = Properties.Resources.libraryNumTicket;
            labelName.Text = Properties.Resources.fullName;
            labelBirth.Text = Properties.Resources.birth;
            labelAddress.Text = Properties.Resources.address;
            buttonSave.Text = Properties.Resources.save;
            buttonDelete.Text = Properties.Resources.delete;

            if (NViewHelper.FormViewMode.Edit == mViewMode)
            {
                Text = Properties.Resources.clientEdit;
            }
            if (NViewHelper.FormViewMode.Create == mViewMode)
            {
                Text = Properties.Resources.clientCreate;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
