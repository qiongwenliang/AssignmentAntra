using System;
namespace Assignment
{
	public class LeetcodeAssignment
	{
		public LeetcodeAssignment() {}

        //Two Sum
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }


        //Three Sum
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length - 1;
            List<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] > 0 || i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = n;

                while (left < right)
                {
                    if (nums[left] + nums[right] + nums[i] < 0)
                    {
                        left++;
                    }
                    else if (nums[left] + nums[right] + nums[i] > 0)
                    {
                        right--;
                    }
                    else if (nums[left] + nums[right] + nums[i] == 0)
                    {
                        int[] temp = { nums[i], nums[left], nums[right] };
                        result.Add(temp);
                        left++;
                        right--;
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                }
            }
            return result;
        }
    }
}

