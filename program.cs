using System;
namespace Calculator {
    class Program{
        // public static char c;
        // public static bool isContinued;
        static void Main(string[] args){
            // Console.WriteLine("Welcome!\nOperations you can use: * / - + ()");
            // while(isContinued){
            //     Console.WriteLine("Wanna continue ? [y/n]");
            //     c = Console.ReadKey().KeyChar;
            //     isContinued = (c == 'y') ? true : false; 
            
            // }
            CalculateAllKind c = new CalculateAllKind();
            Console.WriteLine(c.Calculate("((2))"));//todo bug
        }
    }
}