public class Solution {
    public int[] TwoSum(int[] nums, int target) {
 Dictionary<int,int> mappedDict = new  Dictionary<int,int>();

 for ( int i =0; i < nums.Length; i ++)
 {
    var diff = target - nums[i];
    if(mappedDict.ContainsKey(diff))
    {
        return new int[] {mappedDict[diff], i};

    }
    mappedDict[nums[i]] = i;
 }
 return null;
}
}
