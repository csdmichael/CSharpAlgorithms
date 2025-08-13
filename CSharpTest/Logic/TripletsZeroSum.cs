public class TripletsWithZeroSum {
    public void FindTripletsZeroSum(int[] arr) {
        if (arr == null) {
            Console.WriteLine("Not found");
            return;
        } else if (arr.Length < 3) {
            Console.WriteLine("Not found");
            return;
        } else {
            Dictionary<int, int> s = new Dictionary<int, int>();
            /*
            foreach (int x in arr) {
                s.Add(x, x);
            }
            */
            bool tripletFound = false;
            for (int i = 0; i < arr.Length - 1; i++) {
                for (int j = i + 1; j < arr.Length; j++) {
                    int diff = -(arr[i] + arr[j]);
                    if (s.ContainsKey(diff)) {
                        Console.WriteLine("Triplet: " + arr[i] + ", " + arr[j] + ", " + s[diff]);
                        tripletFound = true;
                    }
                    else {
                        if (!s.ContainsKey(arr[j])) {
                            s.Add(arr[j], arr[j]);
                        }
                    }
                }
            }
            if (!tripletFound) {
                Console.WriteLine("Not found");
            }
        }
    }
}