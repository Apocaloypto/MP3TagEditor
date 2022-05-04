using System.ComponentModel.DataAnnotations;

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
         return new Track(num + 1, info.Name, metaId3.Title, metaId3.Artist, metaId3.Album);
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

      private static void Validate()
      {
         if (string.IsNullOrEmpty(Artist))
         {
            throw new ValidationException($"{nameof(Artist)} must not be empty.");
         }

         if (string.IsNullOrEmpty(Album))
         {
            throw new ValidationException($"{nameof(Album)} must not be empty.");
         }

         if (Tracks != null && Tracks.Select(t => t.Trackname).GroupBy(n => n).Any(g => g.Count() > 1))
         {
            throw new ValidationException("Some tracks have the same title.");
         }
      }

      public static void Save()
      {
         Validate();
      }
   }
}
