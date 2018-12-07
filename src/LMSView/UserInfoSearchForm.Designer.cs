namespace LMSView
{
    partial class UserInfoSearchForm
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
         this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
         this.textBoxSearch = new System.Windows.Forms.TextBox();
         this.buttonSearch = new System.Windows.Forms.Button();
         this.buttonCreate = new System.Windows.Forms.Button();
         this.statusStripControl = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabelListControl = new System.Windows.Forms.ToolStripStatusLabel();
         this.toolStripStatusLabelControl = new System.Windows.Forms.ToolStripStatusLabel();
         this.flowLayoutPanel1.SuspendLayout();
         this.statusStripControl.SuspendLayout();
         this.SuspendLayout();
         // 
         // flowLayoutPanel1
         // 
         this.flowLayoutPanel1.Controls.Add(this.textBoxSearch);
         this.flowLayoutPanel1.Controls.Add(this.buttonSearch);
         this.flowLayoutPanel1.Controls.Add(this.buttonCreate);
         this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 22);
         this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
         this.flowLayoutPanel1.Name = "flowLayoutPanel1";
         this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
         this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 64);
         this.flowLayoutPanel1.TabIndex = 1;
         // 
         // textBoxSearch
         // 
         this.textBoxSearch.Location = new System.Drawing.Point(13, 13);
         this.textBoxSearch.Name = "textBoxSearch";
         this.textBoxSearch.Size = new System.Drawing.Size(463, 24);
         this.textBoxSearch.TabIndex = 3;
         // 
         // buttonSearch
         // 
         this.buttonSearch.AutoSize = true;
         this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.buttonSearch.Location = new System.Drawing.Point(482, 13);
         this.buttonSearch.Name = "buttonSearch";
         this.buttonSearch.Padding = new System.Windows.Forms.Padding(1);
         this.buttonSearch.Size = new System.Drawing.Size(8, 8);
         this.buttonSearch.TabIndex = 4;
         this.buttonSearch.UseVisualStyleBackColor = true;
         this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
         // 
         // buttonCreate
         // 
         this.buttonCreate.AutoSize = true;
         this.buttonCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.buttonCreate.Location = new System.Drawing.Point(496, 13);
         this.buttonCreate.Name = "buttonCreate";
         this.buttonCreate.Padding = new System.Windows.Forms.Padding(1);
         this.buttonCreate.Size = new System.Drawing.Size(8, 8);
         this.buttonCreate.TabIndex = 5;
         this.buttonCreate.UseVisualStyleBackColor = true;
         this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
         // 
         // statusStripControl
         // 
         this.statusStripControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelListControl,
            this.toolStripStatusLabelControl});
         this.statusStripControl.Location = new System.Drawing.Point(0, 105);
         this.statusStripControl.Name = "statusStripControl";
         this.statusStripControl.Size = new System.Drawing.Size(656, 22);
         this.statusStripControl.TabIndex = 2;
         // 
         // toolStripStatusLabelListControl
         // 
         this.toolStripStatusLabelListControl.Name = "toolStripStatusLabelListControl";
         this.toolStripStatusLabelListControl.Size = new System.Drawing.Size(0, 17);
         // 
         // toolStripStatusLabelControl
         // 
         this.toolStripStatusLabelControl.Name = "toolStripStatusLabelControl";
         this.toolStripStatusLabelControl.Size = new System.Drawing.Size(0, 17);
         // 
         // UserInfoSearchForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(656, 127);
         this.Controls.Add(this.statusStripControl);
         this.Controls.Add(this.flowLayoutPanel1);
         this.Name = "UserInfoSearchForm";
         this.Load += new System.EventHandler(this.UserInfoSearchForm_Load);
         this.flowLayoutPanel1.ResumeLayout(false);
         this.flowLayoutPanel1.PerformLayout();
         this.statusStripControl.ResumeLayout(false);
         this.statusStripControl.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.StatusStrip statusStripControl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelListControl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelControl;
        private System.Windows.Forms.Button buttonCreate;
    }
}