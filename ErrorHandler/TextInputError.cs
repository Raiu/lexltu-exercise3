﻿namespace Exercise3;

public class TextInputError : UserError
{
    public override string UEMessage() => "You tried to use a text input in a numeric only field. This fired an error!";
}
