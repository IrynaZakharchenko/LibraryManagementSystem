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
    public partial class BookInfoSearchForm : Form
    {
        public BookInfoSearchForm()
        {
            InitializeComponent();
        }

        private void BookInfoSearchForm_Load(object sender, EventArgs e)
        {
            Text = Properties.Resources.stockmanWelcome;
            toolStripStatusLabelBook.Text = Properties.Resources.statusStripStockmanMain;
            buttonSearch.Text = Properties.Resources.search;
            buttonCreate.Text = Properties.Resources.create;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            using (BookInfoControlForm bookForm = new BookInfoControlForm(NViewHelper.FormViewMode.Edit))
            {
                bookForm.ShowDialog();
            }
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            using (BookInfoControlForm bookForm = new BookInfoControlForm(NViewHelper.FormViewMode.Create))
            {
                bookForm.ShowDialog();
            }
        }
    }
}
