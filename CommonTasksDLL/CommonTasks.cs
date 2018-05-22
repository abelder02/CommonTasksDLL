using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTasksDLL
{
    public class CT
    {
        public static string date = Convert.ToString(DateTime.Now);

        public static int LengthOfTopLine;

        public static string Title;

        public static string Purpose;

        public static string Author = "Andrew Belder";

        public static void Header(string title, string purpose)
        {
            Color("green");
            int h = 150; 
            bool check = true;
            while (check)
            {
                try
                {
                    Console.SetWindowSize(100, h);
                    check = false;
                }
                catch (ArgumentOutOfRangeException)
                {
                    h -= 10;
                    check = true;
                }
            }
            h = (int)(h * 0.75);
            
            string topLine = "Author: " + Author + "            "
            + "Title: " + title + "            Date: " + date;
            int LengthOfInput = topLine.Length;
            LengthOfTopLine = LengthOfInput; int w = LengthOfTopLine + 5;
            Console.SetWindowSize(w, h);
            Console.Write(topLine);
            Console.WriteLine("\n\nPurpose: {0}", purpose);
            Title = title; Purpose = purpose;
            CreateHFLine(LengthOfInput);
            Color("white");
         }

        public static void Header2()
        {
            Header(Title, Purpose);
        }
              
        public static void CreateHFLine(int x)
        {
            Console.WriteLine("");
            for (int i = 0; i < x; i++)
            {
                Color("white");
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }

        public static void CreateBorderLine(string x)
        {
            int y = x.Length;
            Console.WriteLine("");
            for (int i = 0; i < y; i++)
            {
                Color("white");
                Console.Write("*");
            }
            Console.WriteLine("\n");
        }

        public static void Footer()
        {
            Console.ForegroundColor = ConsoleColor.White;
            CreateHFLine(LengthOfTopLine); 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please press <ENTER> twice "
                + "to exit program...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nGoodbye!");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Read();
        }

        public static void AnyKeyToContinue()
        {
            Console.Write("Please Hit Any Key to Continue...\t");
            Console.ReadKey();
            Console.WriteLine("");
        }

        public static int AskUserForInt(string x)
        {
            Color("");
            Console.Write("\nPlease enter {0} ", x);
            Color("Green");
            var input = Console.ReadLine();
            for (int i = 0; i < 1; i++)
            {

                try
                {
                    int.Parse(input);
                }
                catch (FormatException)
                {
                    Color("red");
                    Console.WriteLine("\nYOU GOOBER ---> FOLLOW DIRECTIONS");
                    Color("white");
                    Console.Write("\nPlease enter {0} ", x);
                    Color("green");
                    input = Console.ReadLine();
                    i--;
                }
            }
            Color("white");
            int convertInput = Convert.ToInt32(input);
            return convertInput;
        }

        public static string AskUserForString(string x)
        {
            Color("");
            Console.Write("\nPlease enter {0} ", x);
            Color("Green");
            string input = Console.ReadLine();
            Color("white");
            return input;
        }

        public static double AskUserForDouble(string x)
        {
            Color("");
            Console.Write("\nPlease enter {0} ", x);
            Color("Green");
            string input = Console.ReadLine();
            for (int i = 0; i < 1; i++)
            {

                try
                {
                    double.Parse(input);
                }
                catch (FormatException)
                {
                    Color("red");
                    Console.WriteLine("\nYOU GOOBER ---> FOLLOW DIRECTIONS");
                    Color("white");
                    Console.Write("\nPlease enter {0} ", x);
                    Color("Green");
                    input = Console.ReadLine();
                    i--;
                }
            }
            Color("white");
            double convertInput = Convert.ToDouble(input);
            return convertInput;    
            
        }

        public static void Color(string x)
        {
            string y = x.ToLower().Trim().Replace(" ","");
            switch (y)
            {
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "b":
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "darkblue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "darkcyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "darkgrey":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "darkgreen":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "darkmagenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkred":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "darkyellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "m":
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "w":
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
            }
        }

        public static string capitalizeMethod(string x)
        {
            return x.First().ToString().ToUpper() + x.Substring(1);
        }       

    }


}
