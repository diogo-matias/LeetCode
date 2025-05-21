public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int sum = 0;

        for(var i = 0; i < words.Length; i++){
            if (pref.Length > words[i].Length){
                continue;
            }

            var substring = words[i].Substring(0, pref.Length);
            sum = substring == pref ? sum + 1 : sum;

            Console.WriteLine(sum);
        }

        return sum;
    }
}