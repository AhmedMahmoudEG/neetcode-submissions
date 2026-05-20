public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i =0;i<nums.Length;i++){
            int need = target - nums[i];
            if(map.ContainsKey(need))  {
                return [map.GetValueOrDefault(need), i];
            }
            map.Add(nums[i],i);
        }
        return [];
    }
}
