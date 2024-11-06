namespace jorn.Extensions
{
    public static class StringExtensions
    {
        public static string ToTimeSpanFormat(this string str)
        {
            return str.Insert(2, ":");
        }
    }
}
