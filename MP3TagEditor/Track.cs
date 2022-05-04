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

      private string _directory { get; }

      public Track(int no, FileInfo info)
      {
         ID3Reader.RelevantID3Tags metaId3 = ID3Reader.ReadMetadata(info.FullName);
         
         No = no + 1;
         OldFilename = info.Name;
         Trackname = metaId3.Title;
         Artist = metaId3.Artist;
         Album = metaId3.Album;
         _directory = info.DirectoryName!;
      }
   }
}
