using System;
class CalculateSimpleOperation {
    public double first;
    public char operation;
    public double second;

    public CalculateSimpleOperation(double first, char operation, double second){
        this.first = first;
        this.second = second;
        this.operation = operation;
    }

    public double calculate(){
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
}