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
      }

      private void OkCancel1_OnQuit()
      {
      }
   }
}