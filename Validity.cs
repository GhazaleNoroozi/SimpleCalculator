using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;
class Validity{
    private string str;
    public Validity(string str){
        this.str = str;
    }

    public bool isValid(){
        if(charactersAreValid() & parathesesAreValid() & operationsAreValid())
            return true;
        else
            return false;
    }

    private bool charactersAreValid(){
        return Regex.Match(str,@"^[\-*+/().0123456789]*$").Success;
    }

    private bool parathesesAreValid(){
        Stack<char> brackets = new Stack<char>();
        try{
            foreach (char c in str){
                if (c == '(')
                    brackets.Push(c);
                else if (c == ')')
                        brackets.Pop();
                else
                    continue;
            }
        }catch{
            return false;
        }
        return brackets.Count == 0 ? true : false;
    }

    private bool operationsAreValid(){
        try{
            for(int i = 0; i < str.Length; i ++){
                if(str[i] == '*' | str[i] == '/' | str[i] == '+' | str[i] == '-'){
                    if(isNumber(str[i - 1]) & isNumber(str[i + 1]))
                        return true;
                    if(isNumber(str[i - 1]) & str[i+1] == '(')
                        return true;
                    if(str[i - 1] == ')' & isNumber(str[i + 1]))
                        return true;
                    if(str[i] == '+' | str[i] == '-')
                        if(str[i - 1] == '(' & isNumber(str[i + 1]))
                            return true;
                    return false;
                }
            }
        }catch{
            return false;
        }
        return true;
    }

    private bool isNumber(char c){
        if(c == '0' | c == '1' | c == '2' | c == '3' | c == '4' | c == '5' | c == '6' | c == '7' | c == '8' | c == '9')
            return true;
        return false;
    }
}