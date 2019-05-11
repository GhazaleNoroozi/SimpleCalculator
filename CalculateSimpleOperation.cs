using System;
using System.Globalization;
public class CalculateSimpleOperation {
    double first;
    char operation;
    double second;

    public CalculateSimpleOperation(){
        second = 1;
        first = 1;
        operation = '+';
    }

    public double calculate(string str){
        initial(str);
        switch(operation){
            case '*':
                return first * second;
            case '+':
                return first + second;
            case '-':
                return first - second;
            case '/':
                return first / second;
                // try{
                //     return first / second;
                // }catch(System.Exception e){
                //     return null;//todo Nullable
                // }
            default:
                return 0;//todo
        }   
    }

    public void initial(string str){
        int index = str.IndexOf("*");
        if(index == -1)
            index = str.IndexOf("/");
        if(index == -1)
            index = str.IndexOf("-");
        if(index == -1)
            index = str.IndexOf("+");
        this.first = Double.Parse(str.Substring(0,index));
        this.second = Double.Parse(str.Substring(index + 1, str.Length - index - 1));
        this.operation = str[index];
    }
}