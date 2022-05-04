namespace MP3TagEditor
{
   internal static class ID3Reader
   {
      public static string ReadTitlename(string filename)
      {
         using (TagLib.File f = TagLib.File.Create(filename))
         {
            return f.Tag.Title;
         }
      }
   }
}
