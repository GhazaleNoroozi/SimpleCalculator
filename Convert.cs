using System;
public static class Convert{
    public static double stringToDouble (string str){
        if(str[0] == '(' & str[str.Length - 1] == ')')
            return Double.Parse(str.Substring(1,str.Length - 2));
        return Double.Parse(str);
    }
}