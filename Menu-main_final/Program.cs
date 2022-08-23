using System;
using System.Threading;
using System.Timers;


namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Shape Calculator";
            mainMenu();
        }

        static double Hentvalue()
            {
            double value = 0; string temp = "", retry = "No";
            do
            {
                if (retry == "Yes")
                        Console.Write("\n\t Please only input numbers, try again - Bitch! ");
                retry = "No";
                temp = Console.ReadLine();

                if (temp == "")
                    temp = " ";

                foreach (char tegn in temp)
                {
                    if (!"0123456789,".Contains(tegn))
                        retry = "Yes";
                }
            } while (retry == "Yes");

            value = Convert.ToDouble(temp); return value;
            }

        static void mainMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("    Welcome to the Shape Calculator");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("\tIndex");
            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("   -   Circle    (C)     |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   -   Triangle  (T)     |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   -   Square    (S)     |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   -   Rectangle (R)     |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                         |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   -   Shortcuts:        |");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("   -   Quit =    (Q)     |");
            Console.WriteLine("   -   Menu =    (M)     |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Enter the desired calculation: ");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {

                case "c":
                    calcCircle();
                    Console.WriteLine("Press 'M' to return to return to main manu. ");
                    Console.WriteLine("Press 'Q' to return to return to main manu. ");
                    string userInputCircle = Console.ReadLine();
                    if (userInputCircle == "m")
                    {
                        mainMenu();
                    }
                    if (userInputCircle == "q")
                    {
                        Console.WriteLine("Terminating the application...");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    } 
                    else if (userInputCircle != "m")
                    {
                        Console.WriteLine("Try again");
                    }
                    else if (userInputCircle != "q")
                    {
                        Console.WriteLine("Try again");
                    }
                    break;

                case "t":
                    calcTriangle();
                    Console.WriteLine("Press 'M' to return to return to main manu. ");
                    Console.WriteLine("Press 'Q' to return to return to main manu. ");
                    string userInputTriangle = Console.ReadLine();
                    if (userInputTriangle == "m")
                    {
                        mainMenu();
                    }
                    if (userInputTriangle == "q")
                    {
                        Console.WriteLine("Terminating the application...");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (userInputTriangle != "m")
                    {
                        Console.WriteLine("Try again");
                    }
                    else if (userInputTriangle != "q")
                    {
                        Console.WriteLine("Try again");
                    }
                    break;

                case "s":
                    calcSquare();
                    Console.WriteLine("Press 'M' to return to return to main manu. ");
                    Console.WriteLine("Press 'Q' to return to return to main manu. ");
                    string userInputSquare = Console.ReadLine();
                    if (userInputSquare == "m")
                    {
                        mainMenu();
                    }
                    if (userInputSquare == "q")
                    {
                        Console.WriteLine("Terminating the application...");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (userInputSquare != "m")
                    {
                        Console.WriteLine("Try again");
                    }
                    else if (userInputSquare != "q")
                    {
                        Console.WriteLine("Try again");
                    }
                    break;

                case "r":
                    calcRect();
                    Console.WriteLine("Press 'M' to return to return to main manu. ");
                    Console.WriteLine("Press 'Q' to return to return to main manu. ");
                    string userInputRect = Console.ReadLine();
                    if (userInputRect == "m")
                    {
                        mainMenu();
                    }
                    if (userInputRect == "q")
                    {
                        Console.WriteLine("Terminating the application...");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else if (userInputRect != "m")
                    {
                        Console.WriteLine("Try again");
                    }
                    else if (userInputRect != "q")
                    {
                        Console.WriteLine("Try again");
                    }
                    break;

                    
                case "q":
                    Console.WriteLine("Terminating the application...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;
                case "m":                    
                    Console.WriteLine("Main Menu placeholder");
                    mainMenu();
                    break;
                    
                default:
                    Console.WriteLine("Incorrect command. Please try again.");
                    Thread.Sleep(3000);
                    mainMenu();
                    break;
            }
        }

        static void calcCircle()
        {

            Console.Write("Please enter the radius of the circle (cm) : ");
            double radius = Hentvalue();

            double pi = 3.141;
            double circleCircumference = 2 * (pi * radius);
            double circleArea = (2 * pi) * (2 * radius);

            Console.WriteLine("The circumference is: {0} (cm)", circleCircumference);
            Console.WriteLine("The area is: {0:N2} (cm2)", circleArea);
            Console.WriteLine("Circumference calculation: 2 * ({0} * {1})", pi, radius);
            Console.WriteLine("Area calculation: (2 * {0}) * (2 * {1})", pi, radius);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ******  ");
            Console.WriteLine("****  ****");
            Console.WriteLine("**      **");
            Console.WriteLine("****  ****");
            Console.WriteLine("  ******  ");
            Console.ForegroundColor = ConsoleColor.White;


        }

        static void calcTriangle ()
        {

            Console.WriteLine("Please enter the length first side of the triangle (cm) :");
            double a = Hentvalue();
            Console.WriteLine("Please enter the length second side of the triangle (cm) :");
            double b = Hentvalue();
            Console.WriteLine("Please enter the length third side of the triangle (cm)");
            double c = Hentvalue();

            double triangleCircumference = a + b + c;
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("The circumference is: {0} (cm)", triangleCircumference);
            Console.WriteLine("The area is: {0:N2} (cm2)", area);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("   ©   ");
            Console.WriteLine("  © ©  ");
            Console.WriteLine(" ©   © ");
            Console.WriteLine("© © © ©");
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void calcSquare ()
        {

            Console.WriteLine("Please enter the length of one side of the square (cm) :");
            double a = Hentvalue();

            double squareCircumference = 4 * a;
            double squareArea = 2 * a;

            Console.WriteLine("The circumference is: {0} (cm)", squareCircumference);
            Console.WriteLine("The area is: {0:N2} (cm2)", squareArea);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════╗");
            Console.WriteLine("║         ║");
            Console.WriteLine("║         ║ {0}", a);
            Console.WriteLine("║         ║");
            Console.WriteLine("╚═════════╝");
            Console.WriteLine("    {0}    ", a);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void calcRect()
        {

            Console.WriteLine("Please enter the length of the rectangle (cm) :");
            double a = Hentvalue();
            Console.WriteLine("Please enter the breadth (cm) :");
            double b = Hentvalue();

            double rectCircumference = (a * 2) + (b * 2);
            double rectArea = a * b;

            Console.WriteLine("The circumference is: {0} (cm)", rectCircumference);
            Console.WriteLine("The area is: {0:N2} (cm2)", rectArea);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═════════════╗");
            Console.WriteLine("║             ║");
            Console.WriteLine("║             ║");
            Console.WriteLine("║             ║");
            Console.WriteLine("╚═════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
