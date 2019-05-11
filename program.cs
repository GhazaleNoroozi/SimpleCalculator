using System;
namespace Calculator {
    class Program{
        public static string c;
        public static bool isContinued = true;
        static void Main(string[] args){
            Console.WriteLine("Welcome!\nOperations you can use: * / - + ()");
            while(isContinued){
                Input.getInput();
                Console.WriteLine("Wanna continue ? [enter yes if you want to]");
                c = Console.ReadLine();
                isContinued = (c.ToLower() == "yes") ? true : false; 
            }
        }
    }
}