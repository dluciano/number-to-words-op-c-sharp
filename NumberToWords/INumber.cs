using System.Collections.Generic;

namespace NumberToWords
{
    internal interface INumber : IWordable
    {
        int Value { get; }
        IReadOnlyCollection<IPositional> Positionanls { get; }
    }
}