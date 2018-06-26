using System;
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

        public virtual string ToWords() => string.Join(string.Empty, Positionanls.Select(p => p.ToWords() + p.OnSeparator(p)));

        private void CreatePositionals()
        {
            _positionals.Clear();
            var listWrapper = Enumerable.Empty<IPositional>().ToList();
            var positionalBase = 1;
            var i = 0;
            var auxDiv = 10;
            var auxVal = Value;
            var digitVal = -1;
            IPositional current = null;
            AbstractPositional prev = null;

            while (true)
            {
                positionalBase = (int)Math.Pow(10, aux[i].Item1);
                digitVal = auxVal % aux[i].Item2;
                var x = digitVal * positionalBase;
                switch (positionalBase)
                {
                    case 1:
                        current = new Units(x);
                        break;
                    case 10:
                        current = new Tens(x, prev);
                        break;
                    case 100:
                        current = new Hundreds(x, prev, this);
                        break;
                    case 1000:
                        current = new Thousands(x, prev, this);
                        break;
                    case 1_000_000:
                        current = new Millions(x, prev, this);
                        break;
                }

                listWrapper.Add(current);
                prev = (AbstractPositional)current;

                auxVal = auxVal / aux[i].Item2;
                if (auxVal <= 0)
                    break;
                i++;
            }
            listWrapper.Reverse();
            _positionals.AddRange(listWrapper);
        }

        private readonly Tuple<int, int>[] aux = new Tuple<int, int>[]
        {
            new Tuple<int, int>(0,10),
            new Tuple<int, int>(1,10),
            new Tuple<int, int>(2,10),
            new Tuple<int, int>(3,1000),
            new Tuple<int, int>(6,1000),
        };
    }
}