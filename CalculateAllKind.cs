using System;
public class CalculateAllKind{
    string str;
    CalculateComplicatedOperation comp;
    public CalculateAllKind(){
        this.str = "";
        comp = new CalculateComplicatedOperation();
    }

    //supposed parathesis are valid.
    public double Calculate(string str){
        int beg = -1;
        int end = str.Length;
        double d;
        while(str.IndexOf("(") != -1){
            beg = str.LastIndexOf("(");
            for(int i = beg; i < str.Length; i++){
                if(str[i] == ')'){
                    end = i;
                    d = comp.calculate(str.Substring(beg + 1, end - beg - 1));
                    if(d >= 0)
                        str = str.Substring(0, beg) + d + str.Substring(end + 1, str.Length - end - 1);
                    else
                        str = str.Substring(0, beg) + "(" + d + ")" + str.Substring(end + 1, str.Length - end - 1);
                    Console.WriteLine("hii:" + str);
                    break;
                }
            }  
        }
        return comp.calculate(str);
    }
}