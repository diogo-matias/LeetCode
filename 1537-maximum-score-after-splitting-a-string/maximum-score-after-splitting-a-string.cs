public class Solution {
    public int MaxScore(string s) {
        int sum = 0;

        for(var i = 1; i < s.Length; i++){
            int zerosCount = 0;
            int onesCount = 0;
            int currentSum = 0;

            for(var k = 0; k < s.Length; k++){
                if (k < i){
                    if (s[k] == '0'){
                        zerosCount++;
                    } 
                } else {
                    if (s[k] == '1'){
                        onesCount++;
                    }
                }
            }

            currentSum = zerosCount + onesCount;
            if (currentSum > sum){
                sum = currentSum;
            }
        }
    
        return sum;
    }
}