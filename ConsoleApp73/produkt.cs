using System;
using System.Collections.Generic;
using System.Text;

namespace PrudoctMenu
{
    class lemonprice
    {
        static int countId = 0;

        public int Id { get; private set; }

        public string lemmon { get; set; }
        public string chocklad { get; set; }
        public string cips { get; set; }
        int price;
        public int Price {
            get { return Price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("You most press 1-4");
                }
                else
                {
            
                     
                }
            }
        }
        static int AskUserForsumma(int summan)
        {
            int price = 10;
            int antal;
            int summa;

            Console.Write("How many do you want?");
            antal = Console.Read();
            summa = price * antal;
            return summa;

        }

        public lemonprice() { }   

        public lemonprice(string drink, string choice)    // When we Overload a Constructor or Method, it the input types that are the key for the computer to see the diffrence between them(not the verible name).
        {
            Id = ++countId;
            lemmon = drink;
            this.lemmon = choice;
            return;
        }

        public lemonprice(int id) 
        {
           
            this.Id = Id;
        }

     

        override public string ToString()
        {
            return Id + ": ";
        }
    }
}