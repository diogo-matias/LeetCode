public class Solution {
    public bool IsValid(string s) {
        
        var stack = new List<char>();
        
        for (var i = 0; i < s.Length; i++){
            char current = s[i];

            if ( stack.Count > 0 && isMatch(stack[stack.Count -1], current)){
                stack.RemoveAt(stack.Count -1);
            } else {
                stack.Add(current);
            }
        }

        return stack.Count == 0;
    }
    
    public bool isMatch(char open, char close){
        return 
        (open == '(' && close ==')') || 
        (open == '{' && close =='}') || 
        (open == '[' && close ==']');

        return false;
    }
}