using System;
using System.Windows.Forms;

namespace LMSView
{

   public delegate void SetInventoryCode(int code);

   public partial class InventoryCodeControlForm : Form
   {
      private NViewHelper.FormViewMode viewMode;
      private int inventoryCode;
      public event SetInventoryCode AddNewBookExample;
      public event SetInventoryCode EditNewBookExample;

      public InventoryCodeControlForm(int selectedCode) : this(NViewHelper.FormViewMode.Edit, selectedCode)
      { }
      public InventoryCodeControlForm() : this(NViewHelper.FormViewMode.Create, 0)
      { }

      private InventoryCodeControlForm(NViewHelper.FormViewMode view, int code)
      {
         viewMode = view;
         inventoryCode = code;
         InitializeComponent();
      }

      private void InventoryCodeControlForm_Load(object sender, EventArgs e)
      {
         Text = Properties.Resources.inventoryCodeWelcome;
         buttonCancel.Text = DialogResult.Cancel.ToString();
         buttonSave.Text = Properties.Resources.save;

         if (NViewHelper.FormViewMode.Edit == viewMode)
         {
            textBoxInventoryCode.Text = inventoryCode.ToString();
         }
      }

      private void ButtonSave_Click(object sender, EventArgs e)
      {
         if (false == String.IsNullOrEmpty(textBoxInventoryCode.Text))
         {
            int newCode = Convert.ToInt32(textBoxInventoryCode.Text);
            if (NViewHelper.FormViewMode.Edit == viewMode)
            {
               EditNewBookExample(inventoryCode);
            }
            AddNewBookExample(newCode);
            Close();
         }
      }

      private void ButtonCancel_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
