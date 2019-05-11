using System; 
class Handle{
    public static bool handle(String str){
        Validity v = new Validity(str);
        string s;
        if(!v.isValid(out s)){
            return false;
        }
        str = s;
        //Console.WriteLine(str);
        try{
            CalculateAllKind cal = new CalculateAllKind();
            Console.WriteLine(cal.Calculate(str));
        }catch(Exception e){
            Console.WriteLine(e);
            return false;
        }
        return true;

    }
}