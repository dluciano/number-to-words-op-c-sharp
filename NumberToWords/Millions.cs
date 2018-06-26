using System.Linq;

namespace NumberToWords
{
    internal class Millions : AbstractPositional
    {
        private readonly INumber thousandsNumber;

        public Millions(int value, AbstractPositional prev, Number parent) : base(value, prev)
        {
            if (parent.Value % 1_000_000 != 0)
                OnSeparator = (p) => " ";
            else
                OnSeparator = (p) => "";
            thousandsNumber = new Number(Value / 1_000_000);
            thousandsNumber.Positionanls.OfType<Hundreds>().ToList().ForEach(d => d.OnSeparator = p => " ");
            thousandsNumber.Positionanls.OfType<Thousands>().ToList().ForEach(d => d.OnSeparator = p => " ");
        }

        public override string ToWords() => thousandsNumber.ToWords() + " million";
    }
}