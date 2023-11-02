using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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
