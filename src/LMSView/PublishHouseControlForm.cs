using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSController;

namespace LMSView
{
   public partial class PublishHouseControlForm : Form
   {
      private NViewHelper.FormViewMode viewModeForm;
      private IPublishHouseInformationRegister publishHouseInformationRegister;
      private PublishHouseInformation publishHouseInfo;

      public PublishHouseControlForm(NViewHelper.FormViewMode mode,
             IPublishHouseInformationRegister publishHouseRegister, string name = null)
      {
         viewModeForm = mode;
         publishHouseInformationRegister = publishHouseRegister;
         publishHouseInformationRegister.OnOperationExecute += PrintMessageForUser;
         publishHouseInfo = publishHouseInformationRegister.FindPublishHouseByName(name);

         InitializeComponent();
      }

      private static void PrintMessageForUser(bool result)
      {
         if (result == true)
         {
            MessageBox.Show(Properties.Resources.operationOK, Properties.Resources.successfull,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }
         else
         {
            MessageBox.Show(Properties.Resources.operationNOK, Properties.Resources.failed,
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
         }
      }

      private PublishHouseInformation PackagePublishHouse(PublishHouseInformation targetPublishHouse)
      {
         targetPublishHouse.Name = textBoxName.Text;
         targetPublishHouse.Location = textBoxLocation.Text;
         targetPublishHouse.Category = textBoxCategory.Text;
         return targetPublishHouse;
      }

      private void ButtonDelete_Click(object sender, EventArgs e)
      {
         if (NViewHelper.FormViewMode.Edit == viewModeForm)
         {
            publishHouseInformationRegister.DeletePublishHouse(PackagePublishHouse(publishHouseInfo));
         }
         
      }

      private void ButtonSave_Click(object sender, EventArgs e)
      {
         publishHouseInformationRegister.AddPublishHouse(PackagePublishHouse(new PublishHouseInformation()));
      }

      private void PublishHouseControlPanel_Paint(object sender, PaintEventArgs e)
      {
         buttonSave.Text = Properties.Resources.save;
         buttonDelete.Text = Properties.Resources.delete;

         labelName.Text = Properties.Resources.publishHouseName;
         labelLocation.Text = Properties.Resources.location;
         labelCategory.Text = Properties.Resources.category;

         if (NViewHelper.FormViewMode.Edit == viewModeForm)
         {
            Text = Properties.Resources.edit;
         }
         else
         {
            Text = Properties.Resources.add;
            labelName.Text = NViewHelper.ViewHelper.MarkFieldAsImportant(labelName.Text);
         }
      }
   }
}
