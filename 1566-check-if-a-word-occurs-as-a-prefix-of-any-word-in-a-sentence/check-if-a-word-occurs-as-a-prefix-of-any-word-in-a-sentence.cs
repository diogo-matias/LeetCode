public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        string[] words = sentence.Split(' ');
        int result = -1;

        for(int index = 0; index < words.Length; index++){
            bool contain = true;

            for(int i = 0; i < searchWord.Length; i++){
                if (words[index].Length < searchWord.Length){
                    contain = false;
                    break;
                }
                char wordLetter = words[index][i];
                char searchLetter =  searchWord[i];

                if (wordLetter != searchLetter){
                    contain = false;
                    break;
                }
            }

            if (contain){
                return index + 1;
            }
        }

        return result;
    }
}