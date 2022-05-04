namespace MP3TagEditor
{
   internal static partial class DialogContext
   {
      public class Track
      {
         public int No { get; }
         public string OldFilename { get; }
         public string Trackname { get; set; }
         public string NewFilename { get; set; }
         public string Artist { get; set; }
         public string Album { get; set; }

         public Track(int no, string oldFilename, string trackname, string newFilename, string artist, string album)
         {
            No = no;
            OldFilename = oldFilename;
            Trackname = trackname;
            NewFilename = newFilename;
            Artist = artist;
            Album = album;
         }
      }
   }
}
