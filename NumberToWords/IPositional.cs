using System;

namespace NumberToWords
{
    internal interface IPositional : INumber
    {
        IPositional Previous { get; }
        IPositional Next { get; }
        Func<INumber, string> OnSeparator { get; set; }
    }
}