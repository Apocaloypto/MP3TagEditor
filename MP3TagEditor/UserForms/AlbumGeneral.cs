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

      public void ApplyValues()
      {
         DialogContext.Artist = tbxArtist.Text;
         DialogContext.Album = tbxAlbum.Text;

         if (DialogContext.Tracks != null)
         {
            foreach (var track in DialogContext.Tracks)
            {
               track.Artist = DialogContext.Artist;
               track.Album = DialogContext.Album;
            }
         }
      }
   }
}
