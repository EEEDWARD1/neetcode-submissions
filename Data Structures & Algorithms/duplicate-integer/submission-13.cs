public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 1 || nums == null){
            return false;
        }

        HashSet<int> duplicates = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++){
            if(duplicates.Contains(nums[i])){
                return true;
            } else {
                duplicates.Add(nums[i]);
            }
        }
        return false;
    }
}