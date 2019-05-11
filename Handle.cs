using System; 
class Handle{
    public static bool handle(String str){
        Validity v = new Validity(str);
        if(!v.isValid())
            return false;
        try{
            CalculateAllKind cal = new CalculateAllKind();
            Console.WriteLine(cal.Calculate(str));
        }catch{
            return false;
        }
        return true;

    }
}