public class DistintNumOfOccurrences {
    public bool UniqueOccurrences(int[] arr) {
        if (arr.Length == 1) return true;

        Dictionary<int,int> d = new Dictionary<int,int>();

        for (int i = 0; i < arr.Length; i++) {
            int curr = arr[i];
            if (d.ContainsKey(curr)) {
                d[curr]++;
            }
            else {
                d.Add(curr, 1);
            }
        }

        Dictionary<int,int> u = new Dictionary<int,int>();
        
        foreach(KeyValuePair<int,int> kvp in d) {
            if (u.ContainsKey(kvp.Value)) {
                return false;
            }
            else {
                u.Add(kvp.Value, kvp.Value);
            }
        }

        return true;
    }
}

/*
Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.

 

Example 1:

Input: arr = [1,2,2,1,1,3]
Output: true
Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
Example 2:

Input: arr = [1,2]
Output: false
Example 3:

Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
Output: true
 

Constraints:

1 <= arr.length <= 1000
-1000 <= arr[i] <= 1000
*/