using System;

namespace FirstConsoleApp
{
    /*
    multi line comment
    */
    class Program
    {
        //This is a line comment, it will not be exucuted as code
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I love to code!");

            int userSelection;
            do
            {
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1: Code Joke.");
                Console.WriteLine("2: Count down.");
                Console.WriteLine("3: Ask Bartender for drink.");
                Console.WriteLine("9: Quit.");

                userSelection = GetNumberFromUser("manu selection");

                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("Why dose java programers have glasses?\nThy dont see sharp(C#)");
                        break;
                    case 2:
                        Console.WriteLine("Not implemented yet :(");
                        break;
                    case 3:
                        Bartender();
                        break;

                    case 9:
                        Console.WriteLine("Thanks for using this program.");
                        Console.WriteLine("Press any key to close program.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Not a valid selection.");
                        break;
                }

            } while (userSelection != 9);


        }//end of Main

        static void Bartender()
        {
            //Console.WriteLine("What is you age?");
            //int userAgeNumber = GetNumberFromUser();
            int userAgeNumber = GetNumberFromUser("age");

            if (userAgeNumber > 17)
            {
                Console.WriteLine("Here you go, a nice cold beer!");
            }
            else
            {
                Console.WriteLine("Complementory Soda for you.");
            }
        }

        static int GetNumberFromUser()
        {
            string userInput = Console.ReadLine();

            int number = 0;
            int.TryParse(userInput, out number);

            return number;
        }

        static int GetNumberFromUser(string forWhat)
        {
            Console.Write("Enter " + forWhat + " number: ");
            string userInput = Console.ReadLine();

            int number = 0;
            int.TryParse(userInput, out number);

            return number;
        }
    }
}
