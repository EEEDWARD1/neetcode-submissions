public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (map.TryGetValue(complement, out int complementIndex)) {
                return new int[] { complementIndex, i };
            }

            // Store the current number and its index
            map[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}