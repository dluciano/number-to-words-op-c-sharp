namespace NumberToWords
{
    static class NumberToWordsStructured
    {
        private static string NtWUnits(int i)
        {
            switch (i)
            {
                case 0: //Exceptional case, added in the method NumberToWords
                    return "";
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
            return "Undefined Unit_0_9: " + i;
        }

        private static string NtW_Tens_10_19(int i)
        {
            switch (i)
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
            return "Undefined Ten_10_19: " + i;
        }

        public static string NtWTens(int i)
        {
            if (i > 99)
                return "";

            string tTxt = "";
            string uTxt = "";
            int t = i / 10;
            int u = (i - (t * 10)) % 10;

            if (t == 1)
            {
                tTxt = NtW_Tens_10_19(u);
            }
            else
            {
                if (t >= 2 && t <= 9)
                {
                    switch (t)
                    {
                        case 2:
                            tTxt = "Twenty";
                            break;
                        case 3:
                            tTxt = "Thirty";
                            break;
                        case 4:
                            tTxt = "Forty";
                            break;
                        case 5:
                            tTxt = "Fifty";
                            break;
                        case 6:
                            tTxt = "Sixty";
                            break;
                        case 7:
                            tTxt = "Seventy";
                            break;
                        case 8:
                            tTxt = "Eighty";
                            break;
                        case 9:
                            tTxt = "Ninety";
                            break;
                        default:
                            tTxt = "Undefined Ten!: " + i;
                            break;
                    }

                    tTxt = tTxt + ((u > 0) ? "-" : "");
                }

                if (u >= 0 && u <= 9)
                    uTxt = NtWUnits(u);
            }

            return tTxt + uTxt;
        }

        public static string NtWHundreds(int i, string hundredsTextSeparator = " and ")
        {
            if (i > 999)
                return "";

            string hTxt = "";

            int h = i / 100;
            int t = (i - (h * 100)) / 10;
            int u = (i - (h * 100)) % 10;

            if (h > 0)
            {
                hTxt = NtWUnits(h) + " hundred" + (t > 0 || u > 0 ? hundredsTextSeparator : "");
            }

            return hTxt + NtWTens(i - (h * 100));
        }

        public static string NtWThousands(int i, string separator = " and ")
        {
            if (i > 999999)
                return "";

            string thTxt = "";
            string aux = "";

            int th = i / 1000;
            if (th > 0 && th < 1000)
            {
                thTxt = NtWHundreds(th, " ") + " thousand";
            }

            aux = NtWHundreds(i - (th * 1000));

            return thTxt + (string.IsNullOrEmpty(aux) ? "" : (th > 0 ? separator + aux : aux));
        }

        public static string NtWMillions(int i)
        {
            if (i > 999999999)
                return "";

            string mTxt = "";
            string aux = "";

            int m = i / 1000000;
            if (m > 0 && m < 1000)
            {
                mTxt = NtWHundreds(m, " ") + " million";
            }

            aux = NtWThousands(i - (m * 1000000), m > 0 ? " " : " and ");

            return mTxt + (string.IsNullOrEmpty(aux) ? "" : (m > 0 ? " " + aux : aux));
        }
    }
}
