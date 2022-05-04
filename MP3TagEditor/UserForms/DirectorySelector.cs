namespace MP3TagEditor.UserForms
{
   public partial class DirectorySelector : UserControl
   {
      public DirectorySelector()
      {
         InitializeComponent();
      }

      private void OnSearchFileClicked(object sender, EventArgs e)
      {
         FolderBrowserDialog fbd = new FolderBrowserDialog();
         if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
         {
            DialogContext.CurrentDir = fbd.SelectedPath;
         }
      }
   }
}
