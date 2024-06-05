namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            int favNum = 5;
            Console.WriteLine("Guess my favorite number.");

            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNum)
            {
                Console.WriteLine("Too low.");
            }
            else if(userInput > favNum)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }




            
        }
    }
}
