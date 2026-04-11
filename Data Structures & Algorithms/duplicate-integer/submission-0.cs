public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> a = new HashSet<int>();
        foreach(var n in nums)
        {
            if(!a.Add(n))
            {
                return true;
            }
        }
            return false;
    }
}