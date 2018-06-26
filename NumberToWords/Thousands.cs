using System.Linq;

namespace NumberToWords
{
    internal class Thousands : AbstractPositional
    {
        private readonly INumber thousandsNumber;

        public Thousands(int value, AbstractPositional prev, Number parent) : base(value, prev)
        {
            if (parent.Value % 1000 != 0)
                OnSeparator = (p) => " and ";
            else
                OnSeparator = (p) => "";
            thousandsNumber = new Number(Value / 1000);
            thousandsNumber.Positionanls.OfType<Hundreds>().ToList().ForEach(d => d.OnSeparator = p => " ");
        }

        public override string ToWords() => thousandsNumber.ToWords() + " thousand";
    }
}