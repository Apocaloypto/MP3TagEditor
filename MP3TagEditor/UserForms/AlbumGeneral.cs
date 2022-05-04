namespace MP3TagEditor.UserForms
{
   public partial class AlbumGeneral : UserControl
   {
      public AlbumGeneral()
      {
         InitializeComponent();

         DialogContext.CurrentDirChanged += DialogContext_CurrentDirChanged;
      }

      private void DialogContext_CurrentDirChanged()
      {
         tbxArtist.Text = DialogContext.Artist;
         tbxAlbum.Text = DialogContext.Album;
      }
   }
}
