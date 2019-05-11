using System;
class CalculateComplicatedOperation{
    public string str;
    public CalculateComplicatedOperation(){
        this.str = "";
    }
    
    //Real nice work down here ^^
    public double calculate(string str){
        int index1 = str.LastIndexOf('+');
        int index2 = str.LastIndexOf('-');
        if(index1 > index2)
            return calculate(str.Substring(0,index1)) + 
                calculate(str.Substring(index1 + 1, str.Length - index1 - 1));
        else if(index1 < index2)
            return calculate(str.Substring(0,index2)) - 
                calculate(str.Substring(index2 + 1, str.Length - index2 - 1));
        else{
            index1 = str.IndexOf('*');
            index2 = str.IndexOf('/');
            if(index1 > index2)
                return calculate(str.Substring(0,index1)) *
                    calculate(str.Substring(index1 + 1, str.Length - index1 - 1));
            else if(index1 < index2)
                return calculate(str.Substring(0,index2)) / 
                    calculate(str.Substring(index2 + 1, str.Length - index2 - 1));
            else
                return Convert.stringToDouble(str);
        }
    }
}