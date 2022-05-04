namespace MP3TagEditor
{
   internal static class ID3Reader
   {
      public class RelevantID3Tags
      {
         public string Title { get; set; }
         public string Album { get; set; }
         public string Artist { get; set; }

         public RelevantID3Tags(string title, string album, string artist)
         {
            Title = title;
            Album = album;
            Artist = artist;
         }
      }

      public static RelevantID3Tags ReadMetadata(string filename)
      {
         using (TagLib.File f = TagLib.File.Create(filename))
         {
            return new RelevantID3Tags(f.Tag.Title, f.Tag.Album, f.Tag.Performers.FirstOrDefault() ?? string.Empty);
         }
      }
   }
}
