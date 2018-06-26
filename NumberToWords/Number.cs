using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NumberToWords
{
    //TODO: This class should be a read only list of IPositional
    internal class Number : INumber
    {
        public int Value { get; private set; }

        private readonly List<IPositional> _positionals = Enumerable.Empty<IPositional>().ToList();
        public IReadOnlyCollection<IPositional> Positionanls
        {
            get
            {
                if (_positionals.Count == 0)
                    CreatePositionals();
                return _positionals;
            }
        }

        public Number(int value) => Value = value;

        public virtual string ToWords() => string.Join(string.Empty, Positionanls.Select(p => {

            return p.ToWords() + p.OnSeparator(p);
        }));

        private void CreatePositionals()
        {
            _positionals.Clear();
            var listWrapper = Enumerable.Empty<IPositional>().ToList();
            var div = 1;
            var auxDiv = 10;
            var auxVal = Value;
            var digitVal = -1;
            IPositional current = null;
            AbstractPositional prev = null;

            while (true)
            {
                digitVal = auxVal % auxDiv;
                switch (div)
                {
                    case 1:
                        current = new Units(digitVal);
                        break;
                    case 10:
                        current = new Tens(digitVal * 10, prev);
                        break;
                    case 100:
                        current = new Hundreds(digitVal * 100, prev, this);
                        break;
                    case 1000:                        
                        current = new Thousands(digitVal * 1000, prev, this);
                        break;
                }

                listWrapper.Add(current);
                prev = (AbstractPositional)current;

                auxVal = auxVal / auxDiv;
                if (auxVal <= 0)
                    break;
                div *= 10;
                auxDiv = div <= 100 ? 10 : 1000;
            }
            listWrapper.Reverse();
            _positionals.AddRange(listWrapper);
        }

    }
}