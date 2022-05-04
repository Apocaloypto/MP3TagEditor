namespace MP3TagEditor.UserForms
{
   public partial class OkCancel : UserControl
   {
      public event Action? OnSave;
      public event Action? OnQuit;

      public OkCancel()
      {
         InitializeComponent();
      }

      private void OnClickedSave(object sender, EventArgs e)
      {
         OnSave?.Invoke();
      }

      private void OnClickedQuit(object sender, EventArgs e)
      {
         OnQuit?.Invoke();
      }
   }
}
