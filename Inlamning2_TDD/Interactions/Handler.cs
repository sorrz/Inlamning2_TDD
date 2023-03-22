internal class Handler
{
    internal static void ErrorPrinter(Inlamning2_TDD.Models.ErrorMessageEnum error)
    {
        if (error == Inlamning2_TDD.Models.ErrorMessageEnum.WrongCommand)
        {
            Console.WriteLine("Sorry you have entered a Command formatted Wrong!");
        }
        if (error == Inlamning2_TDD.Models.ErrorMessageEnum.InvalidFormat)
        {
            Console.WriteLine("Sorry you have entered a invalid Command! ");
        }
        if (error == Inlamning2_TDD.Models.ErrorMessageEnum.EmptyString)
        {
            Console.WriteLine("You didn't enter anything, try again! ");
        }

         
    }
}