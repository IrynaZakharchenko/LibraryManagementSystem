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
    public partial class PublishHouseControlForm : Form
    {
        private NViewHelper.FormViewMode viewModeForm;

        public PublishHouseControlForm(NViewHelper.FormViewMode mode)
        {
            viewModeForm = mode;
            InitializeComponent();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.successfull, Properties.Resources.save,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }

        private void PublishHouseControlPanelcs_Paint(object sender, PaintEventArgs e)
        {
            buttonSave.Text = Properties.Resources.save;
            buttonDelete.Text = Properties.Resources.delete;
            if (NViewHelper.FormViewMode.Edit == viewModeForm)
            {
                Text = Properties.Resources.edit;
            }
            else
            {
                Text = Properties.Resources.add;
            }
            labelName.Text = Properties.Resources.publishHouseName;
            labelLocation.Text = Properties.Resources.location;
            labelCategory.Text = Properties.Resources.category;
        }

    }
}
