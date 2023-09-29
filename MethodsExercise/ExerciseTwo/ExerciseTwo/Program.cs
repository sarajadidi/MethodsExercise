namespace ExerciseTwo;

class Program
{

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


    static void Main(string[] args)
    {

        Console.WriteLine("Methods Exercise # 2!");


        int addTwonums = MathAdd(3, 7);

        Console.WriteLine(addTwonums);


        int subtractingNumbers = MathSubtract(200, 50);

        Console.WriteLine(subtractingNumbers);


        int multiplyNumbers = MathMultiply(20, 5);

        Console.WriteLine(multiplyNumbers);


        int divideNumbers = MathDivision(200, 4);

        Console.WriteLine(divideNumbers);


    }

}

