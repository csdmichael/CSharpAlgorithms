using System.Collections.Generic;
using System.Linq;

public class KthLargest {
    SortedDictionary<int,int> d;
    public int kVal;
    public int count;
    public KthLargest(int k, int[] nums) {
        this.kVal = k;
        d = new SortedDictionary<int,int>();
        for (int i = 0; i < nums.Length; i++) {
            int curr = nums[i];
            Add(curr);
        }
    }
    
    public int Add(int val) {
        count++;
        if (d.ContainsKey(val)) {
            d[val]++;
        }
        else {
            d.Add(val, 1);
        }

        if (count < kVal) {
            return -1;
        }
        else {
            int pos = 0, index = 0;
            while(index < d.Count) {
                pos += d.Values.ElementAt(d.Count - index - 1);
                if (pos < kVal) {
                    index++; 
                }
                else {
                    break;
                }
                
            }
            return d.Keys.ElementAt(d.Count - index - 1);
        }
    }

}