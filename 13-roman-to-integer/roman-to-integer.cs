

public class Solution {
  

    public int RomanToInt(string s) {
    var romanValues = new Dictionary<char, int>
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    int result = 0; 
    for (int i = 0; i < s.Length; i++)
    {
        int currentValue = romanValues[s[i]];
        int nextValue = 0;
        if (i + 1 < s.Length){
            nextValue= romanValues[s[i + 1]];
        }

        
        result += currentValue < nextValue ? - currentValue : + currentValue;

    }

     return result;
    }
}