internal class Handler
{
    internal string ErrorPrinter(cashRegister.ErrorMessageEnum error)
    {
        if (error == cashRegister.ErrorMessageEnum.WrongCommand) Console.WriteLine("Sorry you have entered a Command formatted Wrong!" );
        if (error == cashRegister.ErrorMessageEnum.InvalidInput) Console.WriteLine("Sorry you have entered a invalid Command! ");

        return null;
         
    }
}