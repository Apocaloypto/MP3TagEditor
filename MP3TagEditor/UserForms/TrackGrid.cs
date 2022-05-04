namespace MP3TagEditor.UserForms
{
   public partial class TrackGrid : UserControl
   {
      public TrackGrid()
      {
         InitializeComponent();
         gridSongs.AutoGenerateColumns = false;

         DialogContext.CurrentDirChanged += DialogContext_CurrentDirChanged;
      }

      private void DialogContext_CurrentDirChanged()
      {
         gridSongs.DataSource = DialogContext.Tracks;

         colNo.DataPropertyName = nameof(Track.No);
         colOldFilename.DataPropertyName = nameof(Track.OldFilename);
         colNewFilename.DataPropertyName = nameof(Track.NewFilename);
         colTrackname.DataPropertyName = nameof(Track.Trackname);
      }
   }
}
