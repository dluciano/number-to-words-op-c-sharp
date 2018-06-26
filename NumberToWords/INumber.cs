namespace NumberToWords
{
    internal interface INumber : IWordable
    {
        int Value { get; }
    }
}