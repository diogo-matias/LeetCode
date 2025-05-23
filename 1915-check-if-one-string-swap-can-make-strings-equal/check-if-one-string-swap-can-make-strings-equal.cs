public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if (s1.Length != s2.Length){
            return false;
        }

        for(var i = 0; i < s1.Length; i++){
            var ss1 = s1[i];

            for (var k = i; k < s1.Length; k++){
                var ss2 = s1[k];
                var a = s1.ToArray();

                a[k] = ss1;
                a[i] = ss2;

                string result = String.Join("", a);

                if (result == s2){
                    return true;
                }
            }
        }

        return false;
    }
}