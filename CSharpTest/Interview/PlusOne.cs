public class PlusOne {
    public int[] AddOne(int[] digits) {
        int reminder = 0;
        Stack<int> stk = new Stack<int>();
        for (int i = digits.Length - 1; i >= 0; i--) {
            int curr = digits[i];
            int sum = 0;
            if (i == digits.Length - 1) {
                sum = curr + 1;
            } else {
                sum = curr + reminder;
            }
            if (sum > 9) {
                sum -= 10;
                reminder = 1;
            } else {
                reminder = 0;
            }
            stk.Push(sum);
        }
        if (reminder > 0) {
            stk.Push(1);
        }

        int[] res = new int[stk.Count];
        int index = 0;
        while (stk.Count > 0) {
            int curr = stk.Pop();
            res[index] = curr;
            index++;
        }
        return res;
    }
} 

/*
1,2,3
     <---

reminder = 0
Stk
1
2
4
*/

/*
You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

 

Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
Example 2:

Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].
Example 3:

Input: digits = [9]
Output: [1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].
 

Constraints:

1 <= digits.length <= 100
0 <= digits[i] <= 9
digits does not contain any leading 0's.
*/