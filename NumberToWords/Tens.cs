namespace NumberToWords
{
    internal class Tens : AbstractPositional
    {
        public Tens(int value, AbstractPositional prev) : base(value, prev)
        {
            if (Previous.Value == 0 || Value == 10 || Value == 0)
                OnSeparator = p => "";
        }

        public override string ToWords()
        {
            switch (Value)
            {
                case 0:
                    return "";
                case 10:
                    switch (Previous.Value)
                    {
                        case 0:
                            return "Ten";
                        case 1:
                            return "Eleven";
                        case 2:
                            return "Twelve";
                        case 3:
                            return "Thirteen";
                        case 4:
                            return "Fourteen";
                        case 5:
                            return "Fifteen";
                        case 6:
                            return "Sixteen";
                        case 7:
                            return "Seventeen";
                        case 8:
                            return "Eighteen";
                        case 9:
                            return "Nineteen";
                    }
                    return "Invalid!";
                case 20:
                    return "Twenty";
                case 30:
                    return "Thirty";
                case 40:
                    return "Forty";
                case 50:
                    return "Fifty";
                case 60:
                    return "Sixty";
                case 70:
                    return "Seventy";
                case 80:
                    return "Eighty";
                case 90:
                    return "Ninety";
            }
            return "Undefined!";
        }
    }
}