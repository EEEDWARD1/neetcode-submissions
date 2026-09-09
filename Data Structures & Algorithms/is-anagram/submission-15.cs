public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] alphabet = new int[26];
        foreach (char c in s){
            alphabet[c - 'a'] += 1;
        }

        foreach (char c in t){
            alphabet[c - 'a'] -= 1;
        }

        foreach (int x in alphabet){
            if (x != 0){
                return false;
            }
        }
        return true;
    }
}
