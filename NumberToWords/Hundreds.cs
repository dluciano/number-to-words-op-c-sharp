namespace NumberToWords
{
    internal class Hundreds : Number, IPositional
    {
        private Number digit;
        public Hundreds(int value, IPositional prev, Number parent) : base(value, prev)
        {
            if (parent.Value % 100 != 0)
                Separator = " and ";
            else
                Separator = "";
            digit = new Number(Value / 100);
        }

        public override string ToWords()
        {
            return digit.ToWords() + " hundred";
        }
    }
}