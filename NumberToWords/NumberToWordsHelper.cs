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

        public static string ToWordsOP(this int i) => new Number(i).ToWords();
    }
}
