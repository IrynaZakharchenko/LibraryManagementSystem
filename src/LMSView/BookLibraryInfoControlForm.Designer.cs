namespace LMSView
{
    partial class BookLibraryInfoControlForm
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
            this.listBoxInventoryNum = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeListInventoryNum = new System.Windows.Forms.Label();
            this.labelIsbnCode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelBookInputInventory = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonSetInventoryForIsbn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxInventoryNum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelIsbnCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBookInputInventory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSetInventoryForIsbn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSave, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.62712F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.37288F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxInventoryNum
            // 
            this.listBoxInventoryNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInventoryNum.FormattingEnabled = true;
            this.listBoxInventoryNum.Location = new System.Drawing.Point(251, 142);
            this.listBoxInventoryNum.Name = "listBoxInventoryNum";
            this.listBoxInventoryNum.Size = new System.Drawing.Size(546, 157);
            this.listBoxInventoryNum.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labeListInventoryNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 157);
            this.panel1.TabIndex = 1;
            // 
            // labeListInventoryNum
            // 
            this.labeListInventoryNum.AutoSize = true;
            this.labeListInventoryNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeListInventoryNum.Location = new System.Drawing.Point(0, 0);
            this.labeListInventoryNum.Name = "labeListInventoryNum";
            this.labeListInventoryNum.Size = new System.Drawing.Size(0, 13);
            this.labeListInventoryNum.TabIndex = 0;
            // 
            // labelIsbnCode
            // 
            this.labelIsbnCode.AutoSize = true;
            this.labelIsbnCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelIsbnCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIsbnCode.Location = new System.Drawing.Point(3, 37);
            this.labelIsbnCode.Name = "labelIsbnCode";
            this.labelIsbnCode.Size = new System.Drawing.Size(242, 27);
            this.labelIsbnCode.TabIndex = 2;
            this.labelIsbnCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(251, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelBookInputInventory
            // 
            this.labelBookInputInventory.AutoSize = true;
            this.labelBookInputInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBookInputInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBookInputInventory.Location = new System.Drawing.Point(3, 64);
            this.labelBookInputInventory.Name = "labelBookInputInventory";
            this.labelBookInputInventory.Size = new System.Drawing.Size(242, 36);
            this.labelBookInputInventory.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(251, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(546, 20);
            this.textBox2.TabIndex = 5;
            // 
            // buttonSetInventoryForIsbn
            // 
            this.buttonSetInventoryForIsbn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetInventoryForIsbn.Location = new System.Drawing.Point(255, 107);
            this.buttonSetInventoryForIsbn.Margin = new System.Windows.Forms.Padding(7);
            this.buttonSetInventoryForIsbn.Name = "buttonSetInventoryForIsbn";
            this.buttonSetInventoryForIsbn.Size = new System.Drawing.Size(538, 25);
            this.buttonSetInventoryForIsbn.TabIndex = 6;
            this.buttonSetInventoryForIsbn.UseVisualStyleBackColor = true;
            this.buttonSetInventoryForIsbn.Click += new System.EventHandler(this.ButtonSetInventoryForIsbn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.Location = new System.Drawing.Point(251, 348);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(546, 37);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(3, 348);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(242, 37);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // BookLibraryInfoControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BookLibraryInfoControlForm";
            this.Load += new System.EventHandler(this.BookLibraryInfoControlForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxInventoryNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeListInventoryNum;
        private System.Windows.Forms.Label labelIsbnCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelBookInputInventory;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonSetInventoryForIsbn;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}