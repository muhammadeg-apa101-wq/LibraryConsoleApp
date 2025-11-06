using Domain.Models;
using Services;
using Services.Helpers;
using System.Runtime.CompilerServices;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option:");
            Helper.MessageColor(ConsoleColor.Cyan, "Library: 1-Create 2-Update 3-Get 4-GetAll 5-Delete");
            LibraryService  libraryService = new LibraryService();

            while (true) 
            {
            Input: string input = Console.ReadLine();
                int number;
                bool isConvert = int.TryParse(input, out number);

                if (isConvert) 
                {
                    switch (number) 
                    {
                        case 1:
                            Console.WriteLine("Name:");
                            string name = Console.ReadLine();

                            Console.WriteLine("Seat Count:");
                            int seatCount = Convert.ToInt32(Console.ReadLine());

                            Library library = new Library
                            {
                                Name = name,
                                SeatCount = seatCount
                            };
                            var newLibrary = libraryService.Create(library);
                            Helper.MessageColor(ConsoleColor.Green, $"Library ID: {newLibrary.Id}, Library name: {newLibrary.Name}, Library seat count: {newLibrary.SeatCount}");
                            break;


                            case 2:
                            Console.WriteLine("Update");
                            break;

                            case 3:
                            Console.WriteLine("Get");
                            break;

                            case 4:
                            Console.WriteLine("GetAll");
                            break;
                            
                            case 5:
                            Console.WriteLine("Delete");
                            break;

                            default:
                            Helper.MessageColor(ConsoleColor.Red, "Please enter correct number.");
                            goto Input;
                    }
                }
                else 
                {
                    Helper.MessageColor(ConsoleColor.Red, "Please enter correct type.");
                    goto Input;
                }
            }
        }
    }
}
