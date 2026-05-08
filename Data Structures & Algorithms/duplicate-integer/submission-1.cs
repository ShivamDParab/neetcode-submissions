public class Solution {
    public bool hasDuplicate(int[] nums) {
        // List<int> exists = new List<int>();
        // foreach (int a in nums) {
        //     if (exists.Contains(a)) {
        //         return true;
        //     }
        //     exists.Add(a);
        // }
        // return false;

        return new HashSet<int>(nums).Count < nums.Length;
    }
}