public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int count = 0;

        foreach (var word in words) {
            if (startsWith(word, pref)) {
                count++;
            }
        }

        return count;
    }

    public bool startsWith(string word, string pref){
        if (pref == null) { 
            return false;
        }

        if (pref.Length > word.Length) {
            return false;
        }

        for(var i = 0; i < pref.Length; i++){
            if (word[i] != pref[i]) return false;
        }

        return true;
    }
}