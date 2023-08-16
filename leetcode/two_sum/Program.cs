public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        // Dictionary<int, int> dict = new Dictionary<int, int>();

        int[] arr = new int[2];



        for (int i = 0; i < nums.Length; i++)
        {

            for (int j = i + 1; j < nums.Length; j++)
            {
                int sum = 0;
                sum = nums[i] + nums[j];
                if (sum == target)
                {
                    arr[0] = i;
                    arr[1] = j;
                    break;
                }
            }
        }

        return arr;

    }
}
