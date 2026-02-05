
public class HashMap {
    public int[] TwoSum(int[] nums, int target) {
        var hash = new Dictionary<int, int>()
        {};
        for(int i = 0; i < nums.Length; i++)
        {

            int y = target - nums[i];

            if(hash.ContainsKey(y))
            {
                return new int[]{hash[y], i};
            }
            hash[nums[i]] = i;
        }

        return new int[]{};
    }
}