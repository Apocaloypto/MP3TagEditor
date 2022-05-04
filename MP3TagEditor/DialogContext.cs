namespace MP3TagEditor
{
   internal static partial class DialogContext
   {
      private static string? _currentDir;
      public static string? CurrentDir
      {
         get => _currentDir;
         set
         {
            if (value != _currentDir)
            {
               _currentDir = value;

               FillTracklist();
               InitArtistAlbum();

               CurrentDirChanged?.Invoke();
            }
         }
      }

      public static event Action? CurrentDirChanged;
      public static string? Artist { get; set; }
      public static string? Album { get; set; }
      public static IList<Track>? Tracks { get; set; }

      private static Track CreateTrackFromFileInfo(int num, FileInfo info)
      {
         ID3Reader.RelevantID3Tags metaId3 = ID3Reader.ReadMetadata(info.FullName);
         return new Track(num, info.Name, metaId3.Title, metaId3.Title + info.Extension, metaId3.Artist, metaId3.Album);
      }

      private static void FillTracklist()
      {
         try
         {
            if (!string.IsNullOrEmpty(_currentDir))
            {
               var di = new DirectoryInfo(_currentDir);
               Tracks = di.GetFiles()
                  .Where(file => Path.GetExtension(file.FullName).ToUpper() == ".MP3")
                  .Select((fi, index) => CreateTrackFromFileInfo(index, fi))
                  .OrderByAlphaNumeric(t => t.Trackname, true)
                  .ToList();
            }
            else
            {
               Tracks = null;
            }
         }
         catch
         {
         }
      }

      private static void InitArtistAlbum()
      {
         if (Tracks != null && Tracks.Count > 0 && !string.IsNullOrEmpty(CurrentDir))
         {
            Artist = Tracks[0].Artist;
            Album = Tracks[0].Album;
         }
         else
         {
            Artist = null;
            Album = null;
         }
      }
   }
}
