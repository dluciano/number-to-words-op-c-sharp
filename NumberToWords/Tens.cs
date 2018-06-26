namespace NumberToWords
{
    internal class Tens : Number, IPositional
    {
        public Tens(int value) : base(value) { }

        public Tens(int value, IPositional prev) : base(value, prev) { }

        public override string ToWords()
        {
            switch (Value)
            {
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
                        case 5:
                            return "Fifteen";
                        case 8:
                            return "Eighteen";
                        case 4:
                        case 6:
                        case 7:
                        case 9:
                            return "teen";
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