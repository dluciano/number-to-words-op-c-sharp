namespace NumberToWords
{
    public static class NumberToWordsHelper
    {
        public static string ToWords(this int i)
        {
            if (i == 0)
                return "Zero";

            return NumberToWordsStructured.NtWMillions(i);
        }
    }
}
