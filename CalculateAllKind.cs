using System;
class CalculateAllKind{
    CalculateComplicatedOperation comp;
    public CalculateAllKind(){
        comp = new CalculateComplicatedOperation();
    }

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
                    // if(str.Substring(beg + 1, end - beg - 1)) todo
                    if(d >= 0)
                        str = str.Substring(0, beg) + d + str.Substring(end + 1, str.Length - end - 1);
                    else
                        str = str.Substring(0, beg) + "(" + d + ")" + str.Substring(end + 1, str.Length - end - 1);
                    break;
                }
            }  
        }
        return comp.calculate(str);
    }
}