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
    public partial class PublishHouseControlPanel : Form
    {
        private NViewHelper.FormViewMode viewModeForm;

        public PublishHouseControlPanel(NViewHelper.FormViewMode mode)
        {
            viewModeForm = mode;
            InitializeComponent();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult userConfirm = MessageBox.Show(Properties.Resources.deleteConfirm + Properties.Resources.publishHouse, Properties.Resources.delete,
                MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if (DialogResult.OK == userConfirm)
            {
                MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            //Save input data
            MessageBox.Show(Properties.Resources.successfull, Properties.Resources.save,
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
        
        private void PublishHouseControlPanelcs_Paint(object sender, PaintEventArgs e)
        {
            if (NViewHelper.FormViewMode.View == viewModeForm)
            {
                Text = Properties.Resources.add + Properties.Resources.publishHouse;
                buttonModify.Text = Properties.Resources.edit;
                buttonDelete.Text = Properties.Resources.delete;
            }
            else
            {
                buttonModify.Text = Properties.Resources.save;
                buttonDelete.Text = Properties.Resources.reset;
                if (NViewHelper.FormViewMode.Modify == viewModeForm)
                {
                    Text = Properties.Resources.edit;
                }
                else
                {
                    Text = Properties.Resources.add;
                }
            }
            
            labelName.Text = Properties.Resources.PublishHouseName;
            labelLocation.Text = Properties.Resources.location;
            labelCategory.Text = Properties.Resources.category;
        }
    }
}
