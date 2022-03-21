public class Solution {
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
}
