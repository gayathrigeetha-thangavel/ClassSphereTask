public class NumericInputError : UserError
{
    public override string UEMessage()
    {
        string inputError = "Custom Error - You tried to use a numeric input in a text only field. This fired an error!";
        return inputError ;
    }
}