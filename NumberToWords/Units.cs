namespace NumberToWords
{
    internal class Units : Number, IPositional
    {
        public Units(int value) : base(value) { }

        public Units(int value, IPositional prev) : base(value, prev) { }

        public override string ToWords()
        {
            //If the tens position is not zero and
            //The value of the unit is zero, do not return anything
            if (Next != null && Next.Value != 0 && Value == 0)
                return "";

            //If the tens position is 10 do not
            //return empty value when the unit is: 1,2,3,5,8 (edge cases)
            //otherwise return the value normally
            if (Next != null && Next.Value == 10)
            {
                switch (Value)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 5:
                    case 8:
                        return "";
                }
            }

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