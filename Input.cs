class Input{
    private static String str {get; set;}
    public static bool getInput(){
        str = Console.ReadLine();
        Handle.handle(str);
    }
}