using System.Text.RegularExpressions;

namespace MP3TagEditor
{
   internal static class EnumerableExtensions
   {
      private static IOrderedEnumerable<T> OrderByAlphaNumeric<T>(this IEnumerable<T> source, Func<T, string> selector, bool asc)
      {
         int max = source
             .SelectMany(i => Regex.Matches(selector(i), @"\d+").Cast<Match>().Select(m => (int?)m.Value.Length))
             .Max() ?? 0;

         Func<T, string> orderby = i => Regex.Replace(selector(i), @"\d+", m => m.Value.PadLeft(max, '0'));

         if (asc)
         {
            return source.OrderBy(orderby);
         }
         else
         {
            return source.OrderByDescending(orderby);
         }
      }
   }
}
