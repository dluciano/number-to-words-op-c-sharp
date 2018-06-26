using NumberToWords;
using Shouldly;
using Xunit;

namespace NumberToWordsTests
{
    public class NumberToWordsStructuredTests
    {
        [Theory]
        [InlineData(0,"Zero")]
        [InlineData(1,"One")]
        [InlineData(2,"Two")]
        [InlineData(3,"Three")]
        [InlineData(4,"Four")]
        [InlineData(5,"Five")]
        [InlineData(6,"Six")]
        [InlineData(7,"Seven")]
        [InlineData(8,"Eight")]
        [InlineData(9,"Nine")]
        public void NtWUnitsTest(int n, string text)
        {
            n.ToWords().ShouldBe(text);
        }
        
        [Theory]
        [InlineData(10,"Ten")]
        [InlineData(11,"Eleven")]
        [InlineData(12,"Twelve")]
        [InlineData(13,"Thirteen")]
        [InlineData(14,"Fourteen")]
        [InlineData(15,"Fifteen")]
        [InlineData(16,"Sixteen")]
        [InlineData(17,"Seventeen")]
        [InlineData(18,"Eighteen")]
        [InlineData(19,"Nineteen")]
        public void NtWTens_10_19_Test(int n, string text)
        {
            n.ToWords().ShouldBe(text);
        }

        [Theory]
        [InlineData(20,"Twenty")]
        [InlineData(21,"Twenty-One")]
        [InlineData(22,"Twenty-Two")]
        [InlineData(23,"Twenty-Three")]
        [InlineData(24,"Twenty-Four")]
        [InlineData(25,"Twenty-Five")]
        [InlineData(26,"Twenty-Six")]
        [InlineData(27,"Twenty-Seven")]
        [InlineData(28,"Twenty-Eight")]
        [InlineData(29,"Twenty-Nine")]        
        [InlineData(30,"Thirty")]
        [InlineData(31,"Thirty-One")]
        [InlineData(39,"Thirty-Nine")]
        [InlineData(40,"Forty")]
        [InlineData(41,"Forty-One")]
        [InlineData(49,"Forty-Nine")]
        [InlineData(50,"Fifty")]
        [InlineData(51,"Fifty-One")]
        [InlineData(59,"Fifty-Nine")]
        [InlineData(60,"Sixty")]
        [InlineData(61,"Sixty-One")]
        [InlineData(69,"Sixty-Nine")]
        [InlineData(70,"Seventy")]
        [InlineData(71,"Seventy-One")]
        [InlineData(79,"Seventy-Nine")]
        [InlineData(80,"Eighty")]
        [InlineData(81,"Eighty-One")]
        [InlineData(89,"Eighty-Nine")]
        [InlineData(90,"Ninety")]
        [InlineData(91,"Ninety-One")]
        [InlineData(99,"Ninety-Nine")]
        public void NtWTens_20_99_Test(int n, string text)
        {
            n.ToWords().ShouldBe(text);
        }

        [Theory]
        [InlineData(100,"One hundred")]
        [InlineData(101,"One hundred and One")]
        [InlineData(109,"One hundred and Nine")]
        [InlineData(110,"One hundred and Ten")]
        [InlineData(119,"One hundred and Nineteen")]
        [InlineData(120,"One hundred and Twenty")]
        [InlineData(129,"One hundred and Twenty-Nine")]
        [InlineData(190,"One hundred and Ninety")]
        [InlineData(199,"One hundred and Ninety-Nine")]
        [InlineData(200,"Two hundred")]
        [InlineData(201,"Two hundred and One")]
        [InlineData(209,"Two hundred and Nine")]
        [InlineData(210,"Two hundred and Ten")]
        [InlineData(219,"Two hundred and Nineteen")]
        [InlineData(220,"Two hundred and Twenty")]
        [InlineData(229,"Two hundred and Twenty-Nine")]
        [InlineData(290,"Two hundred and Ninety")]
        [InlineData(299,"Two hundred and Ninety-Nine")]
        [InlineData(900,"Nine hundred")]
        [InlineData(999,"Nine hundred and Ninety-Nine")]
        public void NtWHundredsTest(int n, string text)
        {
            n.ToWords().ShouldBe(text);
        }

        [Theory]
        [InlineData(1000,"One thousand")]
        [InlineData(1001,"One thousand and One")]
        [InlineData(1010,"One thousand and Ten")]
        [InlineData(1011,"One thousand and Eleven")]
        [InlineData(1024,"One thousand and Twenty-Four")]
        [InlineData(1100,"One thousand and One hundred")]
        [InlineData(1101,"One thousand and One hundred and One")]
        [InlineData(1728,"One thousand and Seven hundred and Twenty-Eight")]
        [InlineData(101101,"One hundred One thousand and One hundred and One")]
        [InlineData(999999,"Nine hundred Ninety-Nine thousand and Nine hundred and Ninety-Nine")]
        public void NtWThousandsTest(int n, string text)
        {
            n.ToWords().ShouldBe(text);
        }

        [Theory]
        [InlineData(1000000,"One million")]
        [InlineData(1048576,"One million Forty-Eight thousand Five hundred and Seventy-Six")]
        public void NtWMillionsTest(int n, string text)
        {
            n.ToWords().ShouldBe(text);
        }        
    }
}
