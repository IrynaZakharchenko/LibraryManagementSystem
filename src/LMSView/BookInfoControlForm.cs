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
    public partial class BookInfoControlForm : Form
    {
        private FormViewMode viewMode;

        public BookInfoControlForm(FormViewMode mode)
        {
            viewMode = mode;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.successfull, Properties.Resources.delete,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }
        
        private void BookControlPanel_Paint(object sender, PaintEventArgs e)
        {
            buttonSave.Text = Properties.Resources.save;
            buttonDelete.Text = Properties.Resources.delete;
            buttonSearchPublishHouse.Text = Properties.Resources.search;
            buttonAddBooksExamples.Text = Properties.Resources.bookLibExample;

            buttonAddPublishHouse.Show();
            if (FormViewMode.Edit == viewMode)
            {
                Text = Properties.Resources.editBook;
            }
            if (FormViewMode.Create == viewMode)
            {
                Text = Properties.Resources.createBook;
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
            using (PublishHouseControlForm publishControl = new PublishHouseControlForm(FormViewMode.Create))
            {
                publishControl.ShowDialog();
            }
        }

        private void buttonSearchPublishHouse_Click(object sender, EventArgs e)
        {
            using (PublishHouseControlForm publishControl = new PublishHouseControlForm(FormViewMode.Edit))
            {
                publishControl.ShowDialog();
            }
        }

        private void ButtonAddBooksExamples_Click(object sender, EventArgs e)
        {
            using (BookLibraryInfoControlForm examples = new BookLibraryInfoControlForm())
            {
                examples.ShowDialog();
            }
        }
    }
}
