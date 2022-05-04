namespace MP3TagEditor
{
   internal static class DialogContext
   {
      public class Track
      {
         public int No { get; }
         public string OldFilename { get; }
         public string Trackname { get; set; }
         public string NewFilename { get; set; }

         public Track(int no, string oldFilename, string trackname, string newFilename)
         {
            No = no;
            OldFilename = oldFilename;
            Trackname = trackname;
            NewFilename = newFilename;
         }
      }

      private static string? _currentDir;
      public static string? CurrentDir
      {
         get => _currentDir;
         set
         {
            if (value != _currentDir)
            {
               _currentDir = value;

               if (!string.IsNullOrEmpty(_currentDir))
               {
                  FillTracklist();
               }

               CurrentDirChanged?.Invoke(_currentDir);
            }
         }
      }

      public static event Action<string?>? CurrentDirChanged;
      public static string? Artist { get; set; }
      public static string? Album { get; set; }
      public static IList<Track>? Tracks { get; set; }

      private static Track CreateTrackFromFileInfo(int num, FileInfo info)
      {
         string titleId3 = ID3Reader.ReadTitlename(info.FullName);
         return new Track(num, info.Name, titleId3, titleId3 + info.Extension);
      }

      private static void FillTracklist()
      {
         try
         {
            var di = new DirectoryInfo(_currentDir!);
            Tracks = di.GetFiles()
               .Where(file => Path.GetExtension(file.FullName).ToUpper() == ".MP3")
               .Select((fi, index) => CreateTrackFromFileInfo(index, fi))
               .OrderBy(t => t.Trackname)
               .ToList();
         }
         catch
         {
         }
      }
   }
}
