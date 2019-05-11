using System;
class CalculateComplicatedOperation{
    public string str;
    CalculateSimpleOperation simple;
    public CalculateComplicatedOperation(){
        this.str = "";
        simple = new CalculateSimpleOperation();
    }
    //suppose it is valid.
    //Real nice work down here ^^
    public double calculate(string str){
        Console.WriteLine(str);
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
                return Double.Parse(str);
        }
        // str = calculateMult(str);
        // Console.WriteLine("first one finished :" + str);
        // str = calculateSum(str);
        // return str;
    }
    // public string calculateMult(string str){
    //     int beg = 0;
    //     int end = str.Length-1;
    //     int index = 0;
    //     bool found = false;
    //     char o = '+';
    //     foreach (char i in str){
    //         if(!found &(i == '*' | i == '/')){
    //             found = true;
    //             o = (i=='*') ? '/' : '*';
    //         }
    //         if(i == '+' | i == '-' | i == o) 
    //             if(!found)
    //                 beg = index‌ + 1;
    //             else{
    //                 end = index - 1;
    //                 break;
    //             }

    //         index++;
    //     }
        
    //     Console.WriteLine("beg :" + beg + " end :" + end);
    //     Console.WriteLine("hey:" + str.Substring(beg,end-beg+1));
    //     double d = simple.calculate(str.Substring(beg,end-beg+1));
    //     Console.WriteLine(d);
    //     str = str.Substring(0, beg) + d + str.Substring(end + 1, str.Length-end-1);
    //     Console.WriteLine("how" + str);
    //     if(str.IndexOf('*') != -1 | str.IndexOf('/') != -1)
    //         str = calculateMult(str);
    //     return str;
    // }
    // public string calculateSum(string str){
    //     if(str.IndexOf('+') == -1 && str.IndexOf('-') == -1)
    //         return str;
    //     int beg = 0;
    //     int end = str.Length-1;
    //     int index = 0;
    //     bool found = false;
    //     foreach (char i in str){
    //         if(i == '+' | i == '-')
    //             if(!found)
    //                 found = true;
    //             else{
    //                 end = index - 1;
    //                 break;
    //             }
    //         index++;
    //     }
        
    //     Console.WriteLine("beg :" + beg + " end :" + end);
    //     Console.WriteLine("hey:" + str.Substring(beg,end-beg+1));
    //     double d = simple.calculate(str.Substring(beg,end-beg+1));
    //     Console.WriteLine(d);
    //     str = str.Substring(0, beg) + d + str.Substring(end + 1, str.Length-end-1);
    //     Console.WriteLine(str);
    //     calculateSum(str);
    //     return str;
    // }


}