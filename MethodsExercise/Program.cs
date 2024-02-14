using System.Drawing;
using System.Reflection;

namespace MethodsExercise
{
    class Program

    {
        //-----------exercise 2-----------
        public static int Sum(int num1, int num2)
        {
        var answer = num1 + num2;
        return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        public static int Divide(int num1, int num2)
        { 
            return num1 / num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {
            //Declare 5 methods:
            //1 Add method
            //1 Subtract method
            //1 Multiply method
            //1 Divide method
            //1 Modulus method

            var amountOfCars = Sum(2, 6);
            var amountOfDogs = Multiply(33, 1, 20);
            var amountOfTrucks = Divide(10, 5);
            var amountOfCats = Subtract(20, 5);
            var amountOfLeftovers = Modulus(40, 9);

            Console.WriteLine($"{amountOfCars}, {amountOfDogs}, {amountOfTrucks}, {amountOfCats}, {amountOfLeftovers}");

        //-------------exercise 1-------------
        //Your Name
        //Your Favorite Color
        //Your Favorite Animal
        //Your Favorite Band

        Console.WriteLine("Hello, what is your name?");

            var userName = Console.ReadLine();

            Console.WriteLine($" Hi! {userName}. What is your favorite color?");

            var favoriteColor = Console.ReadLine();

            Console.WriteLine($"{favoriteColor} is a great color! What is your favorite animal?");

            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine("Good choice! What's your favoite band?");

            var favoriteBand = Console.ReadLine();

            Console.WriteLine("Cool! That's mine too!");


            Console.WriteLine("Here is your user profile:");
            
            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {favoriteColor}");
            Console.WriteLine($"Favorite Animal: {favoriteAnimal}");
            Console.WriteLine($"Favorite Band: {favoriteBand}");

        }
    }
}
