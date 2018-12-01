namespace LMSView
{
    partial class AccountControlPanel
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
            this.statusStripAdminControlPanel = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelAccounts = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.statusStripAdminControlPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripAdminControlPanel
            // 
            this.statusStripAdminControlPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelAccounts});
            this.statusStripAdminControlPanel.Location = new System.Drawing.Point(0, 426);
            this.statusStripAdminControlPanel.Name = "statusStripAdminControlPanel";
            this.statusStripAdminControlPanel.Size = new System.Drawing.Size(643, 22);
            this.statusStripAdminControlPanel.TabIndex = 2;
            // 
            // toolStripStatusLabelAccounts
            // 
            this.toolStripStatusLabelAccounts.Name = "toolStripStatusLabelAccounts";
            this.toolStripStatusLabelAccounts.Size = new System.Drawing.Size(0, 17);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(170, 266);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(194, 26);
            this.comboBoxPosition.TabIndex = 26;
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimeBirth.Location = new System.Drawing.Point(170, 156);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(176, 24);
            this.dateTimeBirth.TabIndex = 25;
            this.dateTimeBirth.Value = new System.DateTime(1980, 11, 20, 0, 0, 0, 0);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPhone.Location = new System.Drawing.Point(170, 238);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(439, 24);
            this.textBoxPhone.TabIndex = 21;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAddress.Location = new System.Drawing.Point(170, 186);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(439, 46);
            this.textBoxAddress.TabIndex = 20;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(170, 98);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(439, 52);
            this.textBoxName.TabIndex = 18;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Location = new System.Drawing.Point(170, 65);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(439, 27);
            this.textBoxPassword.TabIndex = 17;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxLogin.Location = new System.Drawing.Point(170, 30);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(439, 27);
            this.textBoxLogin.TabIndex = 16;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPassword.Location = new System.Drawing.Point(8, 62);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(156, 33);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLogin.Location = new System.Drawing.Point(8, 27);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(156, 35);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Location = new System.Drawing.Point(8, 95);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(156, 58);
            this.labelName.TabIndex = 7;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBirth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBirth.Location = new System.Drawing.Point(8, 153);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(156, 30);
            this.labelBirth.TabIndex = 9;
            this.labelBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAddress.Location = new System.Drawing.Point(8, 183);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(156, 52);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPhone.Location = new System.Drawing.Point(8, 235);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(156, 28);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPosition.Location = new System.Drawing.Point(8, 263);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(156, 46);
            this.labelPosition.TabIndex = 15;
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 445F));
            this.tableLayoutPanel1.Controls.Add(this.labelPosition, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelBirth, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelLogin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLogin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddress, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhone, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateTimeBirth, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPosition, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonModify, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.59649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.40351F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 396);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonModify
            // 
            this.buttonModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonModify.Location = new System.Drawing.Point(170, 353);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(439, 35);
            this.buttonModify.TabIndex = 27;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(8, 353);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(156, 35);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // AccountControlPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(643, 448);
            this.Controls.Add(this.statusStripAdminControlPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AccountControlPanel";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AccountControlPanel_Paint);
            this.statusStripAdminControlPanel.ResumeLayout(false);
            this.statusStripAdminControlPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStripAdminControlPanel;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAccounts;
    }
}