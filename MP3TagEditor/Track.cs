namespace MP3TagEditor
{
   public class Track
   {
      public int No { get; }
      public string OldFilename { get; }
      public string Trackname { get; set; }
      public string Artist { get; set; }
      public string Album { get; set; }
      public string NewFilename => Trackname + ".mp3";

      public Track(int no, string oldFilename, string trackname, string artist, string album)
      {
         No = no;
         OldFilename = oldFilename;
         Trackname = trackname;
         Artist = artist;
         Album = album;
      }
   }
}
