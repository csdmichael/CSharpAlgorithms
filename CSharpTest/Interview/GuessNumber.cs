/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class GuessGame {
    public int GuessNumber(int n) {
        return GuessNumberHelper(1, n);
    }

    /*
    //Recursive
    public int GuessNumberHelper(int low, int high) {
        int mid = (low + high) / 2;
        int res = guess(mid);
        
        if (res == 0) return mid;
        else if (res == -1) return GuessNumberHelper(low, mid);
        else return GuessNumberHelper(mid, high);
    }
    */

    public int GuessNumberHelper(int low, int high) {
        int res = -1;
        int mid = 0;
        while (res != 0) {
            mid = (low + high) / 2;
            res = guess(mid);
            if (res == -1) {
                high = mid - 1;
            }
            else if (res == 1) {
                low = mid + 1;
            }
        }

        return mid;
    }

    private int guess(int x) {
        return -1;
    }
}

/*
We are playing the Guess Game. The game is as follows:

I pick a number from 1 to n. You have to guess which number I picked.

Every time you guess wrong, I will tell you whether the number I picked is higher or lower than your guess.

You call a pre-defined API int guess(int num), which returns three possible results:

-1: Your guess is higher than the number I picked (i.e. num > pick).
1: Your guess is lower than the number I picked (i.e. num < pick).
0: your guess is equal to the number I picked (i.e. num == pick).
Return the number that I picked.

 

Example 1:

Input: n = 10, pick = 6
Output: 6
Example 2:

Input: n = 1, pick = 1
Output: 1
Example 3:

Input: n = 2, pick = 1
Output: 1
 

Constraints:

1 <= n <= 231 - 1
1 <= pick <= n
*/

/*
n = 8
g=5

p=8
-1
p=4
1
p=6
-1
*/
