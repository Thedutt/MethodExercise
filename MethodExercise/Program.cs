using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int age;
            string name;
            string color;
            string animal;
            string band;
            int num1;
            int num2;
            

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your favorite color?");
            color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            band = Console.ReadLine();

            Console.WriteLine("Your name is " + name + " and your age is " + age);
            Console.WriteLine("For some reason your favorite color is " + color);
            Console.WriteLine("Even stranger is that your favorite animal is a " + animal);
            Console.WriteLine("However you saved yourself by having the favorite band " + band);

            Console.WriteLine("Give me any number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to add");
            num2 = int.Parse(Console.ReadLine());

            int sum = Add(num1, num2);
            Console.WriteLine($"Your number is {sum}");

            Console.WriteLine("Lets do a multiplication now. Give me another number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ok now give me another");
            num2= int.Parse(Console.ReadLine());

            int mult = Multiply(num1, num2);
            Console.WriteLine($"your number is {mult}");

            Console.WriteLine("Lets try to do a division one now. Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("what is another number?");
            num2 = int.Parse(Console.ReadLine());

            int div = Division(num1, num2);
            Console.WriteLine($"your number is {div}");

        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Division(int x, int y)
        {
            return x / y;
        }
       
    }
}
