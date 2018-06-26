using System;
using System.Collections.Generic;

namespace NumberToWords
{
    internal abstract class AbstractPositional : IPositional
    {
        public IPositional Previous { get; }

        public IPositional Next { get; protected set; }

        public Func<INumber, string> OnSeparator { get; set; }

        public int Value { get; private set; }

        public IReadOnlyCollection<IPositional> Positionanls => throw new NotImplementedException();

        public AbstractPositional(int value) => Value = value;

        public AbstractPositional(int value, AbstractPositional prev)
        {
            Previous = prev;
            OnSeparator = p => "-";
            Value = value;
            prev.Next = this;
        }

        public abstract string ToWords();
    }
}