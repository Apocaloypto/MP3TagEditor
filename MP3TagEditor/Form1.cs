using System.ComponentModel.DataAnnotations;

namespace MP3TagEditor
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();

         okCancel1.OnSave += OkCancel1_OnSave;
         okCancel1.OnQuit += OkCancel1_OnQuit;
      }

      private void OkCancel1_OnSave()
      {
         try
         {
            albumGeneral1.ApplyValues();
            DialogContext.Validate();
         }
         catch (ValidationException ex)
         {
            MessageBox.Show($"Error while saving the changes: {ex.Message}");
         }
      }

      private void OkCancel1_OnQuit()
      {
         Close();
      }
   }
}