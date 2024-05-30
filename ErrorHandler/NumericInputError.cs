namespace Exercise3;

public class NumericInputError :  UserError
{
    public override string UEMessage() => "You tried to use a numeric input in a text only field. This fired an error!";
}
