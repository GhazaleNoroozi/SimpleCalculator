using System;
class Main{
    public static char c;
    public static bool isContinued;
    static void main(string[] args){
        Console.WriteLine("Welcome!\nOperations you can use: * / - + ()");
        while(isContinued){
            Console.WriteLine("Wanna continue ? [y/n]");
            c = Console.ReadKey().KeyChar;
            isContinued = (c == 'y') ? true : false; 
        }
    }
}