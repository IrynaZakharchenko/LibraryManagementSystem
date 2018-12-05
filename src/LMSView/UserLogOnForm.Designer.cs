namespace LMSView
{
   partial class UserLogOnForm
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
            this.components = new System.ComponentModel.Container();
            this.toolTipsLogon = new System.Windows.Forms.ToolTip(this.components);
            this.buttonlogOn = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tableLogOn = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.statusStripLogOn = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLogOn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLogOn.SuspendLayout();
            this.statusStripLogOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTipsLogon
            // 
            this.toolTipsLogon.AutoPopDelay = 5000;
            this.toolTipsLogon.InitialDelay = 500;
            this.toolTipsLogon.ReshowDelay = 500;
            this.toolTipsLogon.ShowAlways = true;
            this.toolTipsLogon.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // buttonlogOn
            // 
            this.buttonlogOn.Location = new System.Drawing.Point(307, 165);
            this.buttonlogOn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonlogOn.Name = "buttonlogOn";
            this.buttonlogOn.Size = new System.Drawing.Size(113, 34);
            this.buttonlogOn.TabIndex = 0;
            this.buttonlogOn.UseVisualStyleBackColor = true;
            this.buttonlogOn.Click += new System.EventHandler(this.ButtonlogOn_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(5, 0);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 18);
            this.labelLogin.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(5, 34);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 18);
            this.labelPassword.TabIndex = 2;
            // 
            // tableLogOn
            // 
            this.tableLogOn.ColumnCount = 2;
            this.tableLogOn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.44988F));
            this.tableLogOn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.55013F));
            this.tableLogOn.Controls.Add(this.labelLogin, 0, 0);
            this.tableLogOn.Controls.Add(this.labelPassword, 0, 1);
            this.tableLogOn.Controls.Add(this.textBoxPassword, 1, 1);
            this.tableLogOn.Controls.Add(this.textBoxLogin, 1, 0);
            this.tableLogOn.Location = new System.Drawing.Point(68, 53);
            this.tableLogOn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLogOn.Name = "tableLogOn";
            this.tableLogOn.RowCount = 2;
            this.tableLogOn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
            this.tableLogOn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
            this.tableLogOn.Size = new System.Drawing.Size(609, 67);
            this.tableLogOn.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Location = new System.Drawing.Point(153, 38);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(451, 25);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogin.Location = new System.Drawing.Point(153, 4);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(451, 26);
            this.textBoxLogin.TabIndex = 3;
            // 
            // statusStripLogOn
            // 
            this.statusStripLogOn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLogOn,
            this.toolStripStatusLabel1});
            this.statusStripLogOn.Location = new System.Drawing.Point(0, 218);
            this.statusStripLogOn.Name = "statusStripLogOn";
            this.statusStripLogOn.Size = new System.Drawing.Size(744, 22);
            this.statusStripLogOn.TabIndex = 4;
            // 
            // toolStripStatusLabelLogOn
            // 
            this.toolStripStatusLabelLogOn.Name = "toolStripStatusLabelLogOn";
            this.toolStripStatusLabelLogOn.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // UserLogOnForm
            // 
            this.AcceptButton = this.buttonlogOn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 240);
            this.Controls.Add(this.statusStripLogOn);
            this.Controls.Add(this.tableLogOn);
            this.Controls.Add(this.buttonlogOn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserLogOnForm";
            this.Load += new System.EventHandler(this.UserLogOnForm_Load);
            this.tableLogOn.ResumeLayout(false);
            this.tableLogOn.PerformLayout();
            this.statusStripLogOn.ResumeLayout(false);
            this.statusStripLogOn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.ToolTip toolTipsLogon;
        private System.Windows.Forms.Button buttonlogOn;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TableLayoutPanel tableLogOn;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.StatusStrip statusStripLogOn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogOn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

