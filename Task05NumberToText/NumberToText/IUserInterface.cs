namespace NumberToText
{
    internal interface IUserInterface
    {
        void ReadAndValidateNumber(string [] args);
        void ConvertNumberToWords();
    }
}
