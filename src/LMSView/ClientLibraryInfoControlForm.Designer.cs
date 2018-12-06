namespace LMSView
{
    partial class ClientLibraryInfoControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.labelDateGiveBook = new System.Windows.Forms.Label();
         this.labelDateGetBook = new System.Windows.Forms.Label();
         this.labelClientTicketNum = new System.Windows.Forms.Label();
         this.labelBookNum = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.dateTimePickerGiveBook = new System.Windows.Forms.DateTimePicker();
         this.panel1 = new System.Windows.Forms.Panel();
         this.labelBooksList = new System.Windows.Forms.Label();
         this.listBoxClientBookCollection = new System.Windows.Forms.ListBox();
         this.buttonReturnBook = new System.Windows.Forms.Button();
         this.buttonClientPersonal = new System.Windows.Forms.Button();
         this.tableLayoutPanel1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 4;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.58621F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.4138F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
         this.tableLayoutPanel1.Controls.Add(this.labelDateGiveBook, 1, 5);
         this.tableLayoutPanel1.Controls.Add(this.labelDateGetBook, 1, 4);
         this.tableLayoutPanel1.Controls.Add(this.labelClientTicketNum, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.labelBookNum, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 1);
         this.tableLayoutPanel1.Controls.Add(this.dateTimePickerReturn, 2, 4);
         this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 2);
         this.tableLayoutPanel1.Controls.Add(this.dateTimePickerGiveBook, 2, 5);
         this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
         this.tableLayoutPanel1.Controls.Add(this.listBoxClientBookCollection, 2, 3);
         this.tableLayoutPanel1.Controls.Add(this.buttonReturnBook, 2, 7);
         this.tableLayoutPanel1.Controls.Add(this.buttonClientPersonal, 1, 7);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 9;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.86487F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.13514F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 403);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // labelDateGiveBook
         // 
         this.labelDateGiveBook.AutoSize = true;
         this.labelDateGiveBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.labelDateGiveBook.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelDateGiveBook.Location = new System.Drawing.Point(60, 249);
         this.labelDateGiveBook.Name = "labelDateGiveBook";
         this.labelDateGiveBook.Size = new System.Drawing.Size(145, 27);
         this.labelDateGiveBook.TabIndex = 21;
         this.labelDateGiveBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelDateGetBook
         // 
         this.labelDateGetBook.AutoSize = true;
         this.labelDateGetBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.labelDateGetBook.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelDateGetBook.Location = new System.Drawing.Point(60, 223);
         this.labelDateGetBook.Name = "labelDateGetBook";
         this.labelDateGetBook.Size = new System.Drawing.Size(145, 26);
         this.labelDateGetBook.TabIndex = 17;
         this.labelDateGetBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelClientTicketNum
         // 
         this.labelClientTicketNum.AutoSize = true;
         this.labelClientTicketNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.labelClientTicketNum.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelClientTicketNum.Location = new System.Drawing.Point(60, 48);
         this.labelClientTicketNum.Name = "labelClientTicketNum";
         this.labelClientTicketNum.Size = new System.Drawing.Size(145, 26);
         this.labelClientTicketNum.TabIndex = 6;
         this.labelClientTicketNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelBookNum
         // 
         this.labelBookNum.AutoSize = true;
         this.labelBookNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.labelBookNum.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelBookNum.Location = new System.Drawing.Point(60, 74);
         this.labelBookNum.Name = "labelBookNum";
         this.labelBookNum.Size = new System.Drawing.Size(145, 26);
         this.labelBookNum.TabIndex = 0;
         this.labelBookNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // textBox1
         // 
         this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBox1.Location = new System.Drawing.Point(211, 51);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(396, 20);
         this.textBox1.TabIndex = 22;
         // 
         // dateTimePickerReturn
         // 
         this.dateTimePickerReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dateTimePickerReturn.Location = new System.Drawing.Point(211, 226);
         this.dateTimePickerReturn.Name = "dateTimePickerReturn";
         this.dateTimePickerReturn.Size = new System.Drawing.Size(200, 20);
         this.dateTimePickerReturn.TabIndex = 24;
         // 
         // textBox2
         // 
         this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBox2.Location = new System.Drawing.Point(211, 77);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(396, 20);
         this.textBox2.TabIndex = 25;
         // 
         // dateTimePickerGiveBook
         // 
         this.dateTimePickerGiveBook.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dateTimePickerGiveBook.Location = new System.Drawing.Point(211, 252);
         this.dateTimePickerGiveBook.Name = "dateTimePickerGiveBook";
         this.dateTimePickerGiveBook.Size = new System.Drawing.Size(200, 20);
         this.dateTimePickerGiveBook.TabIndex = 23;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.labelBooksList);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel1.Location = new System.Drawing.Point(60, 103);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(145, 117);
         this.panel1.TabIndex = 26;
         // 
         // labelBooksList
         // 
         this.labelBooksList.AutoSize = true;
         this.labelBooksList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.labelBooksList.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelBooksList.Location = new System.Drawing.Point(0, 0);
         this.labelBooksList.Name = "labelBooksList";
         this.labelBooksList.Size = new System.Drawing.Size(2, 15);
         this.labelBooksList.TabIndex = 15;
         this.labelBooksList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // listBoxClientBookCollection
         // 
         this.listBoxClientBookCollection.Dock = System.Windows.Forms.DockStyle.Fill;
         this.listBoxClientBookCollection.FormattingEnabled = true;
         this.listBoxClientBookCollection.Location = new System.Drawing.Point(211, 103);
         this.listBoxClientBookCollection.Name = "listBoxClientBookCollection";
         this.listBoxClientBookCollection.Size = new System.Drawing.Size(396, 117);
         this.listBoxClientBookCollection.TabIndex = 27;
         this.listBoxClientBookCollection.SelectedIndexChanged += new System.EventHandler(this.ListBoxClientBookCollection_SelectedIndexChanged);
         // 
         // buttonReturnBook
         // 
         this.buttonReturnBook.Dock = System.Windows.Forms.DockStyle.Fill;
         this.buttonReturnBook.Location = new System.Drawing.Point(211, 313);
         this.buttonReturnBook.Name = "buttonReturnBook";
         this.buttonReturnBook.Size = new System.Drawing.Size(396, 40);
         this.buttonReturnBook.TabIndex = 28;
         this.buttonReturnBook.UseVisualStyleBackColor = true;
         this.buttonReturnBook.Click += new System.EventHandler(this.ButtonReturnBook_Click);
         // 
         // buttonClientPersonal
         // 
         this.buttonClientPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
         this.buttonClientPersonal.Location = new System.Drawing.Point(60, 313);
         this.buttonClientPersonal.Name = "buttonClientPersonal";
         this.buttonClientPersonal.Size = new System.Drawing.Size(145, 40);
         this.buttonClientPersonal.TabIndex = 29;
         this.buttonClientPersonal.UseVisualStyleBackColor = true;
         this.buttonClientPersonal.Click += new System.EventHandler(this.ButtonClientPersonal_Click);
         // 
         // ClientLibraryInfoControlForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(670, 403);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "ClientLibraryInfoControlForm";
         this.Load += new System.EventHandler(this.ClientLibraryInfoControlForm_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelBookNum;
        private System.Windows.Forms.Label labelDateGiveBook;
        private System.Windows.Forms.Label labelDateGetBook;
        private System.Windows.Forms.Label labelClientTicketNum;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.DateTimePicker dateTimePickerGiveBook;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBooksList;
        private System.Windows.Forms.ListBox listBoxClientBookCollection;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.Button buttonClientPersonal;
    }
}