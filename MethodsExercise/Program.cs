namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}!");

            Console.WriteLine("What is your favorite color?");

            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite Animal?");

            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite Band?");

            string band = Console.ReadLine();

            Console.WriteLine($"Once upon a time, {name}'s {color} {animal} " +
                $"went for a run out in the wilderness. " +
                $"All of a sudden, {name}'s {animal} found itself lost! " +
                $"But, they followed the music of {band}, and found their way home!");

            Console.WriteLine("Thanks for playing!:)");


               
        }
    }
}
