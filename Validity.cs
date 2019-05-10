using System.Text.RegularExpressions;
class Validity{
    private string str; //todo remove withespace
    public Validity(string str){
        this.str = str;
    }

    public bool isValid(){
        if(charactersAreValid() & parathesesAreValid())// && parathesesIsValid() &&‌ operationsIsValid() && floatingPointIsValid()){
            return true;
        else
            return false;
    }

    public bool charactersAreValid(){
        return Regex.Match(str,"^[*-+/().]*$").Success;
    }

    public bool parathesesAreValid(){
        int count = 0;
        foreach(char c in str){
            if(c == '(')
                count ++;
            else if(c == ')')
                count --;
            if(count == 0)
                return true;
            return false;
        }
        return true;
    }

    
}