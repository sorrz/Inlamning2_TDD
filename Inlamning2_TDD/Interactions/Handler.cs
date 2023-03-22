internal class Handler
{
    internal string ErrorPrinter(Inlamning2_TDD.Models.ErrorMessageEnum error)
    {
        if (error == Inlamning2_TDD.Models.ErrorMessageEnum.WrongCommand) Console.WriteLine("Sorry you have entered a Command formatted Wrong!" );
        if (error == Inlamning2_TDD.Models.ErrorMessageEnum.InvalidFormat) Console.WriteLine("Sorry you have entered a invalid Command! ");

        return null;
         
    }
}