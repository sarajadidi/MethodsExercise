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

            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Methods Exercise # 2!");


            int addTwonums = MathAdd(3, 7);

            Console.WriteLine(addTwonums);


            int subtractingNumbers = MathSubtract(200, 50);

            Console.WriteLine(subtractingNumbers);


            int multiplyNumbers = MathMultiply(20, 5);

            Console.WriteLine(multiplyNumbers);


            int divideNumbers = MathDivision(200, 4);

            Console.WriteLine(divideNumbers);


            int modulusNumber = MathModule(5, 2);

            Console.WriteLine(modulusNumber);

        }
        public static int MathAdd(int num1, int num2)
        {
            return num1 + num2;

        }

        public static int MathSubtract(int num1, int num2)
        {
            return num1 - num2;

        }

        public static int MathMultiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int MathDivision(int num1, int num2)
        {
            return num1 / num2;

        }

        public static int MathModule(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
