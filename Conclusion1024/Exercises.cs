namespace Conclusion1024;

public static class Exercises
{
    /// <summary>
    /// Given a sorted array of distinct integers and a target value, return the index if
    /// the target is found. If not, return the index where it would be if it were
    /// inserted in order.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// </summary>
    public static int SearchInsert(int[] nums, int target)
    {
        return SearchInsert(nums, target, 0, nums.Length - 1);
    }
    public static int SearchInsert(int[] nums, int target, int low, int up)
    {
        if (low == up)
            return low;
        
        var mid = (low + up) / 2;
        if (nums[mid] == target)
            return mid;
        
        return target < nums[mid] 
            ? SearchInsert(nums, target, low, mid - 1) 
            : SearchInsert(nums, target, mid + 1, up);
    }
    
    public static int RomanToInt(string s)
    {
        var romanNumbers = new Dictionary<char, int>()
        {
            { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },
            { 'C', 100 }, {'D', 500}, {'M', 1000}
        };

        int decimalNumber = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            var currentNumber = romanNumbers[s[i]];
            var nextNumber = romanNumbers[s[i + 1]];
            
            var value = currentNumber < nextNumber
                ? -currentNumber
                : currentNumber;

            decimalNumber += value;
        }
        
        decimalNumber += romanNumbers[s[^1]]; // last one
        return decimalNumber;
        
        
    }

    public static int[] Sort(int[] arr)
    {
        if (arr.Length <= 1)
            return arr;
        
        var left = Sort(arr[..(arr.Length / 2)]);
        var right = Sort(arr[(arr.Length / 2)..]);
        return Merge(left, right);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr1"></param>
    /// <param name="arr2"></param>
    /// <returns></returns>
    public static int[] Merge(int[] arr1, int[] arr2)
    {
        var result = new int[arr1.Length + arr2.Length];

        int i = 0; // use with arr1
        int j = 0; // use with arr2
        int k = 0; // use with result
        
        while (i < arr1.Length && j < arr2.Length)
            result[k++] = arr1[i] < arr2[j] 
                ? arr1[i++] 
                : arr2[j++];
        
        
        while (i < arr1.Length)
            result[k++] = arr1[i++];

        while (j < arr2.Length)
            result[k++] = arr2[j++];

        return result;
    }
}