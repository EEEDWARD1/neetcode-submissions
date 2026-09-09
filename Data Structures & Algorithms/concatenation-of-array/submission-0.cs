public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = new int[nums.Length * 2];
        int spacer = nums.Length;

        for (int i = 0; i < nums.Length; i++){
            ans[i] = nums[i];
            ans[i+spacer] = nums[i];
        }
        
        return ans;
    }
}