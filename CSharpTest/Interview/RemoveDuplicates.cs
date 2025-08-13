public class RemoveDuplicates{
    public int RemoveAllDuplicates(int[] nums) {
        SortedDictionary<int,int> d = new SortedDictionary<int,int>();
        for (int i = 0; i < nums.Length; i++) {
            int curr = nums[i];
            if (d.ContainsKey(curr)) {
                d[curr]++;
            }
            else {
                d.Add(curr, 1);
            }
        }
        for (int i = 0; i < d.Count; i++) {
            nums[i] = d.Keys.ElementAt(i);
        }
        return d.Count;
    }
}