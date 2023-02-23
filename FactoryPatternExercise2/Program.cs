namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I do realize we were told to use another interface.");
            Console.WriteLine("However, I did that in exercise #1 and wanted to experiment");
            Console.WriteLine("with using an abstract class so that some implementation");
            Console.WriteLine("could be done in the base class. I hate that limitation");
            Console.WriteLine("with interfaces and prefer an abstract class so long as I");
            Console.WriteLine("don't need to implement more than one.");
            Console.WriteLine();
            Console.WriteLine("Enter your desired DB:");
            string userInput = Console.ReadLine();
            try
            {
                DBAccess newConnector = DBFactory.GetAccessor(userInput);
                Console.WriteLine("---");
                newConnector.PrintSummary();
                newConnector.Select();
                newConnector.Insert();
                newConnector.Delete();
                newConnector.Update();
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
