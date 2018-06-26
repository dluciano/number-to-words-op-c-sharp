using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NumberToWords
{
    //TODO: This class should be a read only list of IPositional
    internal class Number : INumber, IPositional
    {
        public int Value { get; private set; }

        public IPositional Previous { get; private set; }

        public IPositional Next { get; set; }

        private Positionals _positionals;

        public Number(int value)
        {
            Value = value;
        }

        public Number(int value, IPositional prev) : this(value)
        {
            Previous = prev;
            Previous.Next = this;
        }

        public virtual string ToWords()
        {
            if (_positionals == null)
                _positionals = new Positionals(this);
            return _positionals.ToWords();
        }

        private class Positionals : IWordable
        {
            private readonly List<IPositional> listWrapper = new List<IPositional>();
            private readonly Number _number;

            public Positionals(Number number)
            {
                _number = number;
                var div = 10;
                var auxVal = number.Value;
                var digitVal = -1;
                IPositional current = null;
                IPositional prev = null;

                while (true)
                {
                    digitVal = auxVal % div;
                    switch (div)
                    {
                        case 10:
                            current = new Units(digitVal);
                            break;
                        case 100:
                            current = new Tens(digitVal * 10, prev);
                            break;
                    }
                    listWrapper.Add(current);
                    prev = current;

                    auxVal = auxVal / div;
                    if (auxVal <= 0)
                        break;

                    div *= 10;
                }
            }

            //TODO: How can I call the GetEnumerator here?
            public string ToWords() => string.Join("", listWrapper.Select(p => p.ToWords()));
        }
    }
}