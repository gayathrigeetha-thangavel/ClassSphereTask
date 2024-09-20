public class SpecialCharInputError : UserError
{
    public override string UEMessage()
    {
        string specialInputError = "Custom Error - You have entered special characters as an input. This fired an error!";
        return specialInputError ;
    }
}