using System;

public class TextInput {

    string inputValue;

    public virtual void Add(char newChar)
    {
        this.inputValue += newChar;
    }

    public string GetValue()
    {
        return inputValue;
    }
}

public class NumericInput: TextInput {
    public override void Add(char newChar)
    {
        if (!String.IsNullOrWhiteSpace(newChar.ToString()) && "0123456789".Contains(newChar.ToString()))
            base.Add(newChar);
    }
}

public class UserInput
{
    /*
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
        Console.ReadLine();
    }
    */
}