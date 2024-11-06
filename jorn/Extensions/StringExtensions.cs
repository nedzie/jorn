namespace jorn.Extensions
{
    public static class StringExtensions
    {
        public static string AsTimeSpan(this string str)
        {
            return str.Insert(2, ":");
        }
    }
}
