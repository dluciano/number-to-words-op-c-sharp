namespace NumberToWords
{
    internal interface IPositional : IWordable, INumber
    {
        IPositional Previous { get; }
        //TODO: I dont like the set here....
        IPositional Next { get; set; }
    }
}