using System;
class Input{
    private static string str {get; set;}
    public static void getInput(){
        while(true){
            str = Console.ReadLine();
            if(!Handle.handle(str)){
                Console.WriteLine("Invalid input.Try again:");
                continue;
            }
            break;
        }
    }
}