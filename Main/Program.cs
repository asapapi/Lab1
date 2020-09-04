using System;

namespace Main
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.ReadInteger();
            
            program.ReadString();
            
            program.ReadChoice();
            


        }

        public int ReadInteger()
        {
            int min = 1;
            int max = 10;
          
            Console.WriteLine("Please enter a valid Number between 1 - 10"); // ask question
            string validInput = Console.ReadLine(); // store user input into validInput;
            int Number;// create variable to store converted userInput into variable
            while (!int.TryParse(validInput, out Number))
            {
                if (Number >= min && Number <= max)
                {
                    Console.WriteLine("Your number is valid :" + Number);
                }
                Console.WriteLine("I said type a number!!");
                validInput = Console.ReadLine();
            }

            return Number;
        }

        public void ReadString()
        {
            Console.WriteLine("Please enter a word");
            string userInput = Console.ReadLine();
            ref string str = ref userInput;
            while (userInput != str)
            {
                Console.WriteLine("Please enter a number");
            }
            
        }

        public void ReadChoice()
        {
            string[] arr = new string[3];
            arr[0] = "1. Add Car";
            arr[1] = "2. Show Car";
            arr[2] = "3. Exit";
            Console.WriteLine("Select an option");
            for (int i = 0; i < arr.Length; i++)
            {
               Console.WriteLine( arr[i] + " "); 
               
            }

            Console.WriteLine("Please enter an option" + ReadInteger());
        }
    }
}