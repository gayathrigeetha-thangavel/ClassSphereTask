public class TextInputError : UserError
{
    public override string UEMessage()
    {
        string textInputError = "Custom Error - You tried to use a text input in a numeric only field. This fired an error!";
        return textInputError ;
    }
}