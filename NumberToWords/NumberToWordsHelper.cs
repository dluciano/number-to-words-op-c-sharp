using System.Collections.Generic;
using System.Linq;

namespace NumberToWords
{
    public static class NumberToWordsHelper
    {
        public static string ToWords(this int i) =>
            i == 0 ? "Zero" : NumberToWordsStructured.NtWMillions(i);

        public static string ToWordsOP(this int i) => new Number(i).ToWords();

        public static IEnumerable<T> NotOfType<T, U>(this IEnumerable<T> source) =>
            source.Where(t => !(t is U));
    }
}
