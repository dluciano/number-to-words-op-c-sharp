namespace NumberToWords
{
    internal class Units : AbstractPositional
    {
        public Units(int value) : base(value)
        {
            OnSeparator = p => "";
        }

        public override string ToWords()
        {
            //If the tens position is not zero and
            //The value of the unit is zero, do not return anything
            if (Next != null && (Value == 0 || Next.Value == 10))
                return "";

            switch (Value)
            {
                case 0: //Exceptional case, added in the method NumberToWords
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";
            }
            return "Undefined";
        }
    }
}