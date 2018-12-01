namespace LMSView
{
    partial class LibrarianControlForm
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxManageClient = new System.Windows.Forms.TextBox();
            this.textBoxManageBook = new System.Windows.Forms.TextBox();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.labelSearchClient = new System.Windows.Forms.Label();
            this.labelSearchBook = new System.Windows.Forms.Label();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.buttonRentBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxManageClient
            // 
            this.textBoxManageClient.Location = new System.Drawing.Point(43, 66);
            this.textBoxManageClient.Name = "textBoxManageClient";
            this.textBoxManageClient.Size = new System.Drawing.Size(379, 22);
            this.textBoxManageClient.TabIndex = 13;
            // 
            // textBoxManageBook
            // 
            this.textBoxManageBook.Location = new System.Drawing.Point(43, 139);
            this.textBoxManageBook.Name = "textBoxManageBook";
            this.textBoxManageBook.Size = new System.Drawing.Size(379, 22);
            this.textBoxManageBook.TabIndex = 14;
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.AutoSize = true;
            this.buttonSearchClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchClient.Location = new System.Drawing.Point(446, 66);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(6, 6);
            this.buttonSearchClient.TabIndex = 15;
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.ButtonSearchClient_Click);
            // 
            // labelSearchClient
            // 
            this.labelSearchClient.AutoSize = true;
            this.labelSearchClient.Location = new System.Drawing.Point(43, 32);
            this.labelSearchClient.Name = "labelSearchClient";
            this.labelSearchClient.Size = new System.Drawing.Size(0, 16);
            this.labelSearchClient.TabIndex = 17;
            // 
            // labelSearchBook
            // 
            this.labelSearchBook.AutoSize = true;
            this.labelSearchBook.Location = new System.Drawing.Point(43, 109);
            this.labelSearchBook.Name = "labelSearchBook";
            this.labelSearchBook.Size = new System.Drawing.Size(0, 16);
            this.labelSearchBook.TabIndex = 18;
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.AutoSize = true;
            this.buttonSearchBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearchBook.Location = new System.Drawing.Point(446, 142);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(6, 6);
            this.buttonSearchBook.TabIndex = 19;
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.ButtonSearchBook_Click);
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.AutoSize = true;
            this.buttonCreateClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCreateClient.Location = new System.Drawing.Point(518, 66);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(6, 6);
            this.buttonCreateClient.TabIndex = 20;
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.ButtonCreateClient_Click);
            // 
            // buttonRentBook
            // 
            this.buttonRentBook.AutoSize = true;
            this.buttonRentBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRentBook.Location = new System.Drawing.Point(518, 142);
            this.buttonRentBook.Name = "buttonRentBook";
            this.buttonRentBook.Size = new System.Drawing.Size(6, 6);
            this.buttonRentBook.TabIndex = 21;
            this.buttonRentBook.UseVisualStyleBackColor = true;
            this.buttonRentBook.Click += new System.EventHandler(this.ButtonRentBook_Click);
            // 
            // LibrarianControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 223);
            this.Controls.Add(this.buttonRentBook);
            this.Controls.Add(this.buttonSearchClient);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.labelSearchBook);
            this.Controls.Add(this.labelSearchClient);
            this.Controls.Add(this.textBoxManageBook);
            this.Controls.Add(this.textBoxManageClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LibrarianControlForm";
            this.Load += new System.EventHandler(this.LibrarianControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBoxManageClient;
        private System.Windows.Forms.TextBox textBoxManageBook;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.Label labelSearchClient;
        private System.Windows.Forms.Label labelSearchBook;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.Button buttonRentBook;
    }
}