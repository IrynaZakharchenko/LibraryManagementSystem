namespace LMSView
{
    partial class InventoryCodeControlForm
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
         this.textBoxInventoryCode = new System.Windows.Forms.TextBox();
         this.buttonSave = new System.Windows.Forms.Button();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // textBoxInventoryCode
         // 
         this.textBoxInventoryCode.Location = new System.Drawing.Point(33, 61);
         this.textBoxInventoryCode.Name = "textBoxInventoryCode";
         this.textBoxInventoryCode.Size = new System.Drawing.Size(247, 20);
         this.textBoxInventoryCode.TabIndex = 0;
         // 
         // buttonSave
         // 
         this.buttonSave.Location = new System.Drawing.Point(63, 149);
         this.buttonSave.Name = "buttonSave";
         this.buttonSave.Size = new System.Drawing.Size(75, 23);
         this.buttonSave.TabIndex = 2;
         this.buttonSave.UseVisualStyleBackColor = true;
         this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
         // 
         // buttonCancel
         // 
         this.buttonCancel.Location = new System.Drawing.Point(168, 149);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(75, 23);
         this.buttonCancel.TabIndex = 3;
         this.buttonCancel.UseVisualStyleBackColor = true;
         this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
         // 
         // InventoryCodeControlForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(316, 210);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.buttonSave);
         this.Controls.Add(this.textBoxInventoryCode);
         this.Name = "InventoryCodeControlForm";
         this.Load += new System.EventHandler(this.InventoryCodeControlForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.TextBox textBoxInventoryCode;
      private System.Windows.Forms.Button buttonSave;
      private System.Windows.Forms.Button buttonCancel;
   }
}