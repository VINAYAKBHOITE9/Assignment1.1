public class Program
{
    public static void Main(string [] args)
    {
        Console.WriteLine("Choose what you want to perform");
        Console.WriteLine("Enter 1 for addition");
        Console.WriteLine("Enter 2 for substraction");
        Console.WriteLine("Enter 3 for multiplication");
        Console.WriteLine("Enter 4 for division");

        int ChooseAction= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 1 st number");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 1 st number");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        switch (ChooseAction)
        {
                case 1:
                {
                    result = Addition(number1 , number2);
                    break;
                }
                case 2:
                {
                    result = Substraction(number1 , number2);
                    break;
                }
                case 3:
                {
                    result = Multiplication(number1 , number2);
                    break;
                }
                case 4:
                {
                    result = Division(number1 , number2);
                    break;
                }
                default:
                Console.WriteLine("invalid input");
                break;  
        }
        Console.WriteLine("The result is {0}", result);
        Console.ReadLine();

    }
    public static int Addition(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
    public static int Substraction(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
    public static int Multiplication(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }
    public static int Division(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }

}