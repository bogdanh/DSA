namespace DSA;
public partial class BinarySearch {
    public static int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length;
        
        while (l < r) {
            int m = l + (r - l) / 2;
            
            if (nums[m] < target) {
                l = m + 1;
            } else {
                r = m;
            }
        }
        
        return l;
    }
}
