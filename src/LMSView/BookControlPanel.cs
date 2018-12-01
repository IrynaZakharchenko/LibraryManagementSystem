using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSView.NViewHelper;

namespace LMSView
{
    public partial class BookControlPanel : Form
    {
        private FormViewMode viewMode;

        public BookControlPanel(FormViewMode mode)
        {
            viewMode = mode;
            InitializeComponent();
        }

        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (FormViewMode.View == viewMode)
            {
                viewMode = FormViewMode.Modify;
                Invalidate();
            }
            else
            {
                //Save input data
                MessageBox.Show(Properties.Resources.successfull, Properties.Resources.save + Properties.Resources.viewBook,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult userConfirm = MessageBox.Show(Properties.Resources.deleteConfirm + Properties.Resources.viewBook, Properties.Resources.delete,
                MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            if(DialogResult.OK == userConfirm)
            {
                MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
        }
        
        private void BookControlPanel_Paint(object sender, PaintEventArgs e)
        {
            if (FormViewMode.View == viewMode)
            {
                Text = Properties.Resources.viewBook;
                buttonModify.Text = Properties.Resources.edit;
                buttonDelete.Text = Properties.Resources.delete;
                buttonAddPublishHouse.Hide();
                buttonSearchPublishHouse.Text = Properties.Resources.showInfo;
                textBoxTitle.ReadOnly = true;
                textBoxFullTitle.ReadOnly = true;
                textBoxIsbn.ReadOnly = true;
                textBoxLanguage.ReadOnly = true;
                textBoxPublishHouse.ReadOnly = true;
                textBoxSeries.ReadOnly = true;
                textBoxSubject.ReadOnly = true;
                textBoxSubjectParent.ReadOnly = true;
            }
            else
            {
                buttonModify.Text = Properties.Resources.save;
                buttonDelete.Text = Properties.Resources.reset;
                buttonSearchPublishHouse.Text = Properties.Resources.search;
                buttonAddPublishHouse.Show();
                textBoxTitle.ReadOnly = false;
                textBoxFullTitle.ReadOnly = false;
                textBoxIsbn.ReadOnly = false;
                textBoxLanguage.ReadOnly = false;
                textBoxPublishHouse.ReadOnly = false;
                textBoxSeries.ReadOnly = false;
                textBoxSubject.ReadOnly = false;
                textBoxSubjectParent.ReadOnly = false;
                if (FormViewMode.Modify == viewMode)
                {
                    Text = Properties.Resources.editBook;
                }
                if (FormViewMode.Create == viewMode)
                {
                    Text = Properties.Resources.createBook;
                }
            }
            labelTitle.Text = Properties.Resources.Title;
            labelFullTitle.Text = Properties.Resources.fullName;
            labelIsbn.Text = Properties.Resources.isbn;
            labelLanguage.Text = Properties.Resources.language;
            labelPublishDate.Text = Properties.Resources.publishDate;
            labelSeries.Text = Properties.Resources.series;
            labelPublishHouse.Text = Properties.Resources.publishHouse;
            buttonAddPublishHouse.Text = Properties.Resources.add;
            labelSubject.Text = Properties.Resources.subject;
            labelParentSubject.Text = Properties.Resources.parentSubject;
        }

        private void ButtonAddPublishHouse_Click(object sender, EventArgs e)
        {
            using (PublishHouseControlPanel publishControl = new PublishHouseControlPanel(FormViewMode.Create))
            {
                publishControl.ShowDialog();
            }
        }

        private void buttonSearchPublishHouse_Click(object sender, EventArgs e)
        {
            using (PublishHouseControlPanel publishControl = new PublishHouseControlPanel(FormViewMode.Modify))
            {
                publishControl.ShowDialog();
            }
        }
    }
}
