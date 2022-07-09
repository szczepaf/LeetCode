namespace Namespace
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int > seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.ContainsKey(target - nums[i])) return new int[] { seen[target - nums[i]], i };
                else seen[nums[i]] = i;

               
            }
            return null;

        }
        
    }

}
