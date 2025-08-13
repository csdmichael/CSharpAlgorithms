public class CanPlaceFlowers {
    public bool CanPutFlowers(int[] flowerbed, int n) {
        if (n == 0) return true;
        
        for (int i = 0; i < flowerbed.Length; i++) {
            bool isEmpty = IsEmpty(flowerbed, i);
            if (isEmpty) {
                flowerbed[i] = 1;
                n--;
            }
        }

        if (n > 0) return false;
        else return true;
    }

    private bool IsEmpty(int[] flowerbed, int index) {
        bool prev, curr, next;

        curr = (flowerbed[index] == 0)?true:false;
        if (index == 0) {
            prev = true;
        } 
        else {
            prev =  (flowerbed[index - 1] == 0)?true:false;
        }

        if (index == flowerbed.Length - 1) {
            next = true;
        } 
        else {
            next =  (flowerbed[index + 1] == 0)?true:false;
        }
        
        return prev && curr & next;
    }
}

/*
You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

 

Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true
Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false
 

Constraints:

1 <= flowerbed.length <= 2 * 104
flowerbed[i] is 0 or 1.
There are no two adjacent flowers in flowerbed.
0 <= n <= flowerbed.length
*/