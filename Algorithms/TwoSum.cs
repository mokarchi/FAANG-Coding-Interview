public class Solution {
    // Time Complexity: O(n^2), Space complexity: O(1)
    public int[] TwoSum(int[] nums, int target) {
        int numberToFind = 0;
        for (int p1 = 0; p1 < nums.Length; p1++)
        {
            numberToFind = target - nums[p1];
            for (int p2 = p1+1; p2 < nums.Length; p2++)
            {
                if(numberToFind == nums[p2])
                {
                    return new int[]{p1,p2};
                }
            }
        }
        return new int[]{};
    }
    
    // Time Complexity: O(n), Space complexity: O(n)
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numsMap = new Dictionary<int, int>();
        for (int p = 0; p < nums.Length; p++)
        {
            if (numsMap.TryGetValue(target - nums[p], out int index))
            {
                return new[] { index, p };
            }
            
            numsMap[nums[p]] = p;
        }
        return new int[] { };
    }
}
