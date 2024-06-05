namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //EXERCISE 1

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


            //EXERCISE 2

            Console.WriteLine("What is your favorite school subject?");
            String favSub = Console.ReadLine();

            switch (favSub)
            {
                case "Math":
                    Console.WriteLine("Math? Nerd.");
                    break;
                case "Science":
                    Console.WriteLine("Science? Nerd");
                    break;
                case "History":
                    Console.WriteLine("History? Nerd.");
                    break;
                case "English":
                    Console.WriteLine("English? Nerd.");
                    break;
                case "PE":
                    Console.WriteLine("PE? Nerd.");
                    break;
                default:
                    Console.WriteLine("Interesting. Nerd.");
                    break;

            }



        }
    }
}
