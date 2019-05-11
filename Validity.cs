using System.Text.RegularExpressions;
class Validity{
    private string str;
    public Validity(string str){
        this.str = str;
    }

    public bool isValid(){
        if(charactersAreValid() & parathesesAreValid())// operationsIsValid()
            return true;
        else
            return false;
    }

    public bool charactersAreValid(){
        return Regex.Match(str,"^[*-+/().0-9]*$").Success;
    }

    public bool parathesesAreValid(){//todo doesnot work ... should use stack
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

    public bool operationsAreValid(){//todo complete this
        return true;
    }
}