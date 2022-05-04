namespace MP3TagEditor.UserForms
{
   public partial class TrackGrid : UserControl
   {
      private BindingSource? _bindingSource;

      private bool _resetColumnFocus = false;
      private int _lastColumnIndex = 0;
      private int _lastRowIndex = 0;

      public TrackGrid()
      {
         InitializeComponent();
         gridSongs.AutoGenerateColumns = false;

         DialogContext.CurrentDirChanged += DialogContext_CurrentDirChanged;
      }

      private void DialogContext_CurrentDirChanged()
      {
         _bindingSource = new BindingSource();
         _bindingSource.DataSource = DialogContext.Tracks;

         gridSongs.SelectionChanged -= GridSongs_SelectionChanged;

         gridSongs.DataSource = _bindingSource;

         colNo.DataPropertyName = nameof(Track.No);
         colOldFilename.DataPropertyName = nameof(Track.OldFilename);
         colNewFilename.DataPropertyName = nameof(Track.NewFilename);
         colTrackname.DataPropertyName = nameof(Track.Trackname);

         gridSongs.SelectionChanged += GridSongs_SelectionChanged;
      }

      private void GridSongs_SelectionChanged(object? sender, EventArgs e)
      {
         if (_resetColumnFocus)
         {
            _resetColumnFocus = false;
            gridSongs.CurrentCell = gridSongs.Rows[_lastRowIndex].Cells[_lastColumnIndex];
         }
      }

      private void OnCellEndEdit(object sender, DataGridViewCellEventArgs e)
      {
         _resetColumnFocus = true;
         _lastRowIndex = e.RowIndex;
         _lastColumnIndex = e.ColumnIndex;

         _bindingSource?.ResetBindings(false);
      }
   }
}
