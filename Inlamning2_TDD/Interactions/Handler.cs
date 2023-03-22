internal class Handler
{
    internal static string ErrorPrinter(Inlamning2_TDD.Models.ErrorMessageEnum error)
    {
        if (error == Inlamning2_TDD.Models.ErrorMessageEnum.WrongCommand)
        {
            Console.WriteLine("Sorry you have entered a Command formatted Wrong!");
            return null;
        }
        if (error == Inlamning2_TDD.Models.ErrorMessageEnum.InvalidFormat)
        {
            Console.WriteLine("Sorry you have entered a invalid Command! ");
            return null;
        }

        return null;
         
    }
}