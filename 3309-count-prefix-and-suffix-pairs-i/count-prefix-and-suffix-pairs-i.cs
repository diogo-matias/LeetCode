public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int count = 0;

        for(var i = 0; i < words.Length; i++){
            for(var j = i + 1; j < words.Length; j++){
                if (isPrefixAndSuffix(words[i], words[j])){
                    count ++;
                }
            }
        }

        return count;
    }
    bool isPrefixAndSuffix(string str1, string str2){
        if (str1.Length > str2.Length){
            return false;
        }

        var prefix = str2.Substring(0, str1.Length);
        var sufix = str2.Substring(str2.Length - str1.Length, str1.Length);

        if (str1 == prefix && str1 == sufix){
            return true;
        }

        return false;
    }
}