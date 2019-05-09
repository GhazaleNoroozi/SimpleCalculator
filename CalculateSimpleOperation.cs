Class CalculateSimpleOperation{
    privat double first;
    privat char operation;
    privat double second;

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
                try{
                    return first / second;
                }catch(Exception e){
                    return null;//todo Nullable
                }
        }   
    }
}