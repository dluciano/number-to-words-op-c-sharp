using System.Linq;
namespace NumberToWords
{
    internal class Hundreds : AbstractPositional
    {
        private Number number;
        public Hundreds(int value, AbstractPositional prev, Number parent) : base(value, prev)
        {
            if (Value != 0 && parent.Value % 100 != 0)
                OnSeparator = p => " and ";
            else if (Value == 0 || Value % 100 == 0)
                OnSeparator = p => "";
            number = new Number(Value / 100);
            number.Positionanls.ToList().ForEach(d => d.OnSeparator = p => "");
        }

        public override string ToWords() => Value == 0 ? "" : number.ToWords() + " hundred";
    }
}