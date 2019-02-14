
using System;
using System.Collections.Generic;

namespace PrudoctMenu
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            List<lemonprice> product = new List<lemonprice>();

        

            bool keepAlive = true;

            while (keepAlive)
            {
                Console.WriteLine(
                    "--- Menu ---\n" +
                    "1: Lemmon\n" +
                    "2: Candy\n" +
                    "3: Chips\n" +
                    "0: Exit program"
                    );
                int selection = AskUserForNumberX("Select");

                switch (selection)
                {
                    case 1:
                        lemonprice();
                        break;
                    case 2:
                     
                        break;
                    
                   
                    case 0:
                        keepAlive = false;
                    
                        break;
                    default:
                        Console.WriteLine("Not a valid selection.");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static void lemonprice()
        {
            throw new NotImplementedException();
        }

        static lemonprice Product()
        {
            string Produkt = AskUserForX("Choice Product");
          

            return Product();
        }// CreatePerson ends

        static string AskUserForX(string x)
        {
            string input = "";

            while (input.Length == 0)
            {
                Console.Write("Pleace input " + x + ": ");
                input = Console.ReadLine();
            }

            return input;
        }

        static int AskUserForNumberX(string x)
        {
            int number = 0;
            bool noNumber = true;

            while (noNumber)
            {
                try
                {
                    number = Convert.ToInt32(AskUserForX(x));
                    noNumber = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number, Pleace try once more.");
                }
            }

            return number;
        }
    }



        public lemon()
        {
            int price =10;
            int antal;
            int summa ;

            Console.Write("How many do you want?");
            antal = Console.Read();
            summa = (price * antal);
           
        return summa;
        }

    void lemonprice()
    {
        throw new NotImplementedException();
    }
}
