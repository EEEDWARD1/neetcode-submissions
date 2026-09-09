public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seenNumbers = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int complement = target - nums[i];

            if(seenNumbers.TryGetValue(complement, out int complementIndex)) {
                return new int[] {complementIndex, i};
            }
            seenNumbers[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}
